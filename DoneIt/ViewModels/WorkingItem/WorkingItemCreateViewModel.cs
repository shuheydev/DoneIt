using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DoneIt.Models;

namespace DoneIt.ViewModels.WorkingItem
{
    public class WorkingItemCreateViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "From")]
        public DateTimeOffset DateTimeFrom { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "To")]
        public DateTimeOffset? DateTimeTo { get; set; }
    }
}
