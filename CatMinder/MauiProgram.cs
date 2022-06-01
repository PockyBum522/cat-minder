using CatMinder.Core.Logic;
using CatMinder.UI.MainPageDependencies;
using Microsoft.Maui.LifecycleEvents;

namespace CatMinder;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .Services
            .AddSingleton<MainPageViewModel>()
            .AddSingleton<MainPage>()
            .AddSingleton<MainPageViewModelStateSaver>();

		return builder.Build();
	}
}
