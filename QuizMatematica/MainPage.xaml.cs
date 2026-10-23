namespace QuizMatematica;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        ScoreStore.Reset();
        await Navigation.PushAsync(new PrimeiraQpage());
    }
}