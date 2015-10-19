using System;
using Florismart.Fontisfaction.Droid.View;
using Android.Content;
using Android.Util;
using Android.Content.Res;
using Florismart.Gozer.Droid.Core;

namespace Florismart.Gozer.Droid.Views
{
	public class ZuulTextView: FontyTextView
	{
		public ZuulTextView (Context context) : base (context)
		{
		}

		public ZuulTextView (Context context, IAttributeSet attrs) : base (context, attrs)
		{
		}

		public ZuulTextView (Context context, IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
		{
		}

		protected override void initAttributes (Context context, IAttributeSet attrs)
		{
			if (attrs != null) {
				TypedArray a = context.ObtainStyledAttributes (attrs, Resource.Styleable.Keymaster);
				var labelKey = a.GetString (Resource.Styleable.Keymaster_keyName);
				if (!string.IsNullOrEmpty (labelKey))
					SetMatrixString (VinzClortho.Instance.Get (labelKey));
				a.Recycle ();
			}
			base.initAttributes (context, attrs);
		}

		private void SetMatrixString (string value)
		{
			if (!string.IsNullOrEmpty (value))
				Text = value;
		}
	}
}
