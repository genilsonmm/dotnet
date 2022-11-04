using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView tvMessage;
        private Button btnMessage;
        private int count = 0;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            tvMessage = (TextView)FindViewById(Resource.Id.tvMessage);
            btnMessage = (Button)FindViewById(Resource.Id.btnMessage);

            btnMessage.Click += delegate
            {
                tvMessage.Text = "Android: " + count++;
            };
        }
    }
}