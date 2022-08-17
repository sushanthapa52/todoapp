using Todo.ViewModel;

namespace Todo;

public partial class DetailPage : ContentPage
{

	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

        // just adding one buttom to see another method of navigating to the next page
        //Button button = new Button
        //{
        //    Text = "Navigate!",
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.Center
        //};

        //button.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new HelloXamlPage());
        //};

        //Content = button;
    }
}