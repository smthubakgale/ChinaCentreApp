package crc64094dd5a32845fa79;


public class JSBridge
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InvokePost:(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;:__export__\n" +
			"n_InvokeGet:(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;:__export__\n" +
			"n_InvokeAlert:(Ljava/lang/String;Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("ChinaCentre.Droid.JSBridge, ChinaCentre.Android", JSBridge.class, __md_methods);
	}


	public JSBridge ()
	{
		super ();
		if (getClass () == JSBridge.class)
			mono.android.TypeManager.Activate ("ChinaCentre.Droid.JSBridge, ChinaCentre.Android", "", this, new java.lang.Object[] {  });
	}

	public JSBridge (crc64094dd5a32845fa79.HybridWebViewRenderer p0)
	{
		super ();
		if (getClass () == JSBridge.class)
			mono.android.TypeManager.Activate ("ChinaCentre.Droid.JSBridge, ChinaCentre.Android", "ChinaCentre.Droid.HybridWebViewRenderer, ChinaCentre.Android", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public java.lang.String invokePost (java.lang.String p0, java.lang.String p1)
	{
		return n_InvokePost (p0, p1);
	}

	private native java.lang.String n_InvokePost (java.lang.String p0, java.lang.String p1);

	@android.webkit.JavascriptInterface

	public java.lang.String invokeGet (java.lang.String p0, java.lang.String p1)
	{
		return n_InvokeGet (p0, p1);
	}

	private native java.lang.String n_InvokeGet (java.lang.String p0, java.lang.String p1);

	@android.webkit.JavascriptInterface

	public void invokeAlert (java.lang.String p0, java.lang.String p1)
	{
		n_InvokeAlert (p0, p1);
	}

	private native void n_InvokeAlert (java.lang.String p0, java.lang.String p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
