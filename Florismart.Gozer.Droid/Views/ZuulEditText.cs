using System;
using Android.Content;
using Android.Util;
using Florismart.Fontisfaction.Droid.View;
using Florismart.Gozer.Droid.Core;
using Android.Content.Res;

namespace Florismart.Gozer.Droid.Views
{
	public class ZuulEditText: FontyEditText
	{
		public ZuulEditText (Context context) : base (context)
		{
		}

		public ZuulEditText (Context context, IAttributeSet attrs) : base (context, attrs)
		{
		}

		public ZuulEditText (Context context, IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
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
				Hint = value;
		}
	}
}