#pragma checksum "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a06f43f0dd669d7986e14634dc9b789eca36f3d"
// <auto-generated/>
#pragma warning disable 1591
namespace SupraAppWeb.Shared
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
#line 3 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
using SupraAppWeb.Pages.Dialogs;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 5 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.AddAttribute(4, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 6 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth?>(
#nullable restore
#line 6 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                              MaxWidth.ExtraSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(9);
            __builder.AddAttribute(10, "RightToLeft", 
#nullable restore
#line 9 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                         _rightToLeft

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(12);
                __builder2.AddAttribute(13, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                          25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(15);
                    __builder3.AddAttribute(16, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 12 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(21);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(23);
                    __builder3.AddAttribute(24, "Text", "Notificaciones");
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudBadge>(26);
                        __builder4.AddAttribute(27, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                               3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                         Color.Warning

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Class", "mx-3 my-4");
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIcon>(32);
                            __builder5.AddAttribute(33, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                Icons.Material.Filled.Notifications

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(34, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                            Color.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(36);
                    __builder3.AddAttribute(37, "Text", "Mensajes");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudBadge>(39);
                        __builder4.AddAttribute(40, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                               7

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                         Color.Warning

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "Class", "mx-3 my-4");
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIcon>(45);
                            __builder5.AddAttribute(46, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                Icons.Material.Filled.Message

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(47, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                      Color.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(49);
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(51);
                        __builder4.AddAttribute(52, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudMenu>(53);
                            __builder5.AddAttribute(54, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                        true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(55, "ActivatorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudChip>(56);
                                __builder6.AddAttribute(57, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                            Icons.Material.Filled.Person

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(58, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 33 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                                 Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(60, 
#nullable restore
#line 33 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                                                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenuItem>(62);
                                __builder6.AddAttribute(63, "Link", "Logout");
                                __builder6.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(65, "Cerrar Sesión");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.AddAttribute(66, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudMenu>(67);
                            __builder5.AddAttribute(68, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                        true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(69, "ActivatorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudChip>(70);
                                __builder6.AddAttribute(71, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                            Icons.Material.Filled.Person

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(72, "Link", "Login");
                                __builder6.AddAttribute(73, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 43 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                                              Color.Error

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(75, "Iniciar Sesión");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(77);
                __builder2.AddAttribute(78, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 59 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                 25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "Class", "mudblazor-appbar-band");
                __builder2.AddAttribute(80, "Style", "top: 0");
                __builder2.AddAttribute(81, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                          _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(84);
                    __builder3.AddAttribute(85, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                              (e) => OpenDialog(closeButton)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDrawerHeader>(87);
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudAvatar>(89);
                            __builder5.AddAttribute(90, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 62 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                  Color.Transparent

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(91, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 62 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                           Size.Medium

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(92, "Image", "assets/supralogo.jpg");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudText>(94);
                            __builder5.AddAttribute(95, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 63 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(96, "Style", "margin-top:10px; margin-left:10px; font-size:18px");
                            __builder5.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(98, "Supra-Sistemas");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n        ");
                    __builder3.OpenComponent<SupraAppWeb.Shared.NavMenu>(100);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(102);
                __builder2.AddAttribute(103, "Class", "mudblazor-main-content");
                __builder2.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(105);
                    __builder3.AddAttribute(106, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 69 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                MaxWidth.False

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "Class", "p-4");
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(109, 
#nullable restore
#line 70 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(110, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudScrollToTop>(111);
                    __builder3.AddAttribute(112, "TopOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                   400

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudFab>(114);
                        __builder4.AddAttribute(115, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                           Icons.Material.Filled.KeyboardArrowUp

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(116, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 74 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
                                                                         Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\Operations3\Desktop\SupraApp 211106\SupraApp\Shared\MainLayout.razor"
 

    private bool _drawerOpen = true;
    private bool _rightToLeft = false;
    private string searchValue = string.Empty;
    DialogOptions closeButton = new DialogOptions() { CloseButton = true };

    private void OpenDialog(DialogOptions options)
    {
        Dialog.Show<DialogTest>("Compañias", options);
    }


    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }


    protected override void OnInitialized()
    {
        _currentTheme = _defaultTheme;

    }

    #region Theme

    private void DarkMode()
    {
        if (_currentTheme == _defaultTheme)
        {
            _currentTheme = _darkTheme;
        }
        else
        {
            _currentTheme = _defaultTheme;
        }
    }

    private MudTheme _currentTheme = new MudTheme();
    private readonly MudTheme _defaultTheme =
        new MudTheme()
        {
            Palette = new Palette()
            {

                //Black = "000000ff",
                //White = "FC0002",
                Primary = "#BDBDBF",
                //Tertiary = "FC0002",
                //Info = "000000ff",
                //Success = "000000ff",
                //Warning = "000000ff",
                //Error = "000000ff",
                //Dark = "000000ff",
                //TextPrimary = "000000ff",
                //TextSecondary = "000000ff",
                //TextDisabled = "000000ff",
                ActionDefault = "343A40",
                //ActionDisabled = "000000ff",
                //ActionDisabledBackground = "000000ff",
                //Background = "0071FE",
                //BackgroundGrey = "000000ff",
                //Surface = "000000ff",
                DrawerBackground = "#343A40",
                DrawerText = "#FFFFFF",
                DrawerIcon = "#FFFFFF",
                AppbarBackground = "#FFFFFF",
                AppbarText = "343A40",
                //LinesDefault = "000000ff",
                //LinesInputs = "000000ff",
                //Divider = "000000ff",
                //DividerLight = "000000ff",
                HoverOpacity = 0.06,
                //GrayDefault = "000000ff",
                //GrayLight = "000000ff",
                //GrayLighter = "000000ff",
                //GrayDark = "000000ff",
                //GrayDarker = "000000ff"

            }
        };

    private readonly MudTheme _darkTheme =
        new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "#2196F3",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                DrawerIcon = "rgba(255,255,255, 0.50)"
            }
        };

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
    }
}
#pragma warning restore 1591
