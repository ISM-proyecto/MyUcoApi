using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUcoApi.Models
{
    public class Beacon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
    }
}
