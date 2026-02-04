using B_Photos.Views;

namespace B_Photos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PhotoDetailView), typeof(PhotoDetailView));
        }
    }
}
