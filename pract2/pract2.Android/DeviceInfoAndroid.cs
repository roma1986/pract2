using Android.OS;
using Xamarin.Forms;


[assembly: Dependency(typeof(pract2.Droid.DeviceInfoAndroid))]
namespace pract2.Droid
{
    public class DeviceInfoAndroid : IdDeviceinfo
    {
        public string GetInfo()
        {
            return $"Android {Build.VERSION.Release.ToString()}";
        }
    }
}