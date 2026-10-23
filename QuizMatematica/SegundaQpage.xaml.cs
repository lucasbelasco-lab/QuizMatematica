namespace QuizMatematica;

public partial class SegundaQpage : ContentPage
{
    public SegundaQpage()
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

        if (RespostaC.IsChecked)
        {
            ScoreStore.Add(10);
            await DisplayAlert("Correto!", "30 - 12 = 18. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é C) 18.", "Continuar");
        }

        await Navigation.PushAsync(new TerceiraQpage());
    }
}