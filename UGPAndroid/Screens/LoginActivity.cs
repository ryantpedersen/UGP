
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

using UGP.BusinessLayer;

namespace UGPAndroid
{
	[Activity (Label = "LoginActivity")]			
	public class LoginActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here

			// button clicks 
			login.Click += (sender, e) => { Login(); };
		}

		protected void Login ()
		{
			UGP.BusinessLayer.Managers.UserManager.LoginUser ();
		}

		protected void NewUser ()
		{

		}
	}
}

