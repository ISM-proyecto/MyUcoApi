using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUcoApi.Models
{
    public class Trajectory
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Group> Groups { get; internal set; }
        public string Name { get; internal set; }
    }
}
