using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Components
{
    public class ColorComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View("~/Components/Color.cshtml");
    }
}
