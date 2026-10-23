namespace QuizMatematica;

public partial class TerceiraQpage : ContentPage
{
    public TerceiraQpage()
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

        if (RespostaA.IsChecked)
        {
            ScoreStore.Add(10);
            await DisplayAlert("Correto!", "6 × 4 = 24. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é A) 24.", "Continuar");
        }

        await Navigation.PushAsync(new QuartaQpage());
    }
}