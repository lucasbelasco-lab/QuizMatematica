namespace QuizMatematica;

public partial class QuintaQpage : ContentPage
{
    public QuintaQpage()
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
            await DisplayAlert("Correto!", "125 + 75 = 200. Você ganhou 10 pontos!", "Continuar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é C) 200.", "Continuar");
        }

        await Navigation.PushAsync(new SextaQpage());
    }
}