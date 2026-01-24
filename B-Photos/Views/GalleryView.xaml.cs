using B_Photos.ViewModels;

namespace B_Photos.Views;

public partial class GalleryView : ContentPage
{
	public GalleryView(GalleryViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}