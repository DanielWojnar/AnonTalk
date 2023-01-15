using AnonTalk.Services;

namespace AnonTalk;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		
		builder.Services.AddSingleton<IHttpClientService, HttpClientService>();
		builder.Services.AddTransient<IBoardService, BoardService>();
		builder.Services.AddTransient<IPostService, PostService>();
		builder.Services.AddTransient<ICommentService, CommentService>();
        builder.Services.AddAutoMapper(typeof(MauiProgram).Assembly);

        return builder.Build();
	}
}
