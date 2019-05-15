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
using System.Windows.Shapes;

namespace Loginn
{
    /// <summary>
    /// Логика взаимодействия для kek.xaml
    /// </summary>
    public partial class kek : Window
    {

		public string N;
		public string D;
		public string I;
		public string P;
		public string S;

		public kek()
        {
            InitializeComponent();
        }

		public Tovar k1;

		private void Button_MouseDown(object sender, MouseButtonEventArgs e)
		{

		}

		private void AddToCart_Click(object sender, RoutedEventArgs e)
		{
				if ((Name.Text != "") && (Description.Text != "") && (Id.Text != "") && (Price.Text != ""))
				{
					N = Name.Text;
					D = Description.Text;
					I = Id.Text;
					P = Price.Text;
					S = footsize.Text;
					SPCart Cart = new SPCart(N, D, I ,P, S);
				}
			

		}
	}
}
