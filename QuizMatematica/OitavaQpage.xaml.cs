namespace QuizMatematica;

public partial class OitavaQpage : ContentPage
{
    public OitavaQpage()
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
            await DisplayAlert("Correto!", "81 ÷ 9 = 9. Você ganhou 10 pontos!", "Finalizar");
        }
        else
        {
            await DisplayAlert("Incorreto!", "A resposta correta é C) 9.", "Finalizar");
        }

        await DisplayAlert(
            "Quiz finalizado",
            $"Você terminou as 8 perguntas!\nSua pontuação final foi: {ScoreStore.Points} de 80 pontos.",
            "Voltar ao início");

        await Navigation.PopToRootAsync();
    }
}