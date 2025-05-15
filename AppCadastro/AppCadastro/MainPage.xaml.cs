using AppCadastro.Model;
using System.Collections.ObjectModel;

namespace AppCadastro
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<Usuario> usuarios = 
            new ObservableCollection<Usuario>();

        public MainPage()
        {
            usuarios.Add(new Usuario() { Id = Guid.NewGuid(), Nome = "Maria da Silva" });
            
            InitializeComponent();
            lstUsuarios.ItemsSource = usuarios;
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            usuarios.Add(new Usuario() { Id = Guid.NewGuid(), Nome = nome });
            txtNome.Text = "";
        }

        private async void lstUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Usuario usuario = (Usuario)e.SelectedItem;
            //await DisplayAlert("Usuário", usuario.Nome, "Ok");
            await Navigation.PushAsync(new Detalhes(usuario));
        }
    }
}
