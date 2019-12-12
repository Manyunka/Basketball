namespace Basketball
{
	partial class TeamForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.homeListView = new System.Windows.Forms.ListView();
			this.compLabel = new System.Windows.Forms.Label();
			this.compComboBox = new System.Windows.Forms.ComboBox();
			this.countryLabel = new System.Windows.Forms.Label();
			this.teamLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.winnerListView = new System.Windows.Forms.ListView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.teamListView = new System.Windows.Forms.ListView();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.playerListView = new System.Windows.Forms.ListView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.scheduleListView = new System.Windows.Forms.ListView();
			this.requestTabPage = new System.Windows.Forms.TabPage();
			this.requestButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.requestComboBox = new System.Windows.Forms.ComboBox();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.requestTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage4);
			this.tabControl.Controls.Add(this.tabPage5);
			this.tabControl.Controls.Add(this.requestTabPage);
			this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(776, 426);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.homeListView);
			this.tabPage1.Controls.Add(this.compLabel);
			this.tabPage1.Controls.Add(this.compComboBox);
			this.tabPage1.Controls.Add(this.countryLabel);
			this.tabPage1.Controls.Add(this.teamLabel);
			this.tabPage1.Controls.Add(this.surnameLabel);
			this.tabPage1.Controls.Add(this.nameLabel);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 397);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Личная информация";
			// 
			// homeListView
			// 
			this.homeListView.HideSelection = false;
			this.homeListView.Location = new System.Drawing.Point(10, 86);
			this.homeListView.Name = "homeListView";
			this.homeListView.Size = new System.Drawing.Size(752, 305);
			this.homeListView.TabIndex = 6;
			this.homeListView.UseCompatibleStateImageBehavior = false;
			// 
			// compLabel
			// 
			this.compLabel.AutoSize = true;
			this.compLabel.Location = new System.Drawing.Point(643, 3);
			this.compLabel.Name = "compLabel";
			this.compLabel.Size = new System.Drawing.Size(119, 20);
			this.compLabel.TabIndex = 5;
			this.compLabel.Text = "Соревнование";
			// 
			// compComboBox
			// 
			this.compComboBox.FormattingEnabled = true;
			this.compComboBox.Location = new System.Drawing.Point(407, 26);
			this.compComboBox.Name = "compComboBox";
			this.compComboBox.Size = new System.Drawing.Size(355, 28);
			this.compComboBox.TabIndex = 4;
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(6, 63);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(69, 20);
			this.countryLabel.TabIndex = 3;
			this.countryLabel.Text = "Страна:";
			// 
			// teamLabel
			// 
			this.teamLabel.AutoSize = true;
			this.teamLabel.Location = new System.Drawing.Point(6, 43);
			this.teamLabel.Name = "teamLabel";
			this.teamLabel.Size = new System.Drawing.Size(81, 20);
			this.teamLabel.TabIndex = 2;
			this.teamLabel.Text = "Команда:";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(3, 23);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(85, 20);
			this.surnameLabel.TabIndex = 1;
			this.surnameLabel.Text = "Фамилия:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(6, 3);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(44, 20);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Имя:";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.winnerListView);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 397);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Победители";
			// 
			// winnerListView
			// 
			this.winnerListView.HideSelection = false;
			this.winnerListView.Location = new System.Drawing.Point(8, 6);
			this.winnerListView.Name = "winnerListView";
			this.winnerListView.Size = new System.Drawing.Size(752, 385);
			this.winnerListView.TabIndex = 7;
			this.winnerListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.teamListView);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(768, 397);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Рейтинг команд";
			// 
			// teamListView
			// 
			this.teamListView.HideSelection = false;
			this.teamListView.Location = new System.Drawing.Point(8, 6);
			this.teamListView.Name = "teamListView";
			this.teamListView.Size = new System.Drawing.Size(752, 385);
			this.teamListView.TabIndex = 8;
			this.teamListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage4.Controls.Add(this.playerListView);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(768, 397);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Рейтинг игроков";
			// 
			// playerListView
			// 
			this.playerListView.HideSelection = false;
			this.playerListView.Location = new System.Drawing.Point(8, 6);
			this.playerListView.Name = "playerListView";
			this.playerListView.Size = new System.Drawing.Size(752, 385);
			this.playerListView.TabIndex = 8;
			this.playerListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage5
			// 
			this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage5.Controls.Add(this.scheduleListView);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(768, 397);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Расписание";
			// 
			// scheduleListView
			// 
			this.scheduleListView.HideSelection = false;
			this.scheduleListView.Location = new System.Drawing.Point(8, 6);
			this.scheduleListView.Name = "scheduleListView";
			this.scheduleListView.Size = new System.Drawing.Size(752, 385);
			this.scheduleListView.TabIndex = 9;
			this.scheduleListView.UseCompatibleStateImageBehavior = false;
			// 
			// requestTabPage
			// 
			this.requestTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.requestTabPage.Controls.Add(this.requestButton);
			this.requestTabPage.Controls.Add(this.label1);
			this.requestTabPage.Controls.Add(this.requestComboBox);
			this.requestTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.requestTabPage.Location = new System.Drawing.Point(4, 25);
			this.requestTabPage.Name = "requestTabPage";
			this.requestTabPage.Size = new System.Drawing.Size(768, 397);
			this.requestTabPage.TabIndex = 5;
			this.requestTabPage.Text = "Подать заявку";
			// 
			// requestButton
			// 
			this.requestButton.Location = new System.Drawing.Point(281, 174);
			this.requestButton.Name = "requestButton";
			this.requestButton.Size = new System.Drawing.Size(227, 38);
			this.requestButton.TabIndex = 2;
			this.requestButton.Text = "Подать заявку";
			this.requestButton.UseVisualStyleBackColor = true;
			this.requestButton.Click += new System.EventHandler(this.RequestButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(177, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Соревнование";
			// 
			// requestComboBox
			// 
			this.requestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.requestComboBox.FormattingEnabled = true;
			this.requestComboBox.Location = new System.Drawing.Point(181, 140);
			this.requestComboBox.Name = "requestComboBox";
			this.requestComboBox.Size = new System.Drawing.Size(452, 28);
			this.requestComboBox.TabIndex = 0;
			// 
			// TeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "TeamForm";
			this.Text = "Кабинет игрока";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.requestTabPage.ResumeLayout(false);
			this.requestTabPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label compLabel;
		private System.Windows.Forms.ComboBox compComboBox;
		private System.Windows.Forms.Label countryLabel;
		private System.Windows.Forms.Label teamLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ListView homeListView;
		private System.Windows.Forms.ListView winnerListView;
		private System.Windows.Forms.ListView teamListView;
		private System.Windows.Forms.ListView playerListView;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.ListView scheduleListView;
		private System.Windows.Forms.TabPage requestTabPage;
		private System.Windows.Forms.Button requestButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox requestComboBox;
	}
}