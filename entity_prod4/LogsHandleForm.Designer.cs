namespace entity_prod4
{
	partial class LogsHandleForm
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
			this.labelCrashInfo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.radioBtnSoftCrash = new System.Windows.Forms.RadioButton();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.textBoxReason = new System.Windows.Forms.TextBox();
			this.radioBtnSystCrash = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// labelCrashInfo
			// 
			this.labelCrashInfo.AutoSize = true;
			this.labelCrashInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCrashInfo.Location = new System.Drawing.Point(31, 44);
			this.labelCrashInfo.Name = "labelCrashInfo";
			this.labelCrashInfo.Size = new System.Drawing.Size(439, 29);
			this.labelCrashInfo.TabIndex = 17;
			this.labelCrashInfo.Text = "No logout detected for your last login on";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(31, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 29);
			this.label1.TabIndex = 18;
			this.label1.Text = "Reason:";
			// 
			// radioBtnSoftCrash
			// 
			this.radioBtnSoftCrash.AutoSize = true;
			this.radioBtnSoftCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioBtnSoftCrash.Location = new System.Drawing.Point(36, 574);
			this.radioBtnSoftCrash.Name = "radioBtnSoftCrash";
			this.radioBtnSoftCrash.Size = new System.Drawing.Size(229, 36);
			this.radioBtnSoftCrash.TabIndex = 33;
			this.radioBtnSoftCrash.TabStop = true;
			this.radioBtnSoftCrash.Text = "Software Crash";
			this.radioBtnSoftCrash.UseVisualStyleBackColor = true;
			// 
			// btnConfirm
			// 
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnConfirm.Location = new System.Drawing.Point(599, 562);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(275, 61);
			this.btnConfirm.TabIndex = 32;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// textBoxReason
			// 
			this.textBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxReason.Location = new System.Drawing.Point(36, 155);
			this.textBoxReason.Multiline = true;
			this.textBoxReason.Name = "textBoxReason";
			this.textBoxReason.Size = new System.Drawing.Size(838, 368);
			this.textBoxReason.TabIndex = 31;
			// 
			// radioBtnSystCrash
			// 
			this.radioBtnSystCrash.AutoSize = true;
			this.radioBtnSystCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioBtnSystCrash.Location = new System.Drawing.Point(326, 574);
			this.radioBtnSystCrash.Name = "radioBtnSystCrash";
			this.radioBtnSystCrash.Size = new System.Drawing.Size(211, 36);
			this.radioBtnSystCrash.TabIndex = 34;
			this.radioBtnSystCrash.TabStop = true;
			this.radioBtnSystCrash.Text = "System Crash";
			this.radioBtnSystCrash.UseVisualStyleBackColor = true;
			// 
			// LogsHandleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 678);
			this.Controls.Add(this.radioBtnSystCrash);
			this.Controls.Add(this.radioBtnSoftCrash);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.textBoxReason);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelCrashInfo);
			this.Name = "LogsHandleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "No logout detected";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCrashInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioBtnSoftCrash;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.TextBox textBoxReason;
		private System.Windows.Forms.RadioButton radioBtnSystCrash;
	}
}