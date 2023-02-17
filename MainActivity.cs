using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Xamarin.Essentials;

namespace The_Hardestest_Game_01
{
    [Activity(Label = "The Hardestest Game 01", Theme = "@style/AppTheme", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var player = FindViewById<ImageView>(Resource.Id.player);
            var rButton =FindViewById<Button>(Resource.Id.rightButton);
            var lButton = FindViewById<Button>(Resource.Id.leftButton);
            var uButton = FindViewById<Button>(Resource.Id.Up);
            var dButton = FindViewById<Button>(Resource.Id.Down);
            player.SetX(400);
            player.SetY(200);
            rButton.Click += (s, e) =>
            {
                var a = player.GetX();
                player.SetX(a+20);
            };
            lButton.Click += (s, e) =>
            {
                var a = player.GetX();
                player.SetX(a-20);
            };
            uButton.Click += (s, e) =>
            {
                var a = player.GetY();
                player.SetY(a - 20);
            };
            dButton.Click += (s, e) =>
            {
                var a = player.GetY();
                player.SetY(a + 20);
            };





        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}