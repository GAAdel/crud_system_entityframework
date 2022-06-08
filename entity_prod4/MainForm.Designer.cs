namespace entity_prod4
{
	partial class MainForm
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
			this.btnAddUser = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxOffices = new System.Windows.Forms.ComboBox();
			this.btnEditUser = new System.Windows.Forms.Button();
			this.btnChaneUserStatus = new System.Windows.Forms.Button();
			this.btnUpdateData = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddUser
			// 
			this.btnAddUser.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddUser.Location = new System.Drawing.Point(43, 603);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(225, 60);
			this.btnAddUser.TabIndex = 6;
			this.btnAddUser.Text = "Добавить";
			this.btnAddUser.UseVisualStyleBackColor = false;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 108);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1126, 471);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(712, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "Выбрать офис:";
			// 
			// comboBoxOffices
			// 
			this.comboBoxOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxOffices.FormattingEnabled = true;
			this.comboBoxOffices.Location = new System.Drawing.Point(944, 34);
			this.comboBoxOffices.Name = "comboBoxOffices";
			this.comboBoxOffices.Size = new System.Drawing.Size(219, 39);
			this.comboBoxOffices.TabIndex = 9;
			this.comboBoxOffices.Text = "All offices";
			this.comboBoxOffices.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffices_SelectedIndexChanged);
			// 
			// btnEditUser
			// 
			this.btnEditUser.BackColor = System.Drawing.Color.Gold;
			this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditUser.Location = new System.Drawing.Point(331, 603);
			this.btnEditUser.Name = "btnEditUser";
			this.btnEditUser.Size = new System.Drawing.Size(249, 60);
			this.btnEditUser.TabIndex = 10;
			this.btnEditUser.Text = "Редактировать";
			this.btnEditUser.UseVisualStyleBackColor = false;
			this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
			// 
			// btnChaneUserStatus
			// 
			this.btnChaneUserStatus.BackColor = System.Drawing.Color.LightGray;
			this.btnChaneUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChaneUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChaneUserStatus.Location = new System.Drawing.Point(642, 603);
			this.btnChaneUserStatus.Name = "btnChaneUserStatus";
			this.btnChaneUserStatus.Size = new System.Drawing.Size(237, 60);
			this.btnChaneUserStatus.TabIndex = 11;
			this.btnChaneUserStatus.Text = "Изменить статус";
			this.btnChaneUserStatus.UseVisualStyleBackColor = false;
			this.btnChaneUserStatus.Click += new System.EventHandler(this.btnChaneUserStatus_Click);
			// 
			// btnUpdateData
			// 
			this.btnUpdateData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUpdateData.Location = new System.Drawing.Point(932, 603);
			this.btnUpdateData.Name = "btnUpdateData";
			this.btnUpdateData.Size = new System.Drawing.Size(237, 60);
			this.btnUpdateData.TabIndex = 12;
			this.btnUpdateData.Text = "Обновить данные";
			this.btnUpdateData.UseVisualStyleBackColor = false;
			this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(43, 24);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(225, 60);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1225, 689);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdateData);
			this.Controls.Add(this.btnChaneUserStatus);
			this.Controls.Add(this.btnEditUser);
			this.Controls.Add(this.comboBoxOffices);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAddUser);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учет пользователей";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxOffices;
		private System.Windows.Forms.Button btnEditUser;
		private System.Windows.Forms.Button btnChaneUserStatus;
		private System.Windows.Forms.Button btnUpdateData;
		private System.Windows.Forms.Button btnClose;
	}
}