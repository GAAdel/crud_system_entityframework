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
	public partial class EditUserForm : Form
	{
		public string Email;
		public EditUserForm(string userEmail)
		{
			InitializeComponent();

			Email = userEmail;

			FillComboBox();

			MyDbContext db = new MyDbContext();

			var users = db.Users.ToList();
			var offices = db.Offices.ToList();

			var chosenUser = users.FirstOrDefault(user => user.Email == userEmail);

			textBoxEmail.Text = chosenUser.Email;
			textBoxName.Text = chosenUser.Firstname;
			textBoxSurname.Text = chosenUser.Lastname;

			var userOfficeName = offices.FirstOrDefault(office => office.ID == chosenUser.OfficeID).Title;
			comboBoxOffices.Text = userOfficeName;

			if (chosenUser.RoleID == 2)
			{
				radioBtnUser.Checked = true;
			}
			else if (chosenUser.RoleID == 1)
			{
				radioBtnAdministrator.Checked = true;
			}
		}

		private void btnEditUser_Click(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();

			string emailUser = textBoxEmail.Text;
			string firstNameUser = textBoxName.Text;
			string lastNameUser = textBoxSurname.Text;

			int roleUser = 1;

			if (radioBtnUser.Checked == true)
			{
				roleUser = 2;
			}
			else if (radioBtnAdministrator.Checked == true)
			{
				roleUser = 1;
			}

			var officeUser = db.Offices.FirstOrDefault(office => office.Title == comboBoxOffices.Text).ID;

			var currentUser = db.Users.FirstOrDefault(user => user.Email == Email);

			currentUser.Email = emailUser;
			currentUser.Firstname = firstNameUser;
			currentUser.Lastname = lastNameUser;
			currentUser.OfficeID = officeUser;
			currentUser.RoleID = roleUser;

			//MessageBox.Show(emailUser + "\n" + firstNameUser + "\n" + lastNameUser + "\n" + officeUser + "\n" + roleUser);

			db.SaveChanges();
			this.Close();
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
