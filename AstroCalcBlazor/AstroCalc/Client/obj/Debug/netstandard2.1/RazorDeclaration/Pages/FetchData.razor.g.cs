#pragma checksum "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f10ce6c9927a4d325212b4cb253f529c468342"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AstroCalc.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using AstroCalc.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\_Imports.razor"
using AstroCalc.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\Pages\FetchData.razor"
using AstroCalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\0x00\Documents\GitHub\AstroCalc\AstroCalcBlazor\AstroCalc\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
