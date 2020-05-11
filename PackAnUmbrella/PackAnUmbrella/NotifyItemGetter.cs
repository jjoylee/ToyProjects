using System.Linq;

namespace PackAnUmbrella
{
    public class NotifyItemGetter
    {
        public NotifyItem Get(string weather)
        {
            return new NotifyItem() { Weather = weather, Message = GetMessage(weather)};
        }

        private string GetMessage(string weather)
        {
            if (NeedUmbrella(weather)) return "우산이 필요한 날씨에요. 오늘은 꼭 우산을 챙기세요";
            return "오늘은 우산을 챙기지 않아도 괜찮아요";
        }   

        private bool NeedUmbrella(string weather)
        {
            var requireUmbrellaWeathers = new string[] { "Thunderstorm", "Drizzle", "Rain", "Snow"};
            return requireUmbrellaWeathers.Contains(weather);
        }
    }
}