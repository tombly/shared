using Android.Widget;

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            TextView textView = FindViewById<TextView>(Resource.Id.textView1)!;
            textView.Text = DateTime.Now.ToString();
        }
    }
}