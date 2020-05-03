using System;

namespace PackAnUmbrella
{
    public class PackAnUmbrealla
    {
        public void Run()
        {
            // 날씨 API와 연결하고 데이터 받아오기
            var weather = new WeatherGetter().Get(); 
            // 비 or 눈이 오는지 확인
            // 날씨 기반으로 라인 알림
        }
    }
}