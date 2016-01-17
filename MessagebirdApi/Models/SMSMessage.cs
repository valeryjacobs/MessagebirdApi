using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagebirdApi.Models
{
    public class SMSMessage
    {
        public string Sender { get; set; }
        public string Number { get; set; }
        public string MessageText { get; set; }
    }
}
