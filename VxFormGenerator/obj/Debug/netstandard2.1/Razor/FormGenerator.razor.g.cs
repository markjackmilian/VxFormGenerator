#pragma checksum "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e1a320469575d46caa6e3fac94ed9a740aa2fd"
// <auto-generated/>
#pragma warning disable 1591
namespace VxFormGenerator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class FormGenerator<TValue> : FormGeneratorComponent<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor"
                  DataContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor"
                           context => OnValidSubmit.InvokeAsync(context)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 10 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor"
     foreach (var field in Properties)
    {

        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, 
#nullable restore
#line 13 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor"
         RenderFormElement(field)

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 13 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormGenerator.razor"
                                 ;
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.AddMarkupContent(11, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591