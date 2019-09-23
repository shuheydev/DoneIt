using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoneIt.ViewModels.WorkingItem
{
    public class WorkingItemDeleteViewModel
    {
        public WorkingItemDeleteViewModel(Models.WorkingItem model)
        {
            Set(model);
        }
        public WorkingItemDeleteViewModel()
        {

        }

        public void Set(Models.WorkingItem model)
        {
            this.Id = model.Id;
            this.OwnerId = model.OwnerId;
            this.PrivateId = model.PrivateId;
            this.Name = model.Name;
            this.Description = model.Description;
            this.DateTimeFrom = model.From.ToString("yyyy/MM/dd HH:mm");
            this.DateTimeTo = model.To == null ? "" : model.To.Value.ToString("yyyy/MM/dd HH:mm");
        }

        public int Id { get; set; }

        [Display(Name = "Id")]
        public int PrivateId { get; set; }

        public string OwnerId { get; set; }

        [Display(Name = "Title")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "From")]
        public string DateTimeFrom { get; set; }

        [Display(Name = "To")]
        public string DateTimeTo { get; set; }
    }
}
