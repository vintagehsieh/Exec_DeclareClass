using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DeclareMember
{
	/// <summary>
	/// Exec_DeclareClass
	/// 宣告Member類別
	/// </summary>
	
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Telephone
	{
		private string _CountryCode;
		private string _AreaCode;
		private string _Number;
		private string _Ext;

		public string CountryCode
		{
			get { return _CountryCode; }
			set { _CountryCode = value; }
		}
		public string AreaCode
		{
			get { return _AreaCode; }
			set { _AreaCode = value; }
		}

		public string Number
		{
			get { return _Number; }
			set { _Number = value; }
		}

		public string Ext
		{
			get { return _Ext; }
			set { _Ext = value; }
		}
	}
	class Address
	{
		private string _City;
		private string _ZipCode;
		private string _Street;

		public string City
		{
			get { return _City; }
			set { _City = value; }
		}
		public string ZipCode
		{
			get { return _ZipCode; }
			set { _ZipCode = value; }
		}

		public string Street
		{
			get { return _Street; }
			set { _Street = value; }
		}
	}

	class Member
	{
		private string _Name;
		private string _Account;
		private string _Email;
		private string _Address;
		private string _CellPhone;
		private string _Telephone;
		private string _Password;
		private string _ConfirmPassword;

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public string Account
		{
			get { return _Account; }	
			set { _Account = value; }	
		}

		public string Email
		{
			get { return _Email; }	
			set { _Email = value; }
		}

		private string CellPhone { get; set; }

		//沿用上述Address類別中的各個型別
		public class Address
		{
			Address city = new Address();
			Address zipcode = new Address();
			Address street = new Address();
		}

		//沿用上述Telephone類別中的各個型別
		public class Telephone
		{			
			Telephone countrycode = new Telephone();
			Telephone areacode = new Telephone();
			Telephone number = new Telephone();
			Telephone ext = new Telephone();
		}

		//具備register method來註冊會員，參數包含Name, Account, Password, ConfirmPassword, Email
		public void Register(string name, string account, string password, string confirmPassword, string email)
		{
			_Name = name;
			_Account = account;
			_Password = password;
			_ConfirmPassword = confirmPassword;
			_Email = email;
		}

		//具備ForgetPassword method來處理忘記密碼，參數包含Name, email
		public void ForgetPassword(string name, string email)
		{
			_Name = name;
			_Email = email;
		}

		//具備Authenticate method來判斷是否允許使用者登入，參數包含account, password
		 private bool Authenticate(string account, string password)
		{
			return (_Account == account && _Password == password);
			/*
			if (_Account == account && _Password == password)
			{
				return true;
			}else
			{
				return false;
			}
			*/
		}
	}
}
