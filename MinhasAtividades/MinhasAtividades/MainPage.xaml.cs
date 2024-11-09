using MinhasAtividades.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MinhasAtividades
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<User> gitHubUsers = new ObservableCollection<User>();

        public MainPage()
        {
            Title = "Minhas Atividades";
            InitializeComponent();
            lstView.ItemsSource = gitHubUsers;
            GetUsers();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {

            String login = entAtividade.Text;
            User atv = new User(login, "");
            gitHubUsers.Add(atv);

            entAtividade.Text = "";

            await DisplayAlert("Aviso", "Atividade adicionada", "OK");
        }

        private async void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Atividade atvSelecionada = (Atividade)e.SelectedItem;

            /*
            
            atividades.Remove(atvSelecionada);
            await DisplayAlert("Aviso", "Atividade removida", "OK");
            */
            await Navigation.PushAsync(new Detalhes(atvSelecionada));
        }

        private async void GetUsers()
        {
            string url = "https://api.github.com/users";
            var client = new HttpClient();

            using var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            string json = await response.Content.ReadAsStringAsync();

            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            users.ForEach(item => gitHubUsers.Add(item));
        }
    }

}
