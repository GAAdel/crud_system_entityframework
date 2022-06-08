using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_prod4
{
	public partial class Login : Form
	{
		int countlogin = 0;
		public Login()
		{
			InitializeComponent();
			labelTimer.Visible = false;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();

			string emailUser = textBoxEmail.Text;
			string passwordUser = textBoxPassword.Text;

			var dbUsers = db.Users;

			var currenUser = dbUsers.FirstOrDefault(person => person.Email == emailUser
				&& person.Password == passwordUser);

			if (currenUser == null)
			{
				countlogin++;
				if (countlogin >= 3)
				{
					labelTimer.Visible = true;
					timerTick.Start();
					btnLogin.Enabled = false;
					countlogin = 0;
				}
				MessageBox.Show("Неверные данные!");
				return;
			}

			if (currenUser.Active != true)
			{
				MessageBox.Show("Пользователь заблокирован!");
				return;
			}

			if (currenUser.RoleID == 1)
			{
				MainForm form = new MainForm();
				form.Show();
			}

			if (currenUser.RoleID == 2)
			{
				MessageBox.Show("Пользователь!");
			}
		}

		int tickLogin = 10;
		private void timerTick_Tick(object sender, EventArgs e)
		{
			if (tickLogin == 0)
			{
				tickLogin = 10;
				timerTick.Stop();
				labelTimer.Visible = false;
				btnLogin.Enabled = true;
			} else
			{
				tickLogin--;
				labelTimer.Text = "Повторите попытку через " + tickLogin + " секунд !";
			}

		}
	}
}
