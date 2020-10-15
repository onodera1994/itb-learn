using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItbLearn.Models
{
    public class TimeCard
    {
        public string UserName { get; set; }
        public DateTimeOffset Time { get; set; }

        public TimeCard(string userName, DateTimeOffset now)
        {
            UserName = userName;
            Time = now;
        }
        public TimeCard()
        {

        }

    }
}
