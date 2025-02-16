 
using Android.Webkit; 
using ChinaCentre.Views.Layout;
using Java.Interop;
using System; 

namespace ChinaCentre.Droid
{
    public class JSBridge : Java.Lang.Object
    {
        // Variables
        readonly WeakReference<HybridWebViewRenderer> hybridWebViewRenderer;
        // Constructor
        public JSBridge(HybridWebViewRenderer hybridRenderer)
        {
            hybridWebViewRenderer = new
           WeakReference<HybridWebViewRenderer>(hybridRenderer);
        }
        // Methods 
        [JavascriptInterface]
        [Export("invokePost")]
        public string InvokePost(string data , string method)
        {
            HybridWebViewRenderer hybridRenderer;
            if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
            { 
                return (string)((HybridWebView)hybridRenderer.Element).InvokePost(data, method);
            }
            else { return null; }
        }

        [JavascriptInterface]
        [Export("invokeGet")]
        public string InvokeGet(string data , string method)
        {
            HybridWebViewRenderer hybridRenderer;
            try
            {
                if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
                {
                    return (string)((HybridWebView)hybridRenderer.Element).InvokeGet(data, method);
                }
                else { return null; }

            } catch { return null; }
        }  
        [JavascriptInterface]
        [Export("invokeAlert")]
        public void InvokeAlert(string data , string method)
        { 
            HybridWebViewRenderer hybridRenderer;
            if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
            { 
                ((HybridWebView)hybridRenderer.Element).InvokeAlert(data , method);
            } 
        }
        // 
    } 
}