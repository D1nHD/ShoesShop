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
	/// Логика взаимодействия для Nike.xaml
	/// </summary>
	public partial class Nike : UserControl
	{
		public Nike()
		{
			InitializeComponent();
		}

		public int ip;

		public BitmapImage bpmain;
		kek k = new kek();
		kek qqq = new kek();
		kek www = new kek();
		kek eee = new kek();

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max1.jpg"));
			qqq.Name.Text = "Nike Air Max Axis";
			qqq.Description.Text = "AA2146-003 ";
			qqq.Id.Text = "item #4563";
			qqq.Price.Text = "Price: 116$";
			ip = 4;
			Image q1 = new Image();
			Image q2 = new Image();
			Image q3 = new Image();
			Image q4 = new Image();
			Image q5 = new Image();
			Image q6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			q1.Height = 60;
			q1.Width = 60;

			q2.Height = 60;
			q2.Width = 60;

			q3.Height = 60;
			q3.Width = 60;

			q4.Height = 60;
			q4.Width = 60;

			q5.Height = 60;
			q5.Width = 60;

			q6.Height = 60;
			q6.Width = 60;

			q1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max1.jpg"));
			q2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max2.jpg"));
			q3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max3.jpg"));
			q4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max4.jpg"));
			q5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max5.jpg"));


			qqq.lViev.Items.Add(q1);
			qqq.lViev.Items.Add(q2);
			qqq.lViev.Items.Add(q3);
			qqq.lViev.Items.Add(q4);
			qqq.lViev.Items.Add(q5);


			qqq.Show();

			q1.MouseDown += new MouseButtonEventHandler(q1_MouseDown);
			q2.MouseDown += new MouseButtonEventHandler(q2_MouseDown);
			q3.MouseDown += new MouseButtonEventHandler(q3_MouseDown);
			q4.MouseDown += new MouseButtonEventHandler(q4_MouseDown);
			q5.MouseDown += new MouseButtonEventHandler(q5_MouseDown);


		}

		public void q1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max1.jpg"));
		}
		public void q2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max2.jpg"));
		}
		public void q3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max3.jpg"));
		}
		public void q4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max4.jpg"));
		}
		public void q5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			qqq.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max\Nike_Air_Max5.jpg"));
		}

		///+++++++++++++++++++++++++++++++++++++++



		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem1.jpg"));
			www.Name.Text = "Nike Air Max Axis Prem";
			www.Description.Text = "AA2148-200";
			www.Id.Text = "item #8977";
			www.Price.Text = "Price: 147$";
			ip = 5;
			Image w1 = new Image();
			Image w2 = new Image();
			Image w3 = new Image();
			Image w4 = new Image();
			Image w5 = new Image();
			Image w6 = new Image();

			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			w1.Height = 60;
			w1.Width = 60;

			w2.Height = 60;
			w2.Width = 60;

			w3.Height = 60;
			w3.Width = 60;

			w4.Height = 60;
			w4.Width = 60;

			w5.Height = 60;
			w5.Width = 60;

			w6.Height = 60;
			w6.Width = 60;

			w1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem1.jpg"));
			w2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem2.jpg"));
			w3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem3.jpg"));
			w4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem4.jpg"));
			w5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem5.jpg"));
			w6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem6.jpg"));

			www.lViev.Items.Add(w1);
			www.lViev.Items.Add(w2);
			www.lViev.Items.Add(w3);
			www.lViev.Items.Add(w4);
			www.lViev.Items.Add(w5);
			www.lViev.Items.Add(w6);

			www.Show();

			w1.MouseDown += new MouseButtonEventHandler(w1_MouseDown);
			w2.MouseDown += new MouseButtonEventHandler(w2_MouseDown);
			w3.MouseDown += new MouseButtonEventHandler(w3_MouseDown);
			w4.MouseDown += new MouseButtonEventHandler(w4_MouseDown);
			w5.MouseDown += new MouseButtonEventHandler(w5_MouseDown);
			w6.MouseDown += new MouseButtonEventHandler(w6_MouseDown);


		}
		public void w1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem1.jpg"));
		}

		public void w2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem2.jpg"));
		}

		public void w3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem3.jpg"));
		}

		public void w4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem4.jpg"));
		}

		public void w5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem5.jpg"));
		}

		public void w6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			www.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Air_Max_Prem\Nike_Air_Max_Axis_Prem6.jpg"));
		}


		//+++++++++++++++++++++



		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide1.jpg"));
			eee.Name.Text = "Nike Flight Bonafide";
			eee.Description.Text = "947242-210";
			eee.Id.Text = "item #3213";
			eee.Price.Text = "Price: 120$";
			ip = 6;
			Image e1 = new Image();
			Image e2 = new Image();
			Image e3 = new Image();
			Image e4 = new Image();
			Image e5 = new Image();
			Image e6 = new Image();

			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			e1.Height = 60;
			e1.Width = 60;

			e2.Height = 60;
			e2.Width = 60;

			e3.Height = 60;
			e3.Width = 60;

			e4.Height = 60;
			e4.Width = 60;

			e5.Height = 60;
			e5.Width = 60;

			e6.Height = 60;
			e6.Width = 60;

			e1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide1.jpg"));
			e2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide2.jpg"));
			e3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide3.jpg"));
			e4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide4.jpg"));
			e5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide5.jpg"));
			e6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide6.jpg"));

			eee.lViev.Items.Add(e1);
			eee.lViev.Items.Add(e2);
			eee.lViev.Items.Add(e3);
			eee.lViev.Items.Add(e4);
			eee.lViev.Items.Add(e5);
			eee.lViev.Items.Add(e6);

			eee.Show();

			e1.MouseDown += new MouseButtonEventHandler(e1_MouseDown);
			e2.MouseDown += new MouseButtonEventHandler(e2_MouseDown);
			e3.MouseDown += new MouseButtonEventHandler(e3_MouseDown);
			e4.MouseDown += new MouseButtonEventHandler(e4_MouseDown);
			e5.MouseDown += new MouseButtonEventHandler(e5_MouseDown);
			e6.MouseDown += new MouseButtonEventHandler(e6_MouseDown);

		}

		public void e1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide1.jpg"));
		}
		public void e2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide2.jpg"));
		}
		public void e3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide3.jpg"));
		}
		public void e4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide4.jpg"));
		}
		public void e5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide5.jpg"));
		}
		public void e6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eee.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Nike_Flight_Bonafide\Nike_Flight_Bonafide6.jpg"));
		}
	}
}
