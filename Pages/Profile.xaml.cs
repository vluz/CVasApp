namespace CVasApp;

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();

        var textparts0 = "I have over twenty years experience providing coding, systems, storage, backup and data protection services.            "
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

        var textparts1 = "I am well experienced on high-end and mid-range solutions with time proven skills, ranging from customer solution architecture and design to ‘hands on’ implementation and coding. At the operations level I am ITIL certified, familiar with operating systems, virtualization of hosts and storage, disaster recovery planning and operation, performance, capacity planning and have well tuned, strong troubleshooting skills."
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

        var textparts2 = "I have provided Premium Level 24x7 support at the storage, fabric switching and routing, hosts and applications including customer assistance in general troubleshooting, disaster recovery, tailored solution design and architecture adaptation and modification.                              "
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

        var textparts3 = "Implementation skills range from several flavours of UNIX to Windows and virtual environments, including business applications, databases and information systems monitoring, metering and management solutions including a large range of systems, storage, backup and fabric switching and routing hardware.    "
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

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }
}