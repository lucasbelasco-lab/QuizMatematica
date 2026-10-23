namespace QuizMatematica;

public partial class PrimeiraQpage : ContentPage
{
    public PrimeiraQpage()
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
            await DisplayAlert("Correto!", "15 + 7 = 22. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é B) 22.", "Continuar");
        }

        await Navigation.PushAsync(new SegundaQpage());
    }
}