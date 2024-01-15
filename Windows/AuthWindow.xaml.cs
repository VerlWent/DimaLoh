using demopract2024_2.Model;
using demopract2024_2.Windows;
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

namespace DemoExm2024.Windows
{
	/// <summary>
	/// Логика взаимодействия для AuthWindow.xaml
	/// </summary>
	public partial class AuthWindow : Window
	{
		ContextClass _context = new ContextClass();

		public AuthWindow()
		{
			InitializeComponent();
		}

		public void CheckLogin()
		{
			string password;
			if (TBPasswordHide.Visibility == Visibility.Visible)
			{
				password = TBPasswordHide.Password;
			}
			else
			{
				password = TBPasswordVis.Text;
			}
			var GetUser = _context.Users.FirstOrDefault(x => x.UserLogin == TBLogin.Text && x.UserPassword == password);

			if (GetUser != null)
			{
				OutViewInfo OVI = new OutViewInfo();
				OVI.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Данные не верные");
			}
		}

		private void btnHidePass_Click(object sender, RoutedEventArgs e)
		{
			if (TBPasswordHide.Visibility == Visibility.Visible)
			{
				TBPasswordHide.Visibility = Visibility.Collapsed;
				TBPasswordVis.Visibility = Visibility.Visible;
				TBPasswordVis.Text = TBPasswordHide.Password;
			}
			else
			{
				TBPasswordVis.Visibility = Visibility.Collapsed;
				TBPasswordHide.Visibility = Visibility.Visible;
				TBPasswordHide.Password = TBPasswordVis.Text;
			}
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			CheckLogin();
		}

		private void btnRegister_Click(object sender, RoutedEventArgs e)
		{
			RegisterWindow RW = new RegisterWindow();
			RW.Show();
			this.Close();
		}
	}
}
