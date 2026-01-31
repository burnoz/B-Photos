using System.Collections.Generic;
using System.Threading.Tasks;
using B_Photos.Models;

namespace B_Photos.Services
{
    public interface IApiService
    {
        Task<List<Photo>> GetPhotosAsync(int page, int pageSize);
    }
}