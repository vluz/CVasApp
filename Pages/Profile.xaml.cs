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
        var textparts0 = "Mais de 26 anos de experiência em serviços profissionais de software, sistemas, armazenamento, SAN, backup, proteção de dados, recuperação após desastre, desenho de soluções, arquitetura de sistemas, e mais recentemente, ML do ponto de vista pratico."
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

        var textparts1 = "Desenvolvi conhecimentos especializados em soluções de escala pan-europeia, alta, média e pequena. Na maior parte, sistemas especializados e construidos à medida. As minhas competências abrangem transformação, arquitetura, conceção, implementação, operação, suporte e formação."
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

        var textparts2 = "Tenho certificação ITIL, conhecimentos de sistemas operativos, virtualização, armazenamento, processos, planeamento, recuperação após desastre, desempenho, gestão de capacidade, gestão de projetos."
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

        var textparts3 = "As minhas fortes capacidades de resolução de problemas, o meu espírito analítico e a minha vasta experiência fazem de mim uma mais-valia em qualquer ambiente de TI. Entusiasta de soluções de código aberto, automação de serviço, ML/IA e Python.      "
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