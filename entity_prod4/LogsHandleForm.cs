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
	public partial class LogsHandleForm : Form
	{
		public int lastLogCrashId;
		public LogsHandleForm(int logCrashID)
		{
			InitializeComponent();

			lastLogCrashId = logCrashID;

			MyDbContext db = new MyDbContext();
			var dbLogs = db.Logs;

			var lastCrash = dbLogs.FirstOrDefault(log => log.ID == lastLogCrashId);

			labelCrashInfo.Text = "No logout detected for your last login on " + lastCrash.Date + " at " + lastCrash.LoginTime;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			MyDbContext db = new MyDbContext();
			var dbLogs = db.Logs;

			var lastCrash = dbLogs.FirstOrDefault(log => log.ID == lastLogCrashId);

			if (radioBtnSoftCrash.Checked)
			{
				lastCrash.Reason = "Software Crash";
				db.SaveChanges();
				this.Close();
			}
			else if (radioBtnSystCrash.Checked)
			{
				lastCrash.Reason = "System Crash";
				db.SaveChanges();
				this.Close();
			}
			else if (textBoxReason.Text != "")
			{
				lastCrash.Reason = textBoxReason.Text;
				db.SaveChanges();
				this.Close();
			}
			else
			{
				MessageBox.Show("Введите причину ошибки в поле или выберите ошибку.");
			}
		}

	}
}
