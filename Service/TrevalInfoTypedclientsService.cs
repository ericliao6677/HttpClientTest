using HttpClientTest.Domain.Dtos.Response;
using HttpClientTest.Domain.Entity.Media;
using Microsoft.Net.Http.Headers;
using System.Net;

namespace HttpClientTest.Service
{
    public class TrevalInfoTypedclientsService
    {
        private readonly HttpClient _httpClient;
        public TrevalInfoTypedclientsService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://www.travel.taipei/open-api/zh-tw/Media/");

            // using Microsoft.Net.Http.Headers;
            // The GitHub API requires two headers.
            _httpClient.DefaultRequestHeaders.Add(
                HeaderNames.Accept, "application/json");
            _httpClient.DefaultRequestHeaders.Add(
                HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public async Task<ResultResponse> GetPanosAsync()
        {
            var httpResponseMessage = await _httpClient.GetFromJsonAsync<Panos>("Panos?page=1");
            if (httpResponseMessage is not null)
                return ResultResponseExtension.Query.QuerySuccess(httpResponseMessage);
            return ResultResponseExtension.Query.QueryNotFound(HttpStatusCode.NotFound);
        }

        public async Task<ResultResponse> GetAudioAsync()
        {
            var httpResponseMessage = await _httpClient.GetFromJsonAsync<Audio>("Audio?page=1");
            if (httpResponseMessage is not null)
                return ResultResponseExtension.Query.QuerySuccess(httpResponseMessage);
            return ResultResponseExtension.Query.QueryNotFound(HttpStatusCode.NotFound);
        }
    }
}
