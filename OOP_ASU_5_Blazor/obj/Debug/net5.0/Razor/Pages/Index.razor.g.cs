#pragma checksum "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9965988c6a84a20235d4d7c746eaaa902e291234"
// <auto-generated/>
#pragma warning disable 1591
namespace OOP_ASU_5_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using OOP_ASU_5_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\_Imports.razor"
using OOP_ASU_5_Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<OOP_ASU_5_Blazor.Pages.LessonListComponent>(1);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5_Blazor\Pages\Index.razor"
       

    string Message { get; set; }

    void ToMessage(string message1)
    {
        Message = message1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591