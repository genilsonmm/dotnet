using AppGitHub.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGitHub
{
    public partial class MainPage : ContentPage
    {
        //private ObservableCollection<Atividade> atividades = new ObservableCollection<Atividade>();
        private ObservableCollection<User> obUsers = new ObservableCollection<User>();
        
        public MainPage()
        {
            InitializeComponent();

            Title = "Usuários do Git";

            lstAtividede.ItemsSource = obUsers;
            GetData();
        }

        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            string titulo = entAtividade.Text;

            entAtividade.Text = "";
            //atividades.Add(new Atividade(titulo));

            await Navigation.PushAsync(new OutraPagina(titulo));
        }

        private void GetData()
        {
            var client = new HttpClient();
            var uri = "https://api.github.com/users"; //http://10.0.2.2:<port>/<endpoint>

            Task<string> task = client.GetStringAsync(uri);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(task.Result);

            users.ForEach(item => obUsers.Add(item));
        }

        private void lstAtividede_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User userSelecionado = (User)e.SelectedItem;
            DisplayAlert("Usuário", userSelecionado.Login, "Ok");
        }
    }
}
