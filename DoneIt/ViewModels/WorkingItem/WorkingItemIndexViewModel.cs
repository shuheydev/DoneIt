using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoneIt.ViewModels.WorkingItem
{
    public class WorkingItemIndexViewModel
    {
        public IList<WorkingItemIndex> WorkingItems { get; }

        public WorkingItemIndexViewModel(List<Models.WorkingItem> models)
        {
            this.WorkingItems = models.Select(item => new WorkingItemIndex(item)).ToList();
        }

        public class WorkingItemIndex
        {
            public WorkingItemIndex(Models.WorkingItem model)
            {
                Set(model);
            }

            private void Set(Models.WorkingItem model)
            {
                this.PrivateId = model.PrivateId;
                this.Name = model.Name;
                this.Description = model.Description;
                this.DateTimeFrom = model.From.ToString("yyyy/MM/dd HH:mm");
                this.DateTimeTo = model.To == null ? "" : model.To.Value.ToString("yyyy/MM/dd HH:mm");
            }

            [Display(Name = "ID")]
            public int PrivateId { get; private set; }

            [Display(Name = "Title")]
            public string Name { get; private set; }

            [Display(Name = "Description")]
            public string Description { get; private set; }

            [Display(Name = "From")]
            public string DateTimeFrom { get; private set; }

            [Display(Name = "To")]
            public string DateTimeTo { get; private set; }
        }
    }
}
