namespace CVasApp;

/// <summary>
/// Profile Page code behind
/// </summary>

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();

        // Split hack for text justification
        // (todo) find better solution
        var textparts0 = "Mais de 26 anos de experi�ncia em servi�os profissionais de software, sistemas, armazenamento, SAN, backup, prote��o de dados, recupera��o ap�s desastre, desenho de solu��es, arquitetura de sistemas, e mais recentemente, ML do ponto de vista pratico."
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x0 => new Label
                {
                    Text = x0,
                    Margin = new Thickness(.7, 0),
                    FontSize = 18,
                    FontFamily = "FontCHLight",
                });
        foreach (var textpart0 in textparts0)
            TextContainer0.Children.Add(textpart0);

        var textparts1 = "Desenvolvi conhecimentos especializados em solu��es de escala pan-europeia, alta, m�dia e pequena. Na maior parte, sistemas especializados e construidos � medida. As minhas compet�ncias abrangem transforma��o, arquitetura, conce��o, implementa��o, opera��o, suporte e forma��o."
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x1 => new Label
                {
                    Text = x1,
                    Margin = new Thickness(.7, 0),
                    FontSize = 18,
                    FontFamily = "FontCHLight",
                });
        foreach (var textpart1 in textparts1)
            TextContainer1.Children.Add(textpart1);

        var textparts2 = "Tenho certifica��o ITIL, conhecimentos de sistemas operativos, virtualiza��o, armazenamento, processos, planeamento, recupera��o ap�s desastre, desempenho, gest�o de capacidade, gest�o de projetos."
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x2 => new Label
                {
                    Text = x2,
                    Margin = new Thickness(.7, 0),
                    FontSize = 18,
                    FontFamily = "FontCHLight",
                });
        foreach (var textpart2 in textparts2)
            TextContainer2.Children.Add(textpart2);

        var textparts3 = "As minhas fortes capacidades de resolu��o de problemas, o meu esp�rito anal�tico e a minha vasta experi�ncia fazem de mim uma mais-valia em qualquer ambiente de TI. Entusiasta de solu��es de c�digo aberto, automa��o de servi�o, ML/IA e Python.      "
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x3 => new Label
                {
                    Text = x3,
                    Margin = new Thickness(.7, 0),
                    FontSize = 18,
                    FontFamily = "FontCHLight",
                });
        foreach (var textpart3 in textparts3)
            TextContainer3.Children.Add(textpart3);

    }


    /// <summary>
    /// Go back one page
    /// </summary>
    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }
}