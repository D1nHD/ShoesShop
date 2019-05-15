using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    public partial class Tovar : UserControl
    {
        public Tovar()
        {
            InitializeComponent();
        }

		public int ip;

		public BitmapImage bpmain;
		kek k = new kek();
		kek kek = new kek();
		kek kkk = new kek();
		kek eke = new kek();

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere1.jpg"));
			kek.Name.Text = "Adidas Prophere";
			kek.Description.Text = "Rawkha/Tracar/Crywht ";
			kek.Id.Text = "item #1337";
			kek.Price.Text = "Price: 122$";
			ip = 1;
			Image l1 = new Image();
			Image l2 = new Image();
			Image l3 = new Image();
			Image l4 = new Image();
			Image l5 = new Image();
			Image l6 = new Image();


			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			l1.Height = 60;
			l1.Width = 60;

			l2.Height = 60;
			l2.Width = 60;

			l3.Height = 60;
			l3.Width = 60;

			l4.Height = 60;
			l4.Width = 60;

			l5.Height = 60;
			l5.Width = 60;

			l6.Height = 60;
			l6.Width = 60;

			l1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere1.jpg"));
			l2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere2.jpg"));
			l3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere3.jpg"));
			l4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere4.jpg"));
			l5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere5.jpg"));
			l6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere6.jpg"));

			kek.lViev.Items.Add(l1);
			kek.lViev.Items.Add(l2);
			kek.lViev.Items.Add(l3);
			kek.lViev.Items.Add(l4);
			kek.lViev.Items.Add(l5);
			kek.lViev.Items.Add(l6);

			kek.Show();

			l1.MouseDown += new MouseButtonEventHandler(l1_MouseDown);
			l2.MouseDown += new MouseButtonEventHandler(l2_MouseDown);
			l3.MouseDown += new MouseButtonEventHandler(l3_MouseDown);
			l4.MouseDown += new MouseButtonEventHandler(l4_MouseDown);
			l5.MouseDown += new MouseButtonEventHandler(l5_MouseDown);
			l6.MouseDown += new MouseButtonEventHandler(l6_MouseDown);
		}

		public void l1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere1.jpg"));
		}
		public void l2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere2.jpg"));
		}
		public void l3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere3.jpg"));
		}
		public void l4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere4.jpg"));
		}
		public void l5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere5.jpg"));
		}
		public void l6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kek.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Prophere\Adidas Prophere6.jpg"));
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{

			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular1.jpg"));
			kkk.Name.Text = "Adidas Tubular";
			kkk.Description.Text = "Invader Strap BB8943";
			kkk.Id.Text = "item #1488";
			kkk.Price.Text = "Price: 95.49$";
			ip = 2;
			Image i1 = new Image();
			Image i2 = new Image();
			Image i3 = new Image();
			Image i4 = new Image();
			Image i5 = new Image();
			Image i6 = new Image();

			ListViewItem lv1 = new ListViewItem();
			ListViewItem lv2 = new ListViewItem();
			ListViewItem lv3 = new ListViewItem();
			ListViewItem lv4 = new ListViewItem();
			ListViewItem lv5 = new ListViewItem();
			ListViewItem lv6 = new ListViewItem();

			i1.Height=60;
			i1.Width=60;

			i2.Height = 60;
			i2.Width = 60;

			i3.Height = 60;
			i3.Width = 60;

			i4.Height = 60;
			i4.Width = 60;

			i5.Height = 60;
			i5.Width = 60;

			i6.Height = 60;
			i6.Width = 60;

			i1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular1.jpg"));
			i2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular2.jpg"));
			i3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular3.jpg"));
			i4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular4.jpg"));
			i5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular5.jpg"));
			i6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular6.jpg"));

			kkk.lViev.Items.Add(i1);
			kkk.lViev.Items.Add(i2);
			kkk.lViev.Items.Add(i3);
			kkk.lViev.Items.Add(i4);
			kkk.lViev.Items.Add(i5);
			kkk.lViev.Items.Add(i6);

			kkk.Show();

			i1.MouseDown += new MouseButtonEventHandler(i1_MouseDown);
			i2.MouseDown += new MouseButtonEventHandler(i2_MouseDown);
			i3.MouseDown += new MouseButtonEventHandler(i3_MouseDown);
			i4.MouseDown += new MouseButtonEventHandler(i4_MouseDown);
			i5.MouseDown += new MouseButtonEventHandler(i5_MouseDown);
			i6.MouseDown += new MouseButtonEventHandler(i6_MouseDown);


			
		}
		public void i1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular1.jpg"));
		}

		public void i2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular2.jpg"));
		}

		public void i3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular3.jpg"));
		}

		public void i4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular4.jpg"));
		}

		public void i5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular5.jpg"));
		}

		public void i6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			kkk.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Tubular\Adidas Tubular6.jpg"));
		}






		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy1.jpg"));
			eke.Name.Text = "Adidas Originals Crazy";
			eke.Description.Text = "1 ADV AQ0319";
			eke.Id.Text = "item #3221";
			eke.Price.Text = "Price: 144$";
			ip = 3;
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

			q1.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy1.jpg"));
			q2.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy2.jpg"));
			q3.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy3.jpg"));
			q4.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy4.jpg"));
			q5.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy5.jpg"));
			q6.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy6.jpg"));

			eke.lViev.Items.Add(q1);
			eke.lViev.Items.Add(q2);
			eke.lViev.Items.Add(q3);
			eke.lViev.Items.Add(q4);
			eke.lViev.Items.Add(q5);
			eke.lViev.Items.Add(q6);

			eke.Show();

			q1.MouseDown += new MouseButtonEventHandler(q1_MouseDown);
			q2.MouseDown += new MouseButtonEventHandler(q2_MouseDown);
			q3.MouseDown += new MouseButtonEventHandler(q3_MouseDown);
			q4.MouseDown += new MouseButtonEventHandler(q4_MouseDown);
			q5.MouseDown += new MouseButtonEventHandler(q5_MouseDown);
			q6.MouseDown += new MouseButtonEventHandler(q6_MouseDown);



		}
		public void q1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy1.jpg"));
		}

		public void q2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy2.jpg"));
		}

		public void q3_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy3.jpg"));
		}

		public void q4_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy4.jpg"));
		}

		public void q5_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy5.jpg"));
		}

		public void q6_MouseDown(object sender, MouseButtonEventArgs e)
		{
			eke.BigPic.Source = new BitmapImage(new Uri(@"C:\Users\D1nHD\Desktop\Shop\shoesShop\Loginn\assets\shoes\Adidas Originals Crazy\Adidas Originals Crazy6.jpg"));
		}

	}

}
