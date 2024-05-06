using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class CoolPage : ContentPage
{
	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
	}
	public CoolPage()
	{
		InitializeComponent();
	}
	protected override bool OnBackButtonPressed()
	{
		return true;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}