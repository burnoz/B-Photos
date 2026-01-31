using System.Net.Http.Json;
using B_Photos.Models;

namespace B_Photos.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "";

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }

        public async Task<List<Photo>> GetPhotosAsync(int page, int pageSize)
        {
            var url = $"photo?page={page}&pageSize={pageSize}";

            try
            {
                var photos = await _httpClient.GetFromJsonAsync<List<Photo>>(url);
                return photos ?? new List<Photo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener fotos: {ex.Message}");
                return new List<Photo>();
            }
        }
    }
}
