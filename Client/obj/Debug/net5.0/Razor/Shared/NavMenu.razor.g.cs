#pragma checksum "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056f60ac727143923f9595f5e41a12317bf9e271"
// <auto-generated/>
#pragma warning disable 1591
namespace BoilerPlate.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using BoilerPlate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documents\PersonalProject\BlazorAdminLteBoilerplate\Client\_Imports.razor"
using BoilerPlate.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"main-header navbar navbar-expand navbar-white navbar-light\" b-nobwwj4tis><ul class=\"navbar-nav\" b-nobwwj4tis><li class=\"nav-item\" b-nobwwj4tis><a class=\"nav-link\" data-widget=\"pushmenu\" href=\"#\" role=\"button\" b-nobwwj4tis><i class=\"fas fa-bars\" b-nobwwj4tis></i></a></li>\r\n        <li class=\"nav-item d-none d-sm-inline-block\" b-nobwwj4tis><a href=\"index3.html\" class=\"nav-link\" b-nobwwj4tis>Home</a></li>\r\n        <li class=\"nav-item d-none d-sm-inline-block\" b-nobwwj4tis><a href=\"#\" class=\"nav-link\" b-nobwwj4tis>Contact</a></li></ul>\r\n\r\n    \r\n    <ul class=\"navbar-nav ml-auto\" b-nobwwj4tis><li class=\"nav-item\" b-nobwwj4tis><a class=\"nav-link\" data-widget=\"navbar-search\" href=\"#\" role=\"button\" b-nobwwj4tis><i class=\"fas fa-search\" b-nobwwj4tis></i></a>\r\n            <div class=\"navbar-search-block\" b-nobwwj4tis><form class=\"form-inline\" b-nobwwj4tis><div class=\"input-group input-group-sm\" b-nobwwj4tis><input class=\"form-control form-control-navbar\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\" b-nobwwj4tis>\r\n                        <div class=\"input-group-append\" b-nobwwj4tis><button class=\"btn btn-navbar\" type=\"submit\" b-nobwwj4tis><i class=\"fas fa-search\" b-nobwwj4tis></i></button>\r\n                            <button class=\"btn btn-navbar\" type=\"button\" data-widget=\"navbar-search\" b-nobwwj4tis><i class=\"fas fa-times\" b-nobwwj4tis></i></button></div></div></form></div></li>\r\n\r\n        \r\n        <li class=\"nav-item dropdown\" b-nobwwj4tis><a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\" b-nobwwj4tis><i class=\"far fa-comments\" b-nobwwj4tis></i>\r\n                <span class=\"badge badge-danger navbar-badge\" b-nobwwj4tis>3</span></a>\r\n            <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\" b-nobwwj4tis><a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><div class=\"media\" b-nobwwj4tis><img src=\"AdminLte/dist/img/user1-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 mr-3 img-circle\" b-nobwwj4tis>\r\n                        <div class=\"media-body\" b-nobwwj4tis><h3 class=\"dropdown-item-title\" b-nobwwj4tis>\r\n                                Brad Diesel\r\n                                <span class=\"float-right text-sm text-danger\" b-nobwwj4tis><i class=\"fas fa-star\" b-nobwwj4tis></i></span></h3>\r\n                            <p class=\"text-sm\" b-nobwwj4tis>Call me whenever you can...</p>\r\n                            <p class=\"text-sm text-muted\" b-nobwwj4tis><i class=\"far fa-clock mr-1\" b-nobwwj4tis></i> 4 Hours Ago</p></div></div></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><div class=\"media\" b-nobwwj4tis><img src=\"AdminLte/dist/img/user8-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\" b-nobwwj4tis>\r\n                        <div class=\"media-body\" b-nobwwj4tis><h3 class=\"dropdown-item-title\" b-nobwwj4tis>\r\n                                John Pierce\r\n                                <span class=\"float-right text-sm text-muted\" b-nobwwj4tis><i class=\"fas fa-star\" b-nobwwj4tis></i></span></h3>\r\n                            <p class=\"text-sm\" b-nobwwj4tis>I got your message bro</p>\r\n                            <p class=\"text-sm text-muted\" b-nobwwj4tis><i class=\"far fa-clock mr-1\" b-nobwwj4tis></i> 4 Hours Ago</p></div></div></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><div class=\"media\" b-nobwwj4tis><img src=\"AdminLte/dist/img/user3-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\" b-nobwwj4tis>\r\n                        <div class=\"media-body\" b-nobwwj4tis><h3 class=\"dropdown-item-title\" b-nobwwj4tis>\r\n                                Nora Silvester\r\n                                <span class=\"float-right text-sm text-warning\" b-nobwwj4tis><i class=\"fas fa-star\" b-nobwwj4tis></i></span></h3>\r\n                            <p class=\"text-sm\" b-nobwwj4tis>The subject goes here</p>\r\n                            <p class=\"text-sm text-muted\" b-nobwwj4tis><i class=\"far fa-clock mr-1\" b-nobwwj4tis></i> 4 Hours Ago</p></div></div></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item dropdown-footer\" b-nobwwj4tis>See All Messages</a></div></li>\r\n        \r\n        <li class=\"nav-item dropdown\" b-nobwwj4tis><a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\" b-nobwwj4tis><i class=\"far fa-bell\" b-nobwwj4tis></i>\r\n                <span class=\"badge badge-warning navbar-badge\" b-nobwwj4tis>15</span></a>\r\n            <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\" b-nobwwj4tis><span class=\"dropdown-item dropdown-header\" b-nobwwj4tis>15 Notifications</span>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><i class=\"fas fa-envelope mr-2\" b-nobwwj4tis></i> 4 new messages\r\n                    <span class=\"float-right text-muted text-sm\" b-nobwwj4tis>3 mins</span></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><i class=\"fas fa-users mr-2\" b-nobwwj4tis></i> 8 friend requests\r\n                    <span class=\"float-right text-muted text-sm\" b-nobwwj4tis>12 hours</span></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item\" b-nobwwj4tis><i class=\"fas fa-file mr-2\" b-nobwwj4tis></i> 3 new reports\r\n                    <span class=\"float-right text-muted text-sm\" b-nobwwj4tis>2 days</span></a>\r\n                <div class=\"dropdown-divider\" b-nobwwj4tis></div>\r\n                <a href=\"#\" class=\"dropdown-item dropdown-footer\" b-nobwwj4tis>See All Notifications</a></div></li>\r\n        <li class=\"nav-item\" b-nobwwj4tis><a class=\"nav-link\" data-widget=\"fullscreen\" href=\"#\" role=\"button\" b-nobwwj4tis><i class=\"fas fa-expand-arrows-alt\" b-nobwwj4tis></i></a></li>\r\n        <li class=\"nav-item\" b-nobwwj4tis><a class=\"nav-link\" data-widget=\"control-sidebar\" data-slide=\"true\" href=\"#\" role=\"button\" b-nobwwj4tis><i class=\"fas fa-th-large\" b-nobwwj4tis></i></a></li></ul></nav>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
