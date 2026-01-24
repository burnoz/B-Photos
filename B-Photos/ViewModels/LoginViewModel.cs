using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace B_Photos.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string username;

    [ObservableProperty]
    private string password;

    [RelayCommand]
    private async Task Login()
    {
        if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.GoToAsync("//GalleryPage");
        }
        else
        {
            await Shell.Current.DisplayAlertAsync("Error", "Por favor ingresa tus credenciales.", "OK");
        }
    }
}