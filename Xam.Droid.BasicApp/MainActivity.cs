using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;


namespace Xam.Droid.BasicApp
{
    [Activity(Label = "Xam.Droid.BasicApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button btnLogin;
        EditText textName;
        EditText textPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            textName = FindViewById<EditText>(Resource.Id.textName);
            textPassword = FindViewById<EditText>(Resource.Id.textPassword);

            btnLogin.Click += BtnLogin_Click;

        }

        public void BtnLogin_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(HomeActivity));

            Person _person = new Person()
            {
                UserName = textName.Text,
                Password = textPassword.Text
            };

            intent.PutExtra("person", Helper.ToJson(_person));

            StartActivity(intent);
        }
    }
}

