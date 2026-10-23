namespace QuizMatematica;

public partial class QuartaQpage : ContentPage
{
    public QuartaQpage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        lblPontuacao.Text = $"Pontuação: {ScoreStore.Points}";
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!RespostaA.IsChecked && !RespostaB.IsChecked &&
            !RespostaC.IsChecked && !RespostaD.IsChecked)
        {
            await DisplayAlert("Atenção", "Escolha uma alternativa.", "OK");
            return;
        }

        if (RespostaB.IsChecked)
        {
            ScoreStore.Add(10);
            await DisplayAlert("Correto!", "36 ÷ 6 = 6. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é B) 6.", "Continuar");
        }

        await Navigation.PushAsync(new QuintaQpage());
    }
}