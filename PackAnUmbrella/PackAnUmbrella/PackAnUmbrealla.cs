using System;
using System.Linq;

namespace PackAnUmbrella
{
    public class PackAnUmbrealla
    {
        public void Run()
        {
            // 날씨 API와 연결하고 데이터 받아오기
            var weather = new WeatherGetter().Get();
            // 우산이 필요한 날씨인지 확인
            if (NeedUmbrella(weather)) new LineNotifyGetter().SendNotify();
        }

        private bool NeedUmbrella(string weather)
        {
            var requireUmbrellaWeathers = new string[] { "Thunderstorm", "Drizzle", "Rain", "Snow" };
            return requireUmbrellaWeathers.Contains(weather);
        }
    }
}