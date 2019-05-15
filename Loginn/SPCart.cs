using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Threading.Tasks;
using System.Windows;

namespace Loginn
{
	class SPCart
	{

		public string n;
		public string d;
		public string i;
		public string p;
		public string s;

		public SPCart(string N, string D, string I, string P, string S)
		{
			n = N;
			d = D;
			i = I;
			p = P;
			s = S;

			Cart();
		}

		public void Cart()
		{
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F3TMI7E\SQLEXPRESS;Initial Catalog=projectShop;Integrated Security=True"))
			{
				connection.Open();
				SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From SPCart where Name = '" + n + "'", connection);
				DataTable dt = new DataTable();
				sda.Fill(dt);

					SqlCommand command = new SqlCommand("INSERT INTO SPCart (Name, Description, IDn, Price, footsize) VALUES(@Name, @Description, @IDn, @Price, @Footsize)", connection);

					command.Parameters.AddWithValue("Name", n);
					command.Parameters.AddWithValue("Description", d);
					command.Parameters.AddWithValue("IDn", i);
					command.Parameters.AddWithValue("Price", p);
					command.Parameters.AddWithValue("Footsize", s);

					command.ExecuteNonQuery();
					MessageBox.Show("Added to cart");



			}
		}

	}
}
