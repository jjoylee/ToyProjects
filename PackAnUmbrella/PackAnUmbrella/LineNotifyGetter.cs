using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace PackAnUmbrella
{
    public class LineNotifyGetter
    {
        public void SendNotify(NotifyItem notifyItem)
        {
            // CAmxX8MR0PRwqSFKs1TiUdGcTGjW9yHZmG15j8qEvhm
            try
            {
                Encoding.UTF8.GetString(Upload(notifyItem));
            }
            catch (Exception e) { }
        }

        private byte[] Upload(NotifyItem notifyItem)
        {
            WebClient wc = new WebClient();
            wc.Headers["Authorization"] = "Bearer CAmxX8MR0PRwqSFKs1TiUdGcTGjW9yHZmG15j8qEvhm";
            return wc.UploadValues("https://notify-api.line.me/api/notify", GetNameValueCollection(notifyItem));
        }

        private NameValueCollection GetNameValueCollection(NotifyItem notifyItem)
        {
            var nc = new NameValueCollection();
            nc["message"] = notifyItem.Message;
            return nc;
        }
    }
}