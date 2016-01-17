using MessageBird;
using MessageBird.Exceptions;
using MessageBird.Objects;
using MessagebirdApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessagebirdApi.Controllers
{
    public class MessagesController : ApiController
    {
        [HttpPost]
        public void Post([FromBody] SMSMessage message)
        {
            //Client client = Client.CreateDefault("live_GXtbpaaUzPdIqwWNfoObGMc0e", null);
            Client client = Client.CreateDefault("test_kSs7gXtrGA7sApkJgCyF69a5F", null);  

            try
            {
                Message messageResponse = client.SendMessage(message.Sender, message.MessageText, new[] { long.Parse(message.Number) });
            }
            catch (ErrorException e)
            {
                // Either the request fails with error descriptions from the endpoint.
                if (e.HasErrors)
                {
                    foreach (Error error in e.Errors)
                    {
                        //Console.WriteLine("code: {0} description: '{1}' parameter: '{2}'", error.Code, error.Description, error.Parameter);
                    }
                }
                // or fails without error information from the endpoint, in which case the reason contains a 'best effort' description.
                if (e.HasReason)
                {
                    //Console.WriteLine(e.Reason);
                }
            }
        }
    }
}
