using AppGitHub.Model;
using AppGitHub.Service;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace AppGitHub;

public partial class GitHubUsersPage : ContentPage
{
    ObservableCollection<User> usersObs = new ObservableCollection<User>();
    private readonly string url = "https://api.github.com/users";

    public GitHubUsersPage(string title)
	{
		InitializeComponent();
        lstUsers.ItemsSource = usersObs;

        GetUsers();
        Title = title;
	}

    public async Task GetUsers()
    {
        try
        {
            var httpClient = new HttpClient();

            using var httpResponse = await httpClient.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("Algo deu errado!");

            string json = await httpResponse.Content.ReadAsStringAsync();

            List<User> userResult = JsonConvert.DeserializeObject<List<User>>(json);
            userResult.ForEach(user => { usersObs.Add(user); });
        } catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
    }

    private async void lstUsers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        User user = e.SelectedItem as User;

        await DisplayAlert("Usuário", $"Usuário selecionado foi {user.Login}", "Ok");
    }

    /*
    private async void GetUsers()
    {
        GitHubService gitHubService = new GitHubService();
        Task<List<User>> users = gitHubService.GetUsers();

        try
        {
            List<User> usersResult = users.Result;
        }
        catch (Exception ex)
        { 
        
        }
        //users.Result.ForEach(user => { usersObs.Add(user); });

        /*
		foreach (User user in users.Result)
		{
			usersObs.Add(user);
		}
		*/
    //}

}