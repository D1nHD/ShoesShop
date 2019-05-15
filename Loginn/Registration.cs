using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Loginn
{
	class Registration
	{
		public string l;
		public string p;
		public string c;

		public Registration(string L, string P)
		{
			l = L;
			p = P;
			Reg();
		}
		public void Reg()
		{
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F3TMI7E\SQLEXPRESS;Initial Catalog=projectShop;Integrated Security=True"))
			{
				connection.Open();
				SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From log where Login = '" + l + "'", connection);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				if (dt.Rows[0][0].ToString() == "0")
				{
					SqlCommand command = new SqlCommand("INSERT INTO log (Login, Password) VALUES(@Login, @Password)", connection);

					command.Parameters.AddWithValue("Login", l);
					command.Parameters.AddWithValue("Password", p);

					command.ExecuteNonQuery();
					MessageBox.Show("U r in base, Sir");
				}
				else
					MessageBox.Show("This login zanyat, Sir. Sorry((9(");
				c = "This Login zanyat,Sir.";
			}
		}
	}
}