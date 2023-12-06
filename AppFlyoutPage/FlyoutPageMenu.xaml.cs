namespace AppFlyoutPage;

public partial class FlyoutPageMenu : FlyoutPage
{
	public FlyoutPageMenu()
	{
		InitializeComponent();
		
		Flyout = new Menu();
		Detail = new NavigationPage(new Page1());
	}
}