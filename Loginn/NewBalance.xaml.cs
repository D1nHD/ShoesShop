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
	/// Логика взаимодействия для NewBalance.xaml
	/// </summary>
	public partial class NewBalance : UserControl
	{
		public NewBalance()
		{
			InitializeComponent();
		}

		public int ip;

		public BitmapImage bpmain;
		kek k = new kek();
		kek rrr = new kek();
		kek ttt = new kek();
		kek yyy = new kek();

		private void Button_Click(object sender, RoutedEventArgs e)
		{

			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_1.jpg"));
			rrr.Name.Text = "New Balance 574S";
			rrr.Description.Text = "MS574KTD ";
			rrr.Id.Text = "item #0965";
			rrr.Price.Text = "Price: 125$";
			ip = 7;
			Image r1 = new Image();
			Image r2 = new Image();
			Image r3 = new Image();
			Image r4 = new Image();
			Image r5 = new Image();
			Image r6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			r1.Height = 60;
			r1.Width = 60;

			r2.Height = 60;
			r2.Width = 60;

			r3.Height = 60;
			r3.Width = 60;

			r4.Height = 60;
			r4.Width = 60;

			r5.Height = 60;
			r5.Width = 60;

			r6.Height = 60;
			r6.Width = 60;

			r1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_1.jpg"));
			r2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_2.jpg"));
			r3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_3.jpg"));
			r4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_4.jpg"));
			r5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_5.jpg"));
			r6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_6.jpg"));


			rrr.lViev.Items.Add(r1);
			rrr.lViev.Items.Add(r2);
			rrr.lViev.Items.Add(r3);
			rrr.lViev.Items.Add(r4);
			rrr.lViev.Items.Add(r5);
			rrr.lViev.Items.Add(r6);


			rrr.Show();

			r1.MouseDown += new MouseButtonEventHandler(r1_MouseDown);
			r2.MouseDown += new MouseButtonEventHandler(r2_MouseDown);
			r3.MouseDown += new MouseButtonEventHandler(r3_MouseDown);
			r4.MouseDown += new MouseButtonEventHandler(r4_MouseDown);
			r5.MouseDown += new MouseButtonEventHandler(r5_MouseDown);
			r6.MouseDown += new MouseButtonEventHandler(r6_MouseDown);
		}

		public void r1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_1.jpg"));
		}
		public void r2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_2.jpg"));
		}
		public void r3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_3.jpg"));
		}
		public void r4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_4.jpg"));
		}
		public void r5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_5.jpg"));
		}
		public void r6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			rrr.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_574S\New_Balance_574S_6.jpg"));
		}

		

		///+++++++++++++++++++++++++++++++++++++++
		///


		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			ttt.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_1.jpg"));
			ttt.Name.Text = "New Balance 997S";
			ttt.Description.Text = "MS997HGB ";
			ttt.Id.Text = "item #4572";
			ttt.Price.Text = "Price: 147$";
			ip = 8;
			Image t1 = new Image();
			Image t2 = new Image();
			Image t3 = new Image();
			Image t4 = new Image();



			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();


			t1.Height = 60;
			t1.Width = 60;

			t2.Height = 60;
			t2.Width = 60;

			t3.Height = 60;
			t3.Width = 60;

			t4.Height = 60;
			t4.Width = 60;



			t1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_1.jpg"));
			t2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_2.jpg"));
			t3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_3.jpg"));
			t4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_4.jpg"));



			ttt.lViev.Items.Add(t1);
			ttt.lViev.Items.Add(t2);
			ttt.lViev.Items.Add(t3);
			ttt.lViev.Items.Add(t4);



			ttt.Show();

			t1.MouseDown += new MouseButtonEventHandler(t1_MouseDown);
			t2.MouseDown += new MouseButtonEventHandler(t2_MouseDown);
			t3.MouseDown += new MouseButtonEventHandler(t3_MouseDown);
			t4.MouseDown += new MouseButtonEventHandler(t4_MouseDown);

		}
		public void t1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ttt.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_1.jpg"));
		}
		public void t2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ttt.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_2.jpg"));
		}
		public void t3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ttt.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_3.jpg"));
		}
		public void t4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ttt.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997S\New_Balance_997S_4.jpg"));
		}
		//============================================================



		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_1.jpg"));
			yyy.Name.Text = "New Balance 997";
			yyy.Description.Text = "CM997HCE";
			yyy.Id.Text = "item #3251";
			yyy.Price.Text = "Price: 120$";
			ip = 9;
			Image y1 = new Image();
			Image y2 = new Image();
			Image y3 = new Image();
			Image y4 = new Image();
			Image y5 = new Image();
			Image y6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			y1.Height = 60;
			y1.Width = 60;

			y2.Height = 60;
			y2.Width = 60;

			y3.Height = 60;
			y3.Width = 60;

			y4.Height = 60;
			y4.Width = 60;

			y5.Height = 60;
			y5.Width = 60;

			y6.Height = 60;
			y6.Width = 60;

			y1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_1.jpg"));
			y2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_2.jpg"));
			y3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_3.jpg"));
			y4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_4.jpg"));
			y5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_5.jpg"));
			y6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_6.jpg"));


			yyy.lViev.Items.Add(y1);
			yyy.lViev.Items.Add(y2);
			yyy.lViev.Items.Add(y3);
			yyy.lViev.Items.Add(y4);
			yyy.lViev.Items.Add(y5);
			yyy.lViev.Items.Add(y6);


			yyy.Show();

			y1.MouseDown += new MouseButtonEventHandler(y1_MouseDown);
			y2.MouseDown += new MouseButtonEventHandler(y2_MouseDown);
			y3.MouseDown += new MouseButtonEventHandler(y3_MouseDown);
			y4.MouseDown += new MouseButtonEventHandler(y4_MouseDown);
			y5.MouseDown += new MouseButtonEventHandler(y5_MouseDown);
			y6.MouseDown += new MouseButtonEventHandler(y6_MouseDown);
		}
		public void y1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_1.jpg"));
		}
		public void y2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_2.jpg"));
		}
		public void y3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_3.jpg"));
		}
		public void y4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_4.jpg"));
		}
		public void y5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_5.jpg"));
		}
		public void y6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			yyy.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\New_Balance_997\New_Balance_997_6.jpg"));
		}

	}
}
