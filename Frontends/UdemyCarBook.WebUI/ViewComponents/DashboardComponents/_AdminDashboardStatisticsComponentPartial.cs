using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region İstatistik1
            var responseMessage = await client.GetAsync("https://localhost:7008/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int v1 = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultResponse<ResultStatisticsDto>>(jsonData);
                ViewBag.v = values.result.carCount;
                ViewBag.v1 = v1;
            }
            #endregion

            #region İstatistik2
            var responseMessage2 = await client.GetAsync("https://localhost:7008/api/Statistics/GetLocationCount");

            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultResponse<ResultStatisticsDto>>(jsonData2);
                ViewBag.locationCount = values2.result.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }
            #endregion

            #region İstatistik3
            var responseMessage3 = await client.GetAsync("https://localhost:7008/api/Statistics/GetBrandCount");

            if (responseMessage3.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultResponse<ResultStatisticsDto>>(jsonData3);
                ViewBag.brandCount = values3.result.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion

            #region İstatistik4
            var responseMessage4 = await client.GetAsync("https://localhost:7008/api/Statistics/GetAvgRentPriceForDaily");

            if (responseMessage4.IsSuccessStatusCode)
            {
                int avgPriceForDailyRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultResponse<ResultStatisticsDto>>(jsonData4);
                ViewBag.avgPriceForDaily = values4.result.avgPriceForDaily.ToString("0");
                ViewBag.avgPriceForDailyRandom = avgPriceForDailyRandom;
            }
            #endregion

       
            return View();
        }
    }
}
