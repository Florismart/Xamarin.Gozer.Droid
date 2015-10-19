using System;
using Android.App;
using Android.Runtime;
using System.Collections.Generic;
using Florismart.Gozer.Droid.Core;

namespace Florismart.Gozer.Droid.Sample
{
	[Application]
	public class MyApplication: Application
	{
		public MyApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			var keys = new Dictionary<string, string> ();
			keys.Add ("egon", "Dr. Egon Spengler");
			keys.Add ("ray", "Dr Ray Stantz");
			keys.Add ("gozer","Gozer");
			keys.Add ("questionOne", "Are you a God?");
			keys.Add ("answerOne", "No");
			keys.Add ("answerTwo", "Then... DIE! ");

			VinzClortho.Instance.Keys = keys;
		}
	}
}

