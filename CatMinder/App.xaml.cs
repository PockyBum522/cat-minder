using CatMinder.Core.Logic;
using CatMinder.UI.MainPageDependencies;

namespace CatMinder;

public partial class App : Application
{
    private readonly MainPageViewModelStateSaver _mainPageViewModelStateSaver;

    public App(MainPageViewModelStateSaver mainPageViewModelStateSaver)
	{
        _mainPageViewModelStateSaver = mainPageViewModelStateSaver;
        InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = base.CreateWindow(activationState);
        
        window.Created += (s, e) =>
        {
            _mainPageViewModelStateSaver.LoadMainViewModelState();
        };

        window.Deactivated += (s, e) =>
        {
            _mainPageViewModelStateSaver.SaveMainViewModelState();
        };

        return window;
    }
}
