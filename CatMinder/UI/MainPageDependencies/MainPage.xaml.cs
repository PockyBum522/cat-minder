namespace CatMinder.UI.MainPageDependencies;

public partial class MainPage : ContentPage
{
    public MainPageViewModel MPViewModel { get; set; }

    public MainPage()
	{
        MPViewModel = new MainPageViewModel();
        
        InitializeComponent();

        BindingContext = MPViewModel;
    }

    public void ClearButton_Clicked(object sender, EventArgs e)
    {
        MPViewModel.IsCheckedLuluGarage = !(MPViewModel.IsCheckedLuluGarage);
    }
}

