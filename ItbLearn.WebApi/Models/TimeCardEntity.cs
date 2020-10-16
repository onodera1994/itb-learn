using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItbLearn.WebApi.Models
{
    public class TimeCardEntity
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset ArrivedTime { get; set; }
        public DateTimeOffset? LeftTime { get; set; }
    }
}
