using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using static Microsoft.Maui.Controls.LayoutOptions;

namespace Bug_GridLayout;

public class NewPage1 : ContentPage
{
	public NewPage1()
	{
		Content = new Grid
		{
			ColumnDefinitions = Columns.Define(Auto, Star, Auto),
			RowDefinitions = Rows.Define(Auto, Star, Auto),
			Padding = new Thickness(10),

			Children = {
				new Label { Text = "Pick image: ", Margin=20, VerticalOptions=Center, BackgroundColor=Colors.Red },
				new Entry { IsReadOnly = true, Margin=20 }.Column(1),
				new Button { Text = "Pick...", Margin=20 }.Column(2),

				new Image { Source="dotnet_bot.png" }.Row(1).ColumnSpan(3),

				new HorizontalStackLayout
				{
					HorizontalOptions = Center,
					Children = { new Button { Text = "OK", Margin = 20 }, new Button { Text="Cancel", Margin = 20 } }
				}.Row(2).ColumnSpan(3)
			}
		};
	}
}