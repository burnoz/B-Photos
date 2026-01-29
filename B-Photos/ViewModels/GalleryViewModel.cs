using System.Collections.ObjectModel;
using System.Diagnostics;
using B_Photos.Models;
using B_Photos.Services;

namespace B_Photos.ViewModels;

public class GalleryViewModel
{
    private readonly IApiService _apiService;
    public ObservableCollection<Photo> Photos { get; set; }

    public GalleryViewModel(IApiService apiService)
    {
        _apiService = apiService;
        Photos = [];
        //LoadMockData();
        _ = LoadPhotosAsync();
    }

    private void LoadMockData()
    {
        for (int i = 1; i <= 20; i++)
        {
            Photos.Add(new Photo
            {
                Title = $"Foto {i}",
                ImageURL = $"https://picsum.photos/300/300?random={i}",
                DateTaken = DateTime.Now.AddDays(-i)
            });
        }
    }

    private async Task LoadPhotosAsync()
    {
        var photos = await _apiService.GetPhotosAsync();

        foreach (var photo in photos)
        {
            Console.WriteLine(photo.Title);
            Photos.Add(photo);
        }
    }
}