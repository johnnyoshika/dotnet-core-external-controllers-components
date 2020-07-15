using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ExternalComponents
{
    public class VacationComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View("~/ExternalComponents/Vacation.cshtml");
    }
}
