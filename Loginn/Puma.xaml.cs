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

namespace Loginn
{
	/// <summary>
	/// Логика взаимодействия для Puma.xaml
	/// </summary>
	public partial class Puma : UserControl
	{
		public Puma()
		{
			InitializeComponent();
		}
		public int ip;

		public BitmapImage bpmain;
		kek k = new kek();
		kek zzz = new kek();
		kek xxx = new kek();
		kek ccc = new kek();

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_1.jpg"));
			zzz.Name.Text = "CELL Endura Animal ";
			zzz.Description.Text = "Kingdom Sneakers ";
			zzz.Id.Text = "item #3709";
			zzz.Price.Text = "Price: 130";
			ip = 10;
			Image z1 = new Image();
			Image z2 = new Image();
			Image z3 = new Image();
			Image z4 = new Image();
			Image z5 = new Image();
			Image z6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			z1.Height = 60;
			z1.Width = 60;

			z2.Height = 60;
			z2.Width = 60;

			z3.Height = 60;
			z3.Width = 60;

			z4.Height = 60;
			z4.Width = 60;

			z5.Height = 60;
			z5.Width = 60;

			z6.Height = 60;
			z6.Width = 60;

			z1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_1.jpg"));
			z2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_2.jpg"));
			z3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_3.jpg"));
			z4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_4.jpg"));
			z5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_5.jpg"));
			z6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_6.jpg"));


			zzz.lViev.Items.Add(z1);
			zzz.lViev.Items.Add(z2);
			zzz.lViev.Items.Add(z3);
			zzz.lViev.Items.Add(z4);
			zzz.lViev.Items.Add(z5);
			zzz.lViev.Items.Add(z6);


			zzz.Show();

			z1.MouseDown += new MouseButtonEventHandler(z1_MouseDown);
			z2.MouseDown += new MouseButtonEventHandler(z2_MouseDown);
			z3.MouseDown += new MouseButtonEventHandler(z3_MouseDown);
			z4.MouseDown += new MouseButtonEventHandler(z4_MouseDown);
			z5.MouseDown += new MouseButtonEventHandler(z5_MouseDown);
			z6.MouseDown += new MouseButtonEventHandler(z6_MouseDown);
		}
		public void z1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_1.jpg"));
		}
		public void z2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_2.jpg"));
		}
		public void z3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_3.jpg"));
		}
		public void z4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_4.jpg"));
		}
		public void z5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_5.jpg"));
		}
		public void z6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			zzz.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\CELL_Endura_Animal\CELL_Endura_Animal_6.jpg"));
		}

		//======================================================================

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_1.jpg"));
			xxx.Name.Text = "Suede Garden Sneakers";
			xxx.Description.Text = "Kingdom Пumshoes ";
			xxx.Id.Text = "item #3692";
			xxx.Price.Text = "Price: 60";
			ip = 11;
			Image x1 = new Image();
			Image x2 = new Image();
			Image x3 = new Image();
			Image x4 = new Image();
			Image x5 = new Image();
			Image x6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			x1.Height = 60;
			x1.Width = 60;

			x2.Height = 60;
			x2.Width = 60;

			x3.Height = 60;
			x3.Width = 60;

			x4.Height = 60;
			x4.Width = 60;

			x5.Height = 60;
			x5.Width = 60;

			x6.Height = 60;
			x6.Width = 60;

			x1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_1.jpg"));
			x2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_2.jpg"));
			x3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_3.jpg"));
			x4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_4.jpg"));
			x5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_5.jpg"));
			x6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_6.jpg"));


			xxx.lViev.Items.Add(x1);
			xxx.lViev.Items.Add(x2);
			xxx.lViev.Items.Add(x3);
			xxx.lViev.Items.Add(x4);
			xxx.lViev.Items.Add(x5);
			xxx.lViev.Items.Add(x6);


			xxx.Show();

			x1.MouseDown += new MouseButtonEventHandler(x1_MouseDown);
			x2.MouseDown += new MouseButtonEventHandler(x2_MouseDown);
			x3.MouseDown += new MouseButtonEventHandler(x3_MouseDown);
			x4.MouseDown += new MouseButtonEventHandler(x4_MouseDown);
			x5.MouseDown += new MouseButtonEventHandler(x5_MouseDown);
			x6.MouseDown += new MouseButtonEventHandler(x6_MouseDown);
		}
		public void x1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_1.jpg"));
		}
		public void x2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_2.jpg"));
		}
		public void x3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_3.jpg"));
		}
		public void x4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_4.jpg"));
		}
		public void x5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_5.jpg"));
		}
		public void x6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			xxx.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Suede_Garden_Sneakers\Suede_Garden_Sneakers_6.jpg"));
		}


		//========================================================


		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_1.jpg"));
			ccc.Name.Text = "Suede Garden Sneakers";
			ccc.Description.Text = "Kingdom Пumshoes ";
			ccc.Id.Text = "item #3692";
			ccc.Price.Text = "Price: 60";
			ip = 11;
			Image c1 = new Image();
			Image c2 = new Image();
			Image c3 = new Image();
			Image c4 = new Image();
			Image c5 = new Image();
			Image c6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			c1.Height = 60;
			c1.Width = 60;

			c2.Height = 60;
			c2.Width = 60;

			c3.Height = 60;
			c3.Width = 60;

			c4.Height = 60;
			c4.Width = 60;

			c5.Height = 60;
			c5.Width = 60;

			c6.Height = 60;
			c6.Width = 60;

			c1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_1.jpg"));
			c2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_2.jpg"));
			c3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_3.jpg"));
			c4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_4.jpg"));
			c5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_5.jpg"));
			c6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_6.jpg"));


			ccc.lViev.Items.Add(c1);
			ccc.lViev.Items.Add(c2);
			ccc.lViev.Items.Add(c3);
			ccc.lViev.Items.Add(c4);
			ccc.lViev.Items.Add(c5);
			ccc.lViev.Items.Add(c6);


			ccc.Show();


			c1.MouseDown += new MouseButtonEventHandler(c1_MouseDown);
			c2.MouseDown += new MouseButtonEventHandler(c2_MouseDown);
			c3.MouseDown += new MouseButtonEventHandler(c3_MouseDown);
			c4.MouseDown += new MouseButtonEventHandler(c4_MouseDown);
			c5.MouseDown += new MouseButtonEventHandler(c5_MouseDown);
			c6.MouseDown += new MouseButtonEventHandler(c6_MouseDown);



		}
		public void c1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_1.jpg"));
		}
		public void c2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_2.jpg"));
		}
		public void c3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_3.jpg"));
		}
		public void c4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_4.jpg"));
		}
		public void c5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_5.jpg"));
		}
		public void c6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ccc.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\MMS_Thunder_Sneakers\MMS_Thunder_Sneakers_6.jpg"));
		}


	}
	}

