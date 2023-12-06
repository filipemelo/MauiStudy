namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

        //App.Current.MainPage = SetPage(new Page1());
    }

    private void OnButtonClickedPage1(object sender, EventArgs e)
    {
        //SetPage(new Page1());
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page1());
    }

    private void OnButtonClickedPage2(object sender, EventArgs e)
    {
        //SetPage(new Page2());
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page2());// new NavigationPage(new Page2());
    }

    private void OnButtonClickedPage3(object sender, EventArgs e)
    {
        //   SetPage(new Page3());
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page3());
    }

    private static void SetPage(Page page)
    {
        if (Application.Current?.MainPage is FlyoutPage flyoutPage)
            flyoutPage.Detail = new NavigationPage(page);
    }
}