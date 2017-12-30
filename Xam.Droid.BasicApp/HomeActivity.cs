
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xam.Droid.BasicApp
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {

        TextView tView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            tView = FindViewById<TextView>(Resource.Id.tView);

            var _person = Intent.GetStringExtra("person");

            Person selectedPerson = Helper.FromJson<Person>(_person);

            tView.Text = selectedPerson.UserName;
        }
    }
}
