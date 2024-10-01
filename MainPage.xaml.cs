using Microsoft.Maui.Controls;


namespace Cafeteria_movil

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConnectButtonClicked(object sender, EventArgs e)
        {
            var dbService = new Conection();
            dbService.ConnectionString();
        }


    }
}
