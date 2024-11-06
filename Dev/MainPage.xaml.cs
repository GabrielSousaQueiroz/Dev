namespace Dev
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGitHubClicked(object sender, EventArgs e)
        {
            // Substitua pela URL do seu GitHub
            var url = "https://github.com/seu_usuario";
            await Launcher.OpenAsync(url);
        }
    }
    

}
