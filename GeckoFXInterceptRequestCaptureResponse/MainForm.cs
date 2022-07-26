using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using Gecko.Events;

namespace GeckoFXInterceptRequestCaptureResponse
{
    public partial class MainForm : Form
    {
        private GeckoWebBrowser geckoWB;
        private string UA = @"Mozilla/5.0 (Windows NT 10.0; rv:91.0) Gecko/20100101 Firefox/91.0";
        private readonly string referer = string.Empty;

        public MainForm()
        {
            Xpcom.EnableProfileMonitoring = false;
            Xpcom.Initialize(Environment.CurrentDirectory + "\\Firefox64"); // <- Important

            InitializeComponent();
            SetGeckoPreferences();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Register to subscribe to response
            HttpObserver httpObserver = new HttpObserver();
            httpObserver.Register();
            ObserverService.AddObserver(httpObserver, "http-on-examine-response", false);

            geckoWB = new GeckoWebBrowser
            {
                Dock = DockStyle.Fill,
                UseHttpActivityObserver = true
            };

            geckoWB.ConsoleMessage += GeckoWebBrowserOnConsoleMessage;
            geckoWB.DocumentCompleted += GeckoWebBrowserOnDocumentCompleted;
            geckoWB.ObserveHttpModifyRequest += GeckoOnObserveHttpModifyRequest;
            geckoWB.NSSError += GeckoWebBrowserOnError;
            panelWB.Controls.Add(geckoWB);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                geckoWB.Dispose();
                Xpcom.Shutdown();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        // Intercept Request(s)
        private void GeckoOnObserveHttpModifyRequest(object sender, GeckoObserveHttpModifyRequestEventArgs e)
        {
            string requestUrl = e.Channel.Uri.ToString(); // Get Request URL

            bool blockRequest = false; // Test allow/block function here
            if (blockRequest)
            {
                // BLOCK
                Debug.WriteLine($"Block: {requestUrl}");
                e.Cancel = true;
            }
            else
            {
                // ALLOW
                Debug.WriteLine($"Allow: {requestUrl}");
                e.Cancel = false;
            }

            // Example: modify referrer
            // e.Referrer = "";

            // Example: block all javascript scripts
            // if (requestUrl.ToLower().EndsWith(".js")) e.Cancel = true;

            // Request Headers
            var requestHeaders = e.RequestHeaders;

            Debug.WriteLine("");
            foreach (var reqheader in requestHeaders)
            {
                Debug.WriteLine($"[REQUEST_HEADER]: {reqheader.Key} => {reqheader.Value}");
            }
            Debug.WriteLine("");
        }

        private void GeckoWebBrowserOnDocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e)
        {
            txtUrl.Text = e.Uri.ToString();
            // Response should be available at this point, check debug output
        }

        private void GeckoWebBrowserOnConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            Debug.WriteLine($@"[GeckoConsoleMessage]: {e.Message}");
        }

        private void GeckoWebBrowserOnError(object sender, GeckoNSSErrorEventArgs e)
        {
            if (e.Message.Contains("Certificate"))
            {
                CertOverrideService.GetService().RememberValidityOverride(e.Uri, e.Certificate, CertOverride.Mismatch | CertOverride.Time | CertOverride.Untrusted, false);
                if (!e.Uri.AbsoluteUri.Contains(".js") && !e.Uri.AbsoluteUri.Contains(".css")) geckoWB.Navigate(e.Uri.AbsoluteUri);
                e.Handled = true;
            }
            else
            {
                Debug.WriteLine(e.Message);
            }
        }

        // Navigate button
        private void btnNavigate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!geckoWB.IsBusy)
                    geckoWB.Navigate(txtUrl.Text, GeckoLoadFlags.BypassHistory, referer, null);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        // GoBack button
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (geckoWB.CanGoBack)
                geckoWB.GoBack();
        }

        // GoFwd button
        private void btnFwd_Click(object sender, EventArgs e)
        {
            if (geckoWB.CanGoForward)
                geckoWB.GoForward();
        }

        // GeckoFX prefs
        private void SetGeckoPreferences()
        {
            GeckoPreferences.User["beacon.enabled"] = false;
            GeckoPreferences.User["browser.cache.disk.enable"] = false;
            GeckoPreferences.User["browser.cache.memory.enable"] = false;
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = false;
            GeckoPreferences.User["browser.download.manager.showAlertOnComplete"] = false;
            GeckoPreferences.User["browser.send_pings"] = false;
            GeckoPreferences.User["dom.max_script_run_time"] = 10; // ??
            GeckoPreferences.User["general.useragent.override"] = UA;
            GeckoPreferences.User["intl.accept_languages"] = "en-US,en;q=0.5";
            GeckoPreferences.User["media.navigator.enabled"] = false;
            GeckoPreferences.User["media.navigator.permission.disabled"] = true;
            GeckoPreferences.User["media.peerconnection.enabled"] = false;
            GeckoPreferences.User["network.http.referer.spoofSource"] = true;
            GeckoPreferences.User["places.history.enabled"] = false;
            GeckoPreferences.User["plugin.state.flash"] = 0;
            GeckoPreferences.User["plugins.enumerable_names"] = string.Empty;
            GeckoPreferences.User["privacy.popups.showBrowserMessage"] = false;
            GeckoPreferences.User["privacy.firstparty.isolate"] = true;
            GeckoPreferences.User["privacy.trackingprotection.enabled"] = true;
            GeckoPreferences.User["privacy.resistFingerprinting"] = true;
            GeckoPreferences.User["security.warn_viewing_mixed"] = false;
            GeckoPreferences.User["security.ssl.errorReporting.url"] = "";
            GeckoPreferences.User["toolkit.telemetry.enabled"] = false;
            GeckoPreferences.User["toolkit.telemetry.server"] = "";
        }
    }
}
