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
        // Validación básica (puedes conectarlo a tu servidor Ubuntu después)
        if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
        {
            // Navegación absoluta hacia la TabBar (GalleryPage)
            await Shell.Current.GoToAsync("//GalleryPage");
        }
        else
        {
            await Shell.Current.DisplayAlert("Error", "Por favor ingresa tus credenciales.", "OK");
        }
    }
}