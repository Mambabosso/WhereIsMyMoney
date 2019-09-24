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
    [Activity(Label = "@string/editAPerson", Theme = "@style/AppTheme")]
    public class EditActivity : AppCompatActivity
    {
        private LinearLayout ae_layout;
        private EditText ae_txtDisplayName;
        private EditText ae_txtFirstName;
        private EditText ae_txtLastName;
        private EditText ae_txtEmail;
        private EditText ae_txtPhone;
        private Button ae_btnDelete;
        private Button ae_btnUpdate;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_edit);
            SetViews();
        }

        private void SetViews()
        {
            this.ae_layout = FindViewById<LinearLayout>(Resource.Id.ae_layout);
            this.ae_txtDisplayName = FindViewById<EditText>(Resource.Id.ae_txtDisplayName);
            this.ae_txtFirstName = FindViewById<EditText>(Resource.Id.ae_txtFirstName);
            this.ae_txtLastName = FindViewById<EditText>(Resource.Id.ae_txtLastName);
            this.ae_txtEmail = FindViewById<EditText>(Resource.Id.ae_txtEmail);
            this.ae_txtPhone = FindViewById<EditText>(Resource.Id.ae_txtPhone);
            this.ae_btnDelete = FindViewById<Button>(Resource.Id.ae_btnDelete);
            this.ae_btnUpdate = FindViewById<Button>(Resource.Id.ae_btnUpdate);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}