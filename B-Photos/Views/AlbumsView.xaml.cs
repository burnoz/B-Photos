using B_Photos.ViewModels;

namespace B_Photos.Views;

public partial class AlbumsView : ContentPage
{
	public AlbumsView(AlbumsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}