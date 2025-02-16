using ChinaCentre.Views.Layout;
using Foundation;
using System;
using UIKit;
using WebKit;
using Xamarin.Forms;

namespace ChinaCentre.iOS
{
    public class JSBridge : NSObject, IWKScriptMessageHandler
    {
        // Variables
        private readonly WeakReference<HybridWebViewRenderer> hybridWebViewRenderer;

        // Constructor
        public JSBridge(HybridWebViewRenderer hybridRenderer)
        {
            hybridWebViewRenderer = new WeakReference<HybridWebViewRenderer>(hybridRenderer);
        }

        // Methods
        [Export("invokePost:method:")]
        public string InvokePost(string data, string method)
        {
            HybridWebViewRenderer hybridRenderer;
            if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
            {
                return (string)((HybridWebView)hybridRenderer.Element).InvokePost(data, method);
            }
            else { return null; }
        }

        [Export("invokeGet:method:")]
        public string InvokeGet(string data, string method)
        {
            HybridWebViewRenderer hybridRenderer;
            try
            {
                if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
                {
                    return (string)((HybridWebView)hybridRenderer.Element).InvokeGet(data, method);
                }
                else { return null; }

            }
            catch { return null; }
        }

        [Export("invokeAlert:method:")]
        public void InvokeAlert(string data, string method)
        {
            HybridWebViewRenderer hybridRenderer;
            if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
            {
                ((HybridWebView)hybridRenderer.Element).InvokeAlert(data, method);
            }
        }

        // IWKScriptMessageHandler implementation
        public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
        {
            // Handle script messages here
        }
    }
}