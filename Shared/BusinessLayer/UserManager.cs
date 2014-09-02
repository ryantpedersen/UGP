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
			DataAccessLayer.UserData ud = new DataAccessLayer.UserData ();
			ud.LoginUser ();
		}

		public static void NewUser()
		{
			DataAccessLayer.UserData ud = new DataAccessLayer.UserData ();
			ud.NewUser ();
		}
	}
}

