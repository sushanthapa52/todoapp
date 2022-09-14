using Todo.ViewModel;

namespace Todo;

public partial class DeadlinePage : ContentPage
{
	public DeadlinePage(DeadlineViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}