using ChinaCentre.iOS;
using ChinaCentre.Views.Layout;
using CoreGraphics;
using Foundation;
using UIKit;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HybridWebView), typeof(HybridWebViewRenderer))]

namespace ChinaCentre.iOS
{
    public class HybridWebViewRenderer : WkWebViewRenderer
    {
        private WKWebView _wkWebView;
        private JSBridge _jsBridge;  

        public HybridWebViewRenderer() : base()
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                _wkWebView.Configuration.UserContentController.RemoveScriptMessageHandler("jsBridge");
                ((HybridWebView)Element).Cleanup();
            }

            if (e.NewElement != null)
            {
                _wkWebView = new WKWebView(Frame, new WKWebViewConfiguration());
                _jsBridge = new JSBridge(this);
                _wkWebView.Configuration.UserContentController.AddScriptMessageHandler(_jsBridge, "jsBridge");
                 
                NSUrl url = new NSUrl("https://smthubakgale.github.io/ChinaCentre?page=home&fill=none");
                _wkWebView.LoadRequest(new NSUrlRequest(url));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ((HybridWebView)Element).Cleanup();
            }
            base.Dispose(disposing);
        }
    }
}