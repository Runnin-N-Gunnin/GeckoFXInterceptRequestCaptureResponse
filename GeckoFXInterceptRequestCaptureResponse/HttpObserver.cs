using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using Gecko.Net;

namespace GeckoFXInterceptRequestCaptureResponse
{
    public class HttpObserver : nsIObserver
    {
        private nsIObserverService service;

        public HttpObserver()
        {
            service = Xpcom.CreateInstance<nsIObserverService>("@mozilla.org/observer-service;1");
        }

        public void Register()
        {
            service.AddObserver(this, "http-on-examine-response", false);
        }

        public void Unregister()
        {
            service.RemoveObserver(this, "http-on-examine-response");
        }

        public void Observe(nsISupports aSubject, string aTopic, string aData)
        {
            nsIHttpChannel httpChannel = Xpcom.QueryInterface<nsIHttpChannel>(aSubject);
            HttpChannel httpChannel2 = new HttpChannel(httpChannel);

            if (aTopic == "http-on-examine-response")
            {
                var header = httpChannel2.GetResponseHeadersDict();

                Debug.WriteLine("");
                foreach (var h in header)
                {
                    PrintResponseHeader(h.Key, h.Value);
                }
                Debug.WriteLine("");
            }
        }

        private void PrintResponseHeader(string key, List<string> values)
        {
            string headerKey = string.Empty;

            if (values.Count == 1)
            {
                headerKey = values[0];
            }
            else if (values.Count > 1)
            {
                foreach (var val in values)
                {
                    headerKey += $"{val} | ";
                }
            }

            Debug.WriteLine($"[RESPONSE_HEADER]: {key} => {headerKey}");
        }
    }
}
