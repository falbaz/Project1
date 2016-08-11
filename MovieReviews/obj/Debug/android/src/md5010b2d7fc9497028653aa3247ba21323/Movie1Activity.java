package md5010b2d7fc9497028653aa3247ba21323;


public class Movie1Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MovieReviews.Movie1Activity, MovieReviews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Movie1Activity.class, __md_methods);
	}


	public Movie1Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Movie1Activity.class)
			mono.android.TypeManager.Activate ("MovieReviews.Movie1Activity, MovieReviews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
