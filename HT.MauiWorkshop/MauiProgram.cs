using HT.MauiWorkshop.Pages;
using HT.MauiWorkshop.ViewModels;
using Microsoft.Extensions.Logging;

namespace HT.MauiWorkshop;

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
			});

		builder.Services.AddSingleton<AddCarPage>();
		builder.Services.AddSingleton<AddCarViewModel>();
		
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

