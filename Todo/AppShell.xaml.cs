namespace Todo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        Routing.RegisterRoute(nameof(MoreDetailsPage), typeof(MoreDetailsPage));
		Routing.RegisterRoute(nameof(DeadlinePage), typeof(DeadlinePage));

    }
}
