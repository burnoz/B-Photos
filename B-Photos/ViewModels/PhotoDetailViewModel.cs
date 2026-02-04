using B_Photos.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace B_Photos.ViewModels;

[QueryProperty(nameof(Photo), "Photo")]
public partial class PhotoDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Photo? photo;
}