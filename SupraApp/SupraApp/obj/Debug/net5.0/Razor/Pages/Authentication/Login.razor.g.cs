#pragma checksum "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4371f60e9ca5fa7070d4bcc08a121606617851"
// <auto-generated/>
#pragma warning disable 1591
namespace SupraAppWeb.Pages.Authentication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using SupraAppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using SupraAppWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using SupraEntities.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using SupraEntities.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using SupraService.Bussiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
using SupraAppWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenComponent<MudBlazor.MudText>(1);
            __builder.AddAttribute(2, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
               Typo.h4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Bienvenido");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(7);
            __builder.AddAttribute(8, "Label", "Usuario");
            __builder.AddAttribute(9, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 14 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Class", "my-6");
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 14 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                       Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __Blazor.SupraAppWeb.Pages.Authentication.Login.TypeInference.CreateMudTextField_0(__builder, 14, 15, "Contraseña", 16, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                  Variant.Outlined

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                PasswordInput

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                                          Adornment.End

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                                                                         PasswordInputIcon

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                                                                                                              PassHidden

#line default
#line hidden
#nullable disable
            ), 21, "my-6", 22, 
#nullable restore
#line 16 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                            Password

#line default
#line hidden
#nullable disable
            , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Password = __value, Password)));
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudSelect<string>>(25);
            __builder.AddAttribute(26, "Label", "Compañía");
            __builder.AddAttribute(27, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 18 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.SupraAppWeb.Pages.Authentication.Login.TypeInference.CreateMudSelectItem_1(__builder2, 29, 30, 
#nullable restore
#line 19 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                            "SupraSistemas SA de CV"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n    ");
                __Blazor.SupraAppWeb.Pages.Authentication.Login.TypeInference.CreateMudSelectItem_2(__builder2, 32, 33, 
#nullable restore
#line 20 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                            "Glipsa"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n    ");
                __Blazor.SupraAppWeb.Pages.Authentication.Login.TypeInference.CreateMudSelectItem_3(__builder2, 35, 36, 
#nullable restore
#line 21 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                            "Alianza"

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "Class", "d-flex justify-space-between align-center");
            __builder.OpenComponent<MudBlazor.MudLink>(40);
            __builder.AddAttribute(41, "Href", "/");
            __builder.AddAttribute(42, "Style", "text-align:center");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "¿Olvidaste tu contraseña?");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(46);
            __builder.AddAttribute(47, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 30 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 30 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Link", "/");
            __builder.AddAttribute(50, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 30 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                         Size.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
                                                                                                                doLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(54, "Ingresar");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Pages\Authentication\Login.razor"
       
    string Password { get; set; } = "SERP@Sistemas.2016";
    string Email { get; set; } = "cmunoz@supra-sistemas.com";
    bool PasswordVisibility;
    InputType PasswordInput = InputType.Password;
    string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

    void PassHidden()
    {
        if (PasswordVisibility)
        {
            PasswordVisibility = false;
            PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            PasswordInput = InputType.Password;
        }
        else
        {
            PasswordVisibility = true;
            PasswordInputIcon = Icons.Material.Filled.Visibility;
            PasswordInput = InputType.Text;
        }
    }

    private UserInfo userInfo = new UserInfo();

    private async Task doLogin()
    {
        userInfo.Email = Email;
        userInfo.Password = Password;

        var settings = new JsonSerializerSettings { DateFormatString = "yyyy-MM-ddTHH:mm:ss" };
        var stringData = JsonConvert.SerializeObject(userInfo, settings);
        var content = new StringContent(stringData, Encoding.UTF8, "application/json");

        var result = await http.PostAsync("https://supra.carlosomar.mx/api/Usuarios/Login", content);

        UserToken userToken = await result.Content.ReadFromJsonAsync<UserToken>();
        await loginService.Login(userToken.Token);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SupraAppWeb.Auth.ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.SupraAppWeb.Pages.Authentication.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.InputType __arg2, int __seq3, global::MudBlazor.Adornment __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg5, int __seq6, global::System.String __arg6, int __seq7, T __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "InputType", __arg2);
        __builder.AddAttribute(__seq3, "Adornment", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentIcon", __arg4);
        __builder.AddAttribute(__seq5, "OnAdornmentClick", __arg5);
        __builder.AddAttribute(__seq6, "Class", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
