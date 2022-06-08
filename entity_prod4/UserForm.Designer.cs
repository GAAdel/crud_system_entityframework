namespace entity_prod4
{
	partial class UserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnClose = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.labelWelcome = new System.Windows.Forms.Label();
			this.labelTimeSpent = new System.Windows.Forms.Label();
			this.labelCrashes = new System.Windows.Forms.Label();
			this.timerSpentUser = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(924, 680);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(225, 60);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "Выйти";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(23, 193);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1126, 471);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWelcome.Location = new System.Drawing.Point(35, 26);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(156, 29);
			this.labelWelcome.TabIndex = 16;
			this.labelWelcome.Text = "Привествие:";
			// 
			// labelTimeSpent
			// 
			this.labelTimeSpent.AutoSize = true;
			this.labelTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTimeSpent.Location = new System.Drawing.Point(35, 78);
			this.labelTimeSpent.Name = "labelTimeSpent";
			this.labelTimeSpent.Size = new System.Drawing.Size(96, 29);
			this.labelTimeSpent.TabIndex = 17;
			this.labelTimeSpent.Text = "Время:";
			// 
			// labelCrashes
			// 
			this.labelCrashes.AutoSize = true;
			this.labelCrashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCrashes.Location = new System.Drawing.Point(35, 133);
			this.labelCrashes.Name = "labelCrashes";
			this.labelCrashes.Size = new System.Drawing.Size(78, 29);
			this.labelCrashes.TabIndex = 18;
			this.labelCrashes.Text = "Сбои:";
			// 
			// timerSpentUser
			// 
			this.timerSpentUser.Interval = 1000;
			this.timerSpentUser.Tick += new System.EventHandler(this.timerSpentUser_Tick);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 752);
			this.Controls.Add(this.labelCrashes);
			this.Controls.Add(this.labelTimeSpent);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мой профиль";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.Label labelTimeSpent;
		private System.Windows.Forms.Label labelCrashes;
		private System.Windows.Forms.Timer timerSpentUser;
	}
}