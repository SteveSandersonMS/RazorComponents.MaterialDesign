using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponents.MaterialDesign
{
    public abstract class MdcComponentBase : ComponentBase
    {
        protected override Task OnAfterRenderAsync(bool isFirstRender)
        {
            if (isFirstRender)
            {
                return OnAfterFirstRenderAsync();
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        protected virtual Task OnAfterFirstRenderAsync()
            => Task.CompletedTask;
    }
}
