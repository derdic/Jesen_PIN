using Microsoft.AspNetCore.Components;
using Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shop.Client.Pages
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Product = new List<Product>

        private async Task Create
        {
            await _client.PostAsJsonAsync(Endpoints.ModelsEndpoint, model);
            _navManager.NavigateTo("/models/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}

