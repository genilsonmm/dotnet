using AppGitHub.Model;
using System.Collections.ObjectModel;

namespace AppGitHub
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Aluno> alunos = new ObservableCollection<Aluno>(); 

        public MainPage()
        {
            InitializeComponent();
            lstAlunos.ItemsSource = alunos;
            Title = "Início";
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            string nome = entName.Text;

            if (nome.Equals(""))
            {
                await DisplayAlert("Aviso", "Digite o nome do aluno", "Ok");
            }
            else
            {
                alunos.Add(new Aluno() { Id = alunos.Count+1, Nome = nome });
                entName.Text = "";
            }
        }

        private async void btnGoToPage_Clicked(object sender, EventArgs e)
        {
            string title = "Listagem de usuários";
            await Navigation.PushAsync(new GitHubUsersPage(title));
        }
    }
}
