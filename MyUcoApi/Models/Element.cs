using System.ComponentModel.DataAnnotations;

namespace MyUcoApi.Models
{
    public class Element
    {
        [Key]
        public int Id { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
}
}