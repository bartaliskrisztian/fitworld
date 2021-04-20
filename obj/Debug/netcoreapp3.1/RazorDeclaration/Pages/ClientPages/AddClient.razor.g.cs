// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
