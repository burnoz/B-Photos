using B_Photos.ViewModels;

namespace B_Photos.Views;

public partial class GalleryView : ContentPage
{
    public GalleryView(GalleryViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is GalleryViewModel viewModel)
        {
            if (viewModel.Photos.Count == 0)
            {
                await viewModel.LoadMorePhotosCommand.ExecuteAsync(null);
            }
        }
    }
}