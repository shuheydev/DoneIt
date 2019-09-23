using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoneIt.Models
{
    public class WorkingItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; }

        [Required]
        public int PrivateId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTimeOffset From { get; set; }

        [DataType(DataType.DateTime)]
        public DateTimeOffset? To { get; set; }
    }
}
