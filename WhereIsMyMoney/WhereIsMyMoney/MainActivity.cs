using System;

using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace WhereIsMyMoney
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private CoordinatorLayout am_layout;
        private RecyclerView am_rcvPersons;
        private FloatingActionButton am_fabAdd;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            SetViews();
        }

        private void SetViews()
        {
            this.am_layout = FindViewById<CoordinatorLayout>(Resource.Id.am_layout);
            this.am_rcvPersons = FindViewById<RecyclerView>(Resource.Id.am_rcvPersons);
            this.am_fabAdd = FindViewById<FloatingActionButton>(Resource.Id.am_fabAdd);
            this.am_fabAdd.Click += (s, e) => ShowAddAPerson();
        }

        private void ShowSettings()
        {
        }

        private void ShowAbout()
        {
            string app_name = Resources.GetString(Resource.String.app_name);
            string version = Resources.GetString(Resource.String.version);
            string author = Resources.GetString(Resource.String.author);
            Snackbar.Make(am_layout, string.Format("{0} - {1} - {2}", app_name, version, author), Snackbar.LengthLong).Show();
        }

        private void ShowAddAPerson()
        {
            StartActivity(typeof(AddActivity));
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.mm_settings:
                    ShowSettings();
                    return true;
                case Resource.Id.mm_about:
                    ShowAbout();
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}