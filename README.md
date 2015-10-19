Xamarin.Gozer.Droid
=============

Gozer is an Open Source Xamarin Android library that allows developers to easily create applications with custom fonts and easily works  with preloaded labels. Feel free to use it all you want in your Android apps provided that you cite this project and include the license in your app.
It extends https://github.com/Florismart/Xamarin.Fontysfaction project, so you can use (or not) its setups!


Setup
-----
__1.__ In Xamarin, import the library as an Android library project. Now you can build it and export as DLL.

__2.__ Then, add Fontysfaction dll as a dependency to your existing project.

__3.__ At Last quick setup your application class and you are good to go!

Or just import via nuget as Xamarin.Gozer.Droid

```C#
[Application]
class MyApplication: Application
{

    public override void OnCreate ()
    {
        base.OnCreate ();
    		
        //crete dictionary (download your dictionary or load from assets..)
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
```

Configuration
-----
Dictionary for VinzClortho (the Keymaster) is optional. But you shoud assign it if you wana see something in your app :D
```C#
VinzClortho.Instance.Keys = new Dictionary<string, string>();
```

XML Usage
-----
If you decide to use Zuul(s) as a view, you can define it in your xml layouts like this:
```xml
<Florismart.Gozer.Droid.Views.ZuulEditText
    xmlns:keymaster="http://schemas.android.com/apk/res-auto"
    android:id="@+id/ray_editText"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    keymaster:keyName="gozer" />

<Florismart.Gozer.Droid.Views.ZuulTextView
    xmlns:keymaster="http://schemas.android.com/apk/res-auto"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    keymaster:keyName="questionOne" />

<Florismart.Gozer.Droid.Views.ZuulTextView
    xmlns:keymaster="http://schemas.android.com/apk/res-auto"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    keymaster:keyName="answerOne" />

<Florismart.Gozer.Droid.Views.ZuulButton
    xmlns:keymaster="http://schemas.android.com/apk/res-auto"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    keymaster:keyName="answerTwo" />
```
