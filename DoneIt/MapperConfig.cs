using AutoMapper;
using DoneIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DoneIt.ViewModels.WorkingItem.WorkingItemIndexViewModel;

namespace DoneIt
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<WorkingItem, WorkingItemIndex>();
            CreateMap<WorkingItemIndex, WorkingItem>();
        }
    }
}
