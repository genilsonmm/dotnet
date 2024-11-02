using MinhasAtividades.Model;
using System.Collections.ObjectModel;

namespace MinhasAtividades
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Atividade> atividades = new ObservableCollection<Atividade>();

        public MainPage()
        {
            Title = "Minhas Atividades";
            InitializeComponent();
            lstView.ItemsSource = atividades;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", "Alguma coisa", "OK");
            String atividade = entAtividade.Text;
            Atividade atv = new Atividade() {  Descricao = atividade };
            atividades.Add(atv);

            entAtividade.Text = "";
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Atividade atvSelecionada = (Atividade)e.SelectedItem;
            atividades.Remove(atvSelecionada);
        }
    }

}
