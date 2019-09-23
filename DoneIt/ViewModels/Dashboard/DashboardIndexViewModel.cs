using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoneIt.ViewModels.Dashboard
{
    public class DashboardIndexViewModel
    {
        public IList<DashboardWorkingItem> WorkingItems { get; set; }

        public class DashboardWorkingItem
        {
            [Display(Name = "Title")]
            public string Name { get; set; }

            [Display(Name = "Duration")]
            public string Duration { get; set; }

            [Display(Name = "LastModified")]
            public string LastModified { get; set; }
        }
    }
}
