namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void GenerateLuckyNumbers(object Sender, EventArgs e)
	{
        AppName.IsVisible = false;
		LuckNumbersContainers.IsVisible = true;

		var numbers = Generate6RandomNumbers();

		LuckNumber01.Text = numbers.ElementAt(0).ToString("00");
		LuckNumber02.Text = numbers.ElementAt(1).ToString("00");
		LuckNumber03.Text = numbers.ElementAt(2).ToString("00");
		LuckNumber04.Text = numbers.ElementAt(3).ToString("00");
		LuckNumber05.Text = numbers.ElementAt(4).ToString("00");
		LuckNumber06.Text = numbers.ElementAt(5).ToString("00");
	}

	private SortedSet<int> Generate6RandomNumbers()
	{
		var set = new SortedSet<int>();
		while (set.Count < 6)
		{
            var random = new Random();
            set.Add(random.Next(1, 60));
        }

		return set;
	}	
}