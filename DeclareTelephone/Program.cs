using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareTelephone
{
	/// <summary>
	/// Exec_DeclareClass
	/// 宣告Telephone類別
	/// </summary>

	internal class Program
	{
		static void Main(string[] args)
		{
			Telephone telephone1 = new Telephone();
			telephone1.CountryCode = "886";
			telephone1.AreaCode = "02";
			telephone1.Number = "12345678";
			telephone1.Ext = "34";
			
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
}
