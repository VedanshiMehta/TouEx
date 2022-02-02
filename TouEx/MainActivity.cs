using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace TouEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ImageView myTouch;
        private TextView myView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myTouch = FindViewById<ImageView>(Resource.Id.imageView1);
            myView = FindViewById<TextView>(Resource.Id.textView1);

            myTouch.Touch += MyTouch_Touch;

        }

        private void MyTouch_Touch(object sender, View.TouchEventArgs e)
        {
            string message;

            switch (e.Event.Action & MotionEventActions.Mask)
            {
                case MotionEventActions.Down:
                case MotionEventActions.Move:
                    message = "Touch Begins";
                    break;

                case MotionEventActions.Up:
                    message = "Touch Ends";
                    break;

                default:
                    message = string.Empty;
                    break;

            }

            myView.Text = message;
        }

        /*private void MyTouch_Touch(object sender, Android.Views.View.TouchEventArgs e)
        {
            string message;

            switch (e.Event.Action & MotionEventActions.Mask)
            {
                case MotionEventActions.Down:
                case MotionEventActions.Move:
                    message = "Touch Begins";
                    break;

                case MotionEventActions.Up:
                    message = "Touch Ends";
                    break;

                default:
                    message = string.Empty;
                    break;

            }

            myView.Text = message;
        }*/
    }
}
