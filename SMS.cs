using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.AspNet.Core;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;

namespace Plex_Notifier_App
{
    public class SMS : TwilioController
    {
        public static void createMessage(string to, string from, string sid, string body)
        {
            var message = MessageResource.Create(
                to: to,
                from: from,
                body: body);
        }

        [HttpPost]
        public void SmsReponse()
        {

        }
    }
}
