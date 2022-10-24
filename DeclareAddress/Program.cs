using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareAddress
{
	/// <summary>
	/// Exec_DeclareClass
	/// 宣告Address類別
	/// </summary>

	internal class Program
	{
		static void Main(string[] args)
		{
			Address address1 = new Address();
			address1.City = "Taipei";
			address1.ZipCode = "116";
			address1.Street = "Jin-Wen";
			Console.WriteLine($"{address1.City}, {address1.ZipCode}, {address1.Street}.");

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
}
