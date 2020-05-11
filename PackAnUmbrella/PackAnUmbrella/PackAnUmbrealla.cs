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
            // 날씨에 따라 NotifyItem 가져오기 (메세지)
            var notifyItem = new NotifyItemGetter().Get(weather);
            // LineNotify 알림
            new LineNotifyGetter().SendNotify(notifyItem);
        }
    }
}