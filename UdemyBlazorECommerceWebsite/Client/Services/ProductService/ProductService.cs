using static System.Net.WebRequestMethods;

namespace UdemyBlazorECommerceWebsite.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
                Products = result.Data;
        }

        public Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
    }
}
