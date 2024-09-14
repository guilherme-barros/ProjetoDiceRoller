namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void RolarDados_Clicked(object sender, EventArgs e)
    {
        int quantidadeDado = 0;
        int numeroSorteado = 0;
        int soma = 0;
        int numeroSelecionado = Convert.ToInt32(Picker.SelectedItem.ToString());
        int modificador = Convert.ToInt32(Picker2.SelectedItem.ToString());
        quantidadeDado = Convert.ToInt32(Quantidade.Text);


        for (int i = 0; i < quantidadeDado; i++)
        {
            numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
            soma += numeroSorteado + modificador;

            Teste.Text += " " + numeroSorteado.ToString();
        }


        ContadorLabel.Text = "Soma " + soma.ToString();
    }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

