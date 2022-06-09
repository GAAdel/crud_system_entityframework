using entity_prod4.Models;
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
	public partial class AddUserForm : Form
	{
		public AddUserForm()
		{
			InitializeComponent();
			FillComboBox();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();

			string emailUser = textBoxEmail.Text;
			string firstNameUser = textBoxName.Text;
			string lastNameUser = textBoxSurname.Text;

			string officeNameUser = comboBoxOffices.Text;
			var dbOffices = db.Offices;
			var officeUser = dbOffices.FirstOrDefault(office => office.Title == officeNameUser).ID;

			DateTime birthdayUser = dateTimePickerBirthday.Value.Date;

			string passwordUser = textBoxPassword.Text;

			if (!isCheckUserEmailExist(emailUser))
			{
				MessageBox.Show("Пользователь с таким логином уже существует в системе!");
			} else
			{
				User user = new User
				{
					OfficeID = officeUser,
					RoleID = 2,
					Email = emailUser,
					Password = passwordUser,
					Firstname = firstNameUser,
					Lastname = lastNameUser,
					Birthdate = birthdayUser,
					Active = true
				};

				db.Users.Add(user);
				db.SaveChanges();
				MessageBox.Show("Пользователь был зарегистрирован!");
				this.Close();
			}

		}

		public bool isCheckUserEmailExist(string emailUser)
		{
			MyDbContext db = new MyDbContext();
			var dbUsers = db.Users;
			var addUser = dbUsers.FirstOrDefault(user => user.Email == emailUser);
			if (addUser == null)
			{
				return true;
			} else
			{
				return false;
			}
		}

		public void FillComboBox()
		{
			MyDbContext db = new MyDbContext();

			var dbOffices = db.Offices;

			comboBoxOffices.Items.Add("All offices");

			foreach (var office in dbOffices)
			{
				comboBoxOffices.Items.Add(office.Title);
			}
		}

	}
}
