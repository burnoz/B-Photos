using B_Photos.ViewModels;
using B_Photos.Views;
using Microsoft.Extensions.Logging;

namespace B_Photos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // ViewModels
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<GalleryViewModel>();
            builder.Services.AddTransient<AlbumsViewModel>();

            // Views
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<GalleryView>();
            builder.Services.AddTransient<AlbumsView>();

            return builder.Build();
        }
    }
}
