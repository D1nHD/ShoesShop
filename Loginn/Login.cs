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
	class Login
	{
		public string l;
		public string p;
		public string c;
		public Login(string L, string P)
		{
			l = L;
			p = P;
			Log();
		}

		public void Log()
		{
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F3TMI7E\SQLEXPRESS;Initial Catalog=projectShop;Integrated Security=True"))
			{
				connection.Open();
				SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From log where Login = '" + l + "' and Password = '" + p + "'", connection);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				if (dt.Rows[0][0].ToString() == "1")
				{
					MainStore MainStore = new MainStore();
					MainStore.Show();

					MainStore.usName.Text = l;

				}
				else
				{
					c = "Incorrect Data. Retry, Sir";
				}
				}
			}
		}
	}



