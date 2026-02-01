using B_Photos.Models;
using B_Photos.Services;
using B_Photos.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace B_Photos.ViewModels;

public partial class GalleryViewModel : ObservableObject
{
    private readonly IApiService _apiService;
    private int _currentPage = 1;
    private readonly int PageSize = 30;

    //[ObservableProperty]
    //private bool isLoading;

    private bool _isLoading;
    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public ObservableCollection<Photo> Photos { get; } = new();

    public GalleryViewModel(IApiService apiService)
    {
        _apiService = apiService;
    }

    [RelayCommand]
    public async Task LoadMorePhotos()
    {
        if (IsLoading) return;

        try
        {
            IsLoading = true;

            var newPhotos = await _apiService.GetPhotosAsync(_currentPage, PageSize);

            if (newPhotos.Any())
            {
                foreach (var photo in newPhotos)
                {
                    Photos.Add(photo);
                }
                _currentPage++;
            }
        }
        finally
        {
            IsLoading = false;
        }
    }
}