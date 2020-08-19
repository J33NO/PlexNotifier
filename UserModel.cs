using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex_Notifier_App
{
    public class UserModel
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public bool smsOptIn { get; set; }
        public string email { get; set; }
        public bool isChecked {get; set; }
    }
}
