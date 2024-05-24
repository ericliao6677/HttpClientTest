using HttpClientTest.Service;
using Microsoft.Net.Http.Headers;

namespace HttpClientTest.DependecyInjection
{
    public static class DependencyInjection
    {
        public static void AddHttpClientConfiger(this IServiceCollection services)
        {
            services.AddHttpClient("Events", httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://www.travel.taipei/open-api/zh-tw/Events/");
                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.Accept, "application/json");
                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.UserAgent, "HttpRequestsSample");
            });

            services.AddHttpClient<TrevalInfoTypedclientsService>();
        }
    }
}
