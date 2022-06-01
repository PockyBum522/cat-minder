using Android.Widget;
using CatMinder.Core.Interfaces;
using Application = Android.App.Application;

//[assembly:Dependency(typeof(ToastNotification))]

namespace CatMinder.Platforms.Android;

public class ToastMessage : IToastMessage
{

    public void LongToast(string message)
    {
        Toast.MakeText(Application.Context, message, ToastLength.Short)?.Show();
    }

    public void ShortToast(string message)
    {
        Toast.MakeText(Application.Context, message, ToastLength.Long)?.Show();
    }
}