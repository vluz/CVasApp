namespace CVasApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("Profile", typeof(Profile));
        Routing.RegisterRoute("Exp", typeof(Exp));
        Routing.RegisterRoute("Education", typeof(Education));
        Routing.RegisterRoute("Cert", typeof(Cert));
        Routing.RegisterRoute("Skills", typeof(Skills));
        Routing.RegisterRoute("Other", typeof(Other));
        Routing.RegisterRoute("Options", typeof(Options));
    }
}

