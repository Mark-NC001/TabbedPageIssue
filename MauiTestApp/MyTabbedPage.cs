namespace MauiTestApp;

public class MyTabbedPage : TabbedPage
{
	public MyTabbedPage()
	{

		ContentPage page1 = new ContentPage();
		page1.Title = "Page 1";

		ContentPage page2 = new ContentPage();
		page2.Title = "Page 2";

		this.Children.Add(page1);
		this.Children.Add(page2);

		ToolbarItems.Add(new ToolbarItem("Back", null, async () =>
		{
			await Navigation.PopModalAsync(true);
		}));
	}
}
