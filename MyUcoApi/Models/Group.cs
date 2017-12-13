using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUcoApi.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Element> Elements {get;set;}
    }
}
