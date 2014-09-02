using System;
using UGP.DataAccessLayer;

namespace UGP.BusinessLayer.Managers
{
	public class UserManager
	{
		public UserManager ()
		{
		}

		public static void LoginUser()
		{
			UserData ud = new UserData ();
			ud.LoginUser ();
		}

		public static void NewUser()
		{
			UserData ud = new UserData ();
			ud.NewUser ();
		}
	}
}

