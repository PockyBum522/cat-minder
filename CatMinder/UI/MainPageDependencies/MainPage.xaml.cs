namespace CatMinder.UI.MainPageDependencies;

public partial class MainPage : ContentPage
{
    private MainPageViewModel _viewModel = new ();

    public MainPage()
	{
        BindingContext = _viewModel;

        InitializeComponent();
    }

    public void ClearButton_Clicked(object sender, EventArgs e)
    {
        // Drops
        _viewModel.IsCheckedJakeMorning = false;
        _viewModel.IsCheckedJakeNight = false;

        // Feed
        _viewModel.IsCheckedFoodMorning = false;
        _viewModel.IsCheckedFoodNoon = false;
        _viewModel.IsCheckedFoodNight = false;
    }
}

