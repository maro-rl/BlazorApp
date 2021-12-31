using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace BlazorApp.Pages
{
    public partial class Dashboard
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await jsRuntime.InvokeVoidAsync("lineChart");
            await jsRuntime.InvokeVoidAsync("barChart");
            await jsRuntime.InvokeVoidAsync("pieChart");
            await jsRuntime.InvokeVoidAsync("dynamicChart"); 
            await jsRuntime.InvokeVoidAsync("dougnutChart"); 
            if (firstRender)
                await jsRuntime.InvokeVoidAsync("loadBingMap");

        }
    }
}
