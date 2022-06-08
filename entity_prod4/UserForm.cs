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
	public partial class UserForm : Form
	{
		public int CurrentUserId;
		public int CurrentTimer;
		public int BeginCurrentTimer;

		// для сохранения по id log'a
		public int CurrentSessionId;
		public UserForm(int idCurrentUser)
		{
			InitializeComponent();

			MyDbContext db = new MyDbContext();

			var currenDate = DateTime.Now.ToShortDateString();
			var currenLoginTime = DateTime.Now.ToShortTimeString();

			// получили id авторизованного пользователя
			CurrentUserId = idCurrentUser;

			labelWelcome.Text = "Добро пожаловать в систему " + db.Users.FirstOrDefault(user => user.ID == idCurrentUser).Firstname + " !";

			timerSpentUser.Start();

			CurrentTimer = TotalTimer(idCurrentUser);
			BeginCurrentTimer = CurrentTimer;

			TimeSpan totalTime = TimeSpan.FromSeconds(CurrentTimer);
			labelTimeSpent.Text = string.Format("Потраченное время в системе: {0:D2}:{1:D2}:{2:D2}",
				totalTime.Hours, totalTime.Minutes, totalTime.Seconds);

			FillUserTable();

			Log log = new Log
			{
				Date = currenDate,
				LoginTime = currenLoginTime,
				IsCrash = true,
				UserID = idCurrentUser,
			};
			db.Logs.Add(log);
			db.SaveChanges();
			CurrentSessionId = log.ID;

			var dbLogs = db.Logs.ToList();
			var currentLogs = dbLogs.Where(error => error.UserID == CurrentUserId && error.IsCrash == true).ToList();
			labelCrashes.Text = "Количество сбоев: " + (currentLogs.Count()-1);

		}

		public void checkCrashedSession()
		{

		}

		public int TotalTimer(int idCurrentUser)
		{
			MyDbContext db = new MyDbContext();

			var dbLogs = db.Logs.ToList();
			var currentLogs = dbLogs.Where(log => log.UserID == CurrentUserId).ToList();
			int totalTime = 0;

			foreach (var log in currentLogs)
			{
				totalTime = totalTime + log.TimeSpent;
			}
			return totalTime;
		}

		public void FillUserTable()
		{
			MyDbContext db = new MyDbContext();

			DataTable table = new DataTable();

			table.Columns.Add("Дата", typeof(string));
			table.Columns.Add("Время входа", typeof(string));
			table.Columns.Add("Время выхода", typeof(string));
			table.Columns.Add("Время в системе", typeof(string));
			table.Columns.Add("Причина отказа", typeof(string));

			var dbLogs = db.Logs.ToList();

			var currentLogs = dbLogs.Where(log => log.UserID == CurrentUserId).ToList();

			foreach (var log in currentLogs)
			{
				table.Rows.Add(log.Date, log.LoginTime, log.LogoutTime, log.TimeSpent, log.Reason);
			}

			dataGridView1.DataSource = table;
		}

		private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			MyDbContext db = new MyDbContext();
			var dbLogs = db.Logs;

			var currentLog = dbLogs.FirstOrDefault(log => log.ID == CurrentSessionId);
			currentLog.LogoutTime = DateTime.Now.ToShortTimeString();
			currentLog.IsCrash = false;
			currentLog.TimeSpent = CurrentTimer - BeginCurrentTimer;
			db.SaveChanges();

		}

		private void timerSpentUser_Tick(object sender, EventArgs e)
		{
			CurrentTimer++;
			TimeSpan totalTime = TimeSpan.FromSeconds(CurrentTimer);
			labelTimeSpent.Text = string.Format("Потраченное время в системе: {0:D2}:{1:D2}:{2:D2}",
				totalTime.Hours, totalTime.Minutes, totalTime.Seconds) ;
		}

		public void AddColor()
		{
			using (var db = new MyDbContext())
			{
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					string strock = dataGridView1.Rows[i].Cells[2].Value.ToString();
					if (strock == "")
					{
						dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
					}

				}
			}
		}

		bool isPainted = false;
		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			if (!isPainted)
			{
				isPainted = true;
				AddColor();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

		}
	}
}
