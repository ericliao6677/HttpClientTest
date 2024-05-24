using HttpClientTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace HttpClientTest.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class TravelInfoController : ControllerBase
    {
        private readonly TravelInfoService _travelInfoService;
        private readonly TrevalInfoTypedclientsService _trevalInfoTypedclientsService;


        public TravelInfoController(
            TravelInfoService getTravelDestinationService
            , TrevalInfoTypedclientsService trevalInfoTypedclientsService) 
        {
            _travelInfoService = getTravelDestinationService;
            _trevalInfoTypedclientsService = trevalInfoTypedclientsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDestinations()
        {
            var result = await _travelInfoService.GetDataAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEventsNews()
        {
            var result = await _travelInfoService.GetEventsNewsAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEventsActivity()
        {
            var result = await _travelInfoService.GetEventsActivityAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEventsCalendar()
        {
            var result = await _travelInfoService.GetEventsCalendarAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetMediaPanos()
        {
            var result = await _trevalInfoTypedclientsService.GetPanosAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetMediaAudio()
        {
            var result = await _trevalInfoTypedclientsService.GetAudioAsync();
            return Ok(result);
        }
    }
}
