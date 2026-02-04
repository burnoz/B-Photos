using B_Photos.ViewModels;

namespace B_Photos.Views;

public partial class PhotoDetailView : ContentPage
{
	public PhotoDetailView(PhotoDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}