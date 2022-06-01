namespace CatMinder.UI.MainPageDependencies;

public partial class MainPage : ContentPage
{
    public MainPageViewModel MainPageViewModel { get; set; }

    public MainPage(MainPageViewModel mainPageViewModel)
    {
        MainPageViewModel = mainPageViewModel;
        BindingContext = MainPageViewModel;

        InitializeComponent();
    }

    public void ClearButton_Clicked(object sender, EventArgs e)
    {
        MainPageViewModel.IsCheckedJakeMorning = false;
        MainPageViewModel.IsCheckedJakeNight = false;
        
        MainPageViewModel.IsCheckedFoodMorning = false;
        MainPageViewModel.IsCheckedFoodNoon = false;
        MainPageViewModel.IsCheckedFoodNight = false;
    }
}

