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
	/// Логика взаимодействия для MainStore.xaml
	/// </summary>
	public partial class MainStore : Window
	{




		public MainStore()
		{
			InitializeComponent();
		}


			
		private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
			//Namee1 = loginn1;

			int index = ListViewMenu.SelectedIndex;

			switch (index)
			{
				case 0:
					GridPrincipal.Children.Clear();
					GridPrincipal.Children.Add(new Tovar());
					break;
				case 1:
					GridPrincipal.Children.Clear();
					GridPrincipal.Children.Add(new Nike());
					break;
				case 2:
					GridPrincipal.Children.Clear();
					GridPrincipal.Children.Add(new NewBalance());
					break;
				case 3:
					GridPrincipal.Children.Clear();
					GridPrincipal.Children.Add(new Puma());
					break;
				default:
					break;
			}
		}

		public static implicit operator MainStore(string v)
		{
			throw new NotImplementedException();
		}
	}
}
