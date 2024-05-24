using HttpClientTest.Domain.Dtos.Response;
using HttpClientTest.Domain.Entity;
using HttpClientTest.Domain.Entity.Event;
using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace HttpClientTest.Service
{

    public class TravelInfoService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TravelInfoService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public TravelDestinationEntity? TravelDestinationData { get; set; }
        public Activity? Activity { get; set; }
        public News? News { get; set; }

        public Calendar? Calendar { get; set; }


        public async Task<ResultResponse> GetDataAsync()
        {
            var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
           "https://www.travel.taipei/open-api/zh-tw/Attractions/All?page=1")
            {
                Headers =
                {
                    { HeaderNames.Accept, "application/json" }                  
                }
            };

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                TravelDestinationData = await JsonSerializer.DeserializeAsync<TravelDestinationEntity>(contentStream);
                return ResultResponseExtension.Query.QuerySuccess(TravelDestinationData);
            }
            return ResultResponseExtension.Query.QueryNotFound(httpResponseMessage.StatusCode);
        }

        public async Task<ResultResponse> GetEventsActivityAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("Events");
            var httpResponseMessage = await httpClient.GetAsync("Activity?page=1");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                Activity = await JsonSerializer.DeserializeAsync<Activity>(contentStream);
                return ResultResponseExtension.Query.QuerySuccess(Activity);
            }
            return ResultResponseExtension.Query.QueryNotFound(httpResponseMessage.StatusCode);

        }

        public async Task<ResultResponse> GetEventsNewsAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("Events");
            var httpResponseMessage = await httpClient.GetAsync("News?page=1");
            if (httpResponseMessage.IsSuccessStatusCode) 
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                News = await JsonSerializer.DeserializeAsync<News>(contentStream);
                return ResultResponseExtension.Query.QuerySuccess(News);
            }
            return ResultResponseExtension.Query.QueryNotFound(httpResponseMessage.StatusCode);
        }

        public async Task<ResultResponse> GetEventsCalendarAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("Events");
            var httpResponseMessage = await httpClient.GetAsync("Calendar?page=1");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                Calendar = await JsonSerializer.DeserializeAsync<Calendar>(contentStream);
                return ResultResponseExtension.Query.QuerySuccess(Calendar);
            }
            return ResultResponseExtension.Query.QueryNotFound(httpResponseMessage.StatusCode);
        }
    }
}
