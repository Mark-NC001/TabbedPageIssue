namespace MauiTestApp;

public class StartPage : ContentPage
{
	public StartPage()
	{

		Button tabbedPageButton = new Button();
		tabbedPageButton.Text = "Open Tabbed Page";
		tabbedPageButton.Clicked += TabbedPageButton_Clicked;

		Content = new VerticalStackLayout
		{
			Children = { tabbedPageButton
				
				}
		};
	}

	private async void TabbedPageButton_Clicked(object? sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new NavigationPage(new MyTabbedPage()));
	}
}