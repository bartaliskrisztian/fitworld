#pragma checksum "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c672610ec2f1ebd967fbabfaf267ed70df7c84e"
// <auto-generated/>
#pragma warning disable 1591
namespace FitnessProject.Pages.ClientPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addClient")]
    public partial class AddClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Client</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "form", "Name");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                        client.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => client.Name = __value, client.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"form-group\"><label for=\"Photo\" class=\"control-label\">Photo</label>\r\n        <input form=\"Photo\" class=\"form-control\" type=\"file\" accept=\"image/*\"></div>\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "<label for=\"Phone\" class=\"control-label\">Phone number</label>\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "form", "phone");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                         client.Phone_number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => client.Phone_number = __value, client.Phone_number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "<label for=\"Email\" class=\"control-label\">Email</label>\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "Email");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                         client.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => client.Email = __value, client.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "<label for=\"Pin\" class=\"control-label\">PIN</label>\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "form", "Pin");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                       client.PIN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => client.PIN = __value, client.PIN));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label for=\"Address\" class=\"control-label\">Address</label>\r\n        ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "form", "Address");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                           client.Address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => client.Address = __value, client.Address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "<label for=\"membership\" class=\"control-label\">Membership</label>\r\n        ");
            __builder.OpenElement(51, "select");
            __builder.AddAttribute(52, "form", "membership");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                               selectedMembershipIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedMembershipIndex = __value, selectedMembershipIndex));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 38 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
             foreach (var memShip in memShips)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 40 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                memShip.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, 
#nullable restore
#line 40 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                             memShip.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 41 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.AddMarkupContent(60, "<div class=\"form-group\"><canvas></canvas></div>\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-4");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-primary");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                                        CreateClient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "value", "Add client");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-primary");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\AddClient.razor"
       
    String clientPhoto;
    Client client = new Client();
    int newClientId;
    List<Membership> memShips = new List<Membership>();
    int selectedMembershipIndex;

    protected override async Task OnInitializedAsync()
    {
        memShips = await Task.Run(() => membershipService.GetMemberships());
    }

    protected void CreateClient()
    {

        string bar_code = Guid.NewGuid().ToString();
        DateTime current_date = DateTime.Now;

        client.Bar_code = bar_code;
        client.Inserted_date = current_date;

        CreateClientMembership();
        newClientId = objClientService.AddClient(client);

        toastService.ShowInfo("Client added successfully.");
        NavigationManager.NavigateTo("clients");
    }

    protected void CreateClientMembership()
    {
        ClientMembership clientMembership = new ClientMembership();
        Membership selectedMembership = memShips[selectedMembershipIndex];
        DateTime current_date = DateTime.Now;

        clientMembership.Client_Id = newClientId;
        clientMembership.Membership_Id = selectedMembership.Id;
        clientMembership.Buying_Date = current_date;
        clientMembership.Bar_Code = client.Bar_code;
        clientMembership.Price = selectedMembership.Price;
        clientMembership.Available_until = current_date.AddDays(selectedMembership.Days_available);
        clientMembership.First_Usage_Date = current_date;
        clientMembership.Gym_Id = selectedMembership.Gym_id;

        clientMembershipService.AddClientMembership(clientMembership);
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("clients");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientMembershipService clientMembershipService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MembershipService membershipService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientService objClientService { get; set; }
    }
}
#pragma warning restore 1591
