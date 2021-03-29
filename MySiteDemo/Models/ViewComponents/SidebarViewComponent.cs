using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySiteDemo.Domain;

namespace MySiteDemo.Models.ViewComponents
{
    public class SideBarViewComponent: ViewComponent
    {
        private readonly DataManager dataManager;

        public SideBarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
