using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace PackAnUmbrella
{
    public class LineNotifyGetter
    {
        public void SendNotify()
        {
            // CAmxX8MR0PRwqSFKs1TiUdGcTGjW9yHZmG15j8qEvhm
            try
            {
                Encoding.UTF8.GetString(Upload());
            }
            catch (Exception e) { }
        }

        private byte[] Upload()
        {
            WebClient wc = new WebClient();
            wc.Headers["Authorization"] = "Bearer CAmxX8MR0PRwqSFKs1TiUdGcTGjW9yHZmG15j8qEvhm";
            return wc.UploadValues("https://notify-api.line.me/api/notify", GetNameValueCollection());
        }

        private NameValueCollection GetNameValueCollection()
        {
            var nc = new NameValueCollection();
            nc["message"] = "PackAnUmbrellaNotify테스트";
            return nc;
        }
    }
}