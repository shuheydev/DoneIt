using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoneIt.ViewModels.WorkingItem
{
    public class WorkingItemEditViewModel : WorkingItemCreateViewModel
    {
        public WorkingItemEditViewModel(Models.WorkingItem model)
        {
            Set(model);
        }
        public WorkingItemEditViewModel()
        {

        }

        public void Set(Models.WorkingItem model)
        {
            this.PrivateId = model.PrivateId;
            this.Name = model.Name;
            this.Description = model.Description;
            this.DateTimeFrom = model.From;
            this.DateTimeTo = model.To;
        }

        [Required]
        [Display(Name = "Id")]
        public int PrivateId { get; set; }
    }
}
