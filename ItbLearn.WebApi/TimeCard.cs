using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItbLearn.WebApi
{
    public class TimeCard
    {
        public string UserName { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}
