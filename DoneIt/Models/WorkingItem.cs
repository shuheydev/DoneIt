using System;
using System.ComponentModel.DataAnnotations;

namespace DoneIt.Models
{
    public class WorkingItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTimeOffset From { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset To { get; set; }
    }
}
