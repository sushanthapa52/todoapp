using Todo.ViewModel;

namespace Todo;

public partial class MoreDetailsPage : ContentPage
{
	public MoreDetailsPage(MoreDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}