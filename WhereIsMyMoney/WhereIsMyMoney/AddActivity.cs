using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

using WhereIsMyMoney.Data;

namespace WhereIsMyMoney
{
    [Activity(Label = "@string/addAPerson", Theme = "@style/AppTheme")]
    public class AddActivity : AppCompatActivity
    {
        private LinearLayout aa_layout;
        private EditText aa_txtDisplayName;
        private EditText aa_txtFirstName;
        private EditText aa_txtLastName;
        private EditText aa_txtEmail;
        private EditText aa_txtPhone;
        private Button aa_btnImportContact;
        private Button aa_btnSave;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add);
            SetViews();
            SetEvents();
        }

        private void SetViews()
        {
            this.aa_layout = FindViewById<LinearLayout>(Resource.Id.aa_layout);
            this.aa_txtDisplayName = FindViewById<EditText>(Resource.Id.aa_txtDisplayName);
            this.aa_txtFirstName = FindViewById<EditText>(Resource.Id.aa_txtFirstName);
            this.aa_txtLastName = FindViewById<EditText>(Resource.Id.aa_txtLastName);
            this.aa_txtEmail = FindViewById<EditText>(Resource.Id.aa_txtEmail);
            this.aa_txtPhone = FindViewById<EditText>(Resource.Id.aa_txtPhone);
            this.aa_btnImportContact = FindViewById<Button>(Resource.Id.aa_btnImportContact);
            this.aa_btnSave = FindViewById<Button>(Resource.Id.aa_btnSave);
        }

        private void SetEvents()
        {
            aa_btnImportContact.Click += ImportContact;
            aa_btnSave.Click += Save;
        }

        private void ImportContact(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Save(object sender, EventArgs e)
        {
            string displayName = aa_txtDisplayName.Text;
            string firstName = aa_txtFirstName.Text;
            string lastName = aa_txtLastName.Text;
            string email = aa_txtEmail.Text;
            string phone = aa_txtPhone.Text;

            Control.GetPeople().Add(new Data.Person(displayName, firstName, lastName, email, phone));

            ShowMainActivity();
        }

        private void ShowMainActivity()
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}