#pragma checksum "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452ef4e9be669819b29e40595ba46f4d89275e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExerciseVariants_Delete), @"mvc.1.0.view", @"/Views/ExerciseVariants/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452ef4e9be669819b29e40595ba46f4d89275e8c", @"/Views/ExerciseVariants/Delete.cshtml")]
    public class Views_ExerciseVariants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OOP_ASU_5.Domain.ExerciseVariant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ExerciseVariant</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DifficultyCoefficient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DifficultyCoefficient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Exercise));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Dyupich\source\repos\OOP_ASU_5\OOP_ASU_5.API\Views\ExerciseVariants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Exercise.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""Id"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_ASU_5.Domain.ExerciseVariant> Html { get; private set; }
    }
}
#pragma warning restore 1591