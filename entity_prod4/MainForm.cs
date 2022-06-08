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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			FillComboBox();
			FillDataGrid();
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

		public void FillDataGrid()
		{
			MyDbContext db = new MyDbContext();

			DataTable table = new DataTable();

			table.Columns.Add("Имя", typeof(string));
			table.Columns.Add("Фамилия", typeof(string));
			table.Columns.Add("Возраст", typeof(string));
			table.Columns.Add("Роль", typeof(string));
			table.Columns.Add("Email", typeof(string));
			table.Columns.Add("Офис", typeof(string));

			var dbUsers = db.Users.ToList();
			var dbRoles = db.Roles.ToList();
			var dbOffices = db.Offices.ToList();

			foreach (var user in dbUsers)
			{
				var userAge = DateTime.Now.Year - user.Birthdate.Year;
				var userRole = dbRoles.FirstOrDefault(role => role.ID == user.RoleID).Title;
				var userOfficeName = dbOffices.FirstOrDefault(office => office.ID == user.OfficeID).Title;
				table.Rows.Add(user.Firstname, user.Lastname, userAge, userRole, user.Email, userOfficeName);
			}

			dataGridView1.DataSource = table;
			drawUsersTable();

		}

		private void comboBoxOffices_SelectedIndexChanged(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();

			string selectedOffice = comboBoxOffices.SelectedItem.ToString();

			if (selectedOffice == "All offices")
			{
				FillDataGrid();
				return;
			}

			var dbUsers = db.Users.ToList();
			var dbRoles = db.Roles.ToList();
			var dbOffices = db.Offices.ToList();

			var chosenOfficeID = dbOffices.FirstOrDefault(office => office.Title == selectedOffice).ID;

			DataTable table = new DataTable();

			table.Columns.Add("Имя", typeof(string));
			table.Columns.Add("Фамилия", typeof(string));
			table.Columns.Add("Возраст", typeof(string));
			table.Columns.Add("Роль", typeof(string));
			table.Columns.Add("Email", typeof(string));
			table.Columns.Add("Офис", typeof(string));

			var choosenOfficeUsers = dbUsers.Where(user => user.OfficeID == chosenOfficeID);

			foreach (var user in choosenOfficeUsers)
			{
				var userAge = DateTime.Now.Year - user.Birthdate.Year;
				var userRole = dbRoles.FirstOrDefault(role => role.ID == user.RoleID).Title;
				var userOfficeName = dbOffices.FirstOrDefault(office => office.ID == user.OfficeID).Title;
				table.Rows.Add(user.Firstname, user.Lastname, userAge, userRole, user.Email, userOfficeName);
			}
			dataGridView1.DataSource = table;
			drawUsersTable();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			AddUserForm form = new AddUserForm();
			form.ShowDialog();
		}

		private void btnEditUser_Click(object sender, EventArgs e)
		{
			EditUserForm form = new EditUserForm(dataGridView1.CurrentRow.Cells["Email"].Value.ToString());
			form.ShowDialog();
		}

		private void btnChaneUserStatus_Click(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();
			var dbUsers = db.Users;

			var userEmail = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();

			var chosenUser = dbUsers.FirstOrDefault(user => user.Email == userEmail);
			if (chosenUser.Active == true)
			{
				chosenUser.Active = false;
				MessageBox.Show("Пользователь " + userEmail + " был заблокирован!");
			}
			else
			{
				chosenUser.Active = true;
				MessageBox.Show("Пользователь " + userEmail + " был разблокирован!");
			}
			db.SaveChanges();
			FillDataGrid();
		}

		public void drawUsersTable()
		{
			using (var db = new MyDbContext())
			{
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					string elem = dataGridView1.Rows[i].Cells[3].Value.ToString();
					if (elem == "Administrator")
					{
						dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
					}

					string currentUser = dataGridView1.Rows[i].Cells[4].Value.ToString();

					var isActive = db.Users.FirstOrDefault(user => user.Email == currentUser).Active;

					if (isActive == false)
					{
						dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
					}
				}
			}
		}

		private void btnUpdateData_Click(object sender, EventArgs e)
		{
			FillDataGrid();
		}

		bool isShow = false;
		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			if (!isShow)
			{
				isShow = true;
				drawUsersTable();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Вы уверены, что хотите выйти?",
				"Сообщение",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1,
				MessageBoxOptions.DefaultDesktopOnly);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
