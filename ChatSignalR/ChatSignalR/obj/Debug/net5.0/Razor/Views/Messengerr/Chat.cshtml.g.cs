#pragma checksum "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8024afcea86e2643fd7cbeca783214401e8c3c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messengerr_Chat), @"mvc.1.0.view", @"/Views/Messengerr/Chat.cshtml")]
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
#nullable restore
#line 1 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\_ViewImports.cshtml"
using ChatSignalR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\_ViewImports.cshtml"
using ChatSignalR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\_ViewImports.cshtml"
using ChatSignalR.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8024afcea86e2643fd7cbeca783214401e8c3c2d", @"/Views/Messengerr/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64b5c3354c087e2cfb8136c596d23777d956cec", @"/Views/_ViewImports.cshtml")]
    public class Views_Messengerr_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"mb-3\">Send Message to ");
#nullable restore
#line 9 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
                                        Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <hr />\r\n        </div>\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"messageCustom mb-3\">\r\n");
#nullable restore
#line 14 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
                  foreach (var item in Model.Messages)
	             {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t             <p");
            BeginWriteAttribute("class", " class=\"", 414, "\"", 474, 1);
#nullable restore
#line 16 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
WriteAttributeValue("", 422, item.SenderId==Model.SenderId?"sender":"receiver", 422, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
                                                                                Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"messageDate\">");
#nullable restore
#line 16 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
                                                                                                                     Write(item.CreatedDate.ToString("hh : mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 17 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
	             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""col-lg-12"">
            <div class=""input-group mb-3"">
                <input type=""text"" class=""form-control"" id=""messengerInput"" placeholder=""Type Your Message..."">
                <input hidden id=""receiverId""");
            BeginWriteAttribute("value", " value=\"", 854, "\"", 876, 1);
#nullable restore
#line 23 "C:\Users\TUF DASH\Desktop\ChatSignalR\ChatSignalR\Views\Messengerr\Chat.cshtml"
WriteAttributeValue("", 862, Model.User.Id, 862, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"ml-2 btn btn-outline-success\" type=\"button\" id=\"messengerButton\">Send</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
