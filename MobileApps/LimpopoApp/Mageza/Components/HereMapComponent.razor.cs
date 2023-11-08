using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mageza.Components
{
    public partial class HereMapComponent
    {
        [Inject] IJSRuntime js { get; set; }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
               var dd =  await js.InvokeAsync<object>("IsConnectedMap");
                await js.InvokeVoidAsync("LoadAndDisplayMap");
                StateHasChanged();  
            }
            //return base.OnAfterRenderAsync(firstRender);
        }
    }
}
