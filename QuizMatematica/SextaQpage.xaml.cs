namespace QuizMatematica;

public partial class SextaQpage : ContentPage
{
    public SextaQpage()
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
            await DisplayAlert("Correto!", "100 - 47 = 53. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é C) 53.", "Continuar");
        }

        await Navigation.PushAsync(new SetimaQpage());
    }
}