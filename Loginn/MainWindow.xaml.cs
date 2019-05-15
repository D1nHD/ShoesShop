using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Loginn
{
	public partial class MainWindow : Window
	{
		public string L;
		public string P;
		public string C;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, RoutedEventArgs e)
		{
			//LogChe = metroTextBox1.Text;
			if ((loginTextBox.Text != "") && (passwordTextBox.Text != ""))
			{
				L = loginTextBox.Text;
				P = passwordTextBox.Text;
				Login Start = new Login(L, P);

			}
			else
				MessageBox.Show("Input something");
		}

		private void registrationButton_Click(object sender, RoutedEventArgs e)
		{
			if ((loginTextBox.Text != "") && (passwordTextBox.Text != ""))
			{
				L = loginTextBox.Text;
				P = passwordTextBox.Text;
				Registration RStart = new Registration(L, P);
			}
		}
	}
}
