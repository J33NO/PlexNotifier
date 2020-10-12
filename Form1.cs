using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.AspNet.Core;
using Twilio.Rest.Api.V2010.Account;

namespace Plex_Notifier_App
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Next step is to try and swap from datatable to binding the data model to the datagridview
            // see: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-objects-to-windows-forms-datagridview-controls
            List<User> users = User.GetUsers();
            dataGridView1.DataSource = users;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string smsOptIn = dataGridView1.Rows[row.Index].Cells["Selected"].Value.ToString();
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                if (smsOptIn == "True")
                {
                    chk.Value = chk.FalseValue;
                }
            }
            chkBoxSelectAll.Checked = false;
            txtMessageBody.Text = "";
            lblResult.Text = "";
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            bool requiredFields = CheckRequiredFields();
            if(requiredFields == true)
            {
                int messagesSent = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string phoneNumber = row.Cells["phoneNumber"].Value.ToString();
                    string smsOptIn = row.Cells["Selected"].Value.ToString();
                    if (smsOptIn == "True" && phoneNumber != "")
                    {
                        try
                        {
                            var sid = ConfigurationManager.AppSettings.Get("accountSid");
                            var token = ConfigurationManager.AppSettings.Get("authToken");
                            var from = ConfigurationManager.AppSettings.Get("myTwilioNumber");
                            TwilioClient.Init(sid, token);

                            //Set header text(based on radio btns), body, and footer text.
                            string header = "";
                            string footer = "\n\nThis is an automated text message. Responses will not be seen.";
                            if (NewMovieRadioBtn.Checked)
                            {
                                header = "PLEX - New Movie Alert: ";
                            }
                            else if(NewShowRadioBtn.Checked)
                            {
                                header = "PLEX - New TV Show Alert: ";
                            }
                            else if (MaintenanceRadioBtn.Checked)
                            {
                                header = "PLEX - Maintenance Alert: ";
                            }
                            else
                            {
                                header = "PLEX - " + txtOther.Text + ": ";
                            }
                            string body = header + txtMessageBody.Text + footer;
                            SMS.createMessage(phoneNumber, from, sid, body);
                            messagesSent += 1;
                        }
                        catch (Exception ex)
                        {

                            lblResult.Text = "Error: Unable to send texts: " + ex.Message;
                        }

                    }
                }
                lblResult.Text = "Number of text messages sent: " + messagesSent;
            }
        }

        public bool CheckRequiredFields()
        {
            int usersSelected = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string smsOptIn = row.Cells["Selected"].Value.ToString();
                if(smsOptIn.ToLower() == "true")
                {
                    usersSelected += 1;
                }
            }

            if(usersSelected == 0)
            {
                lblResult.Text = "Error: Please select at least one User.";
                return false;
            }
            else if(txtMessageBody.Text == "")
            {
                lblResult.Text = "Error: Please enter a Notification.";
                return false;
            }
            else if(NewMovieRadioBtn.Checked == false && NewShowRadioBtn.Checked ==  false && MaintenanceRadioBtn.Checked == false && OtherRadioBtn.Checked == false)
            {
                lblResult.Text = "Error: Please select a Notification Type";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                if (chkBoxSelectAll.Checked == true)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                }
            }
        }
    }
}
