namespace Basketball
{
	partial class LogForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.judgeRadioButton = new System.Windows.Forms.RadioButton();
			this.playerRadioButton = new System.Windows.Forms.RadioButton();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.errorLabel = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.teamPanel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.compComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.teamTextBox = new System.Windows.Forms.TextBox();
			this.playerPanel = new System.Windows.Forms.Panel();
			this.backButton = new System.Windows.Forms.Button();
			this.requestButton = new System.Windows.Forms.Button();
			this.PlayerTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.teamPanel.SuspendLayout();
			this.playerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// judgeRadioButton
			// 
			this.judgeRadioButton.AutoSize = true;
			this.judgeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.judgeRadioButton.Location = new System.Drawing.Point(331, 209);
			this.judgeRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.judgeRadioButton.Name = "judgeRadioButton";
			this.judgeRadioButton.Size = new System.Drawing.Size(74, 24);
			this.judgeRadioButton.TabIndex = 5;
			this.judgeRadioButton.TabStop = true;
			this.judgeRadioButton.Text = "Судья";
			this.judgeRadioButton.UseVisualStyleBackColor = true;
			// 
			// playerRadioButton
			// 
			this.playerRadioButton.AutoSize = true;
			this.playerRadioButton.Checked = true;
			this.playerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.playerRadioButton.Location = new System.Drawing.Point(184, 209);
			this.playerRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.playerRadioButton.Name = "playerRadioButton";
			this.playerRadioButton.Size = new System.Drawing.Size(71, 24);
			this.playerRadioButton.TabIndex = 4;
			this.playerRadioButton.TabStop = true;
			this.playerRadioButton.Text = "Игрок";
			this.playerRadioButton.UseVisualStyleBackColor = true;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.Location = new System.Drawing.Point(184, 179);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(221, 26);
			this.passwordTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(181, 157);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Пароль";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginTextBox.Location = new System.Drawing.Point(184, 129);
			this.loginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(221, 26);
			this.loginTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(181, 107);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Логин";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(8, 7);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(605, 423);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.errorLabel);
			this.tabPage1.Controls.Add(this.LoginButton);
			this.tabPage1.Controls.Add(this.judgeRadioButton);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.playerRadioButton);
			this.tabPage1.Controls.Add(this.loginTextBox);
			this.tabPage1.Controls.Add(this.passwordTextBox);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new System.Drawing.Size(597, 394);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Вход";
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(181, 67);
			this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(225, 20);
			this.errorLabel.TabIndex = 7;
			this.errorLabel.Text = "Неверный логин или пароль";
			this.errorLabel.Visible = false;
			// 
			// LoginButton
			// 
			this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginButton.Location = new System.Drawing.Point(221, 237);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(138, 30);
			this.LoginButton.TabIndex = 6;
			this.LoginButton.Text = "Вход";
			this.LoginButton.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.teamPanel);
			this.tabPage2.Controls.Add(this.playerPanel);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Size = new System.Drawing.Size(597, 394);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Заявка";
			// 
			// teamPanel
			// 
			this.teamPanel.Controls.Add(this.label5);
			this.teamPanel.Controls.Add(this.compComboBox);
			this.teamPanel.Controls.Add(this.label3);
			this.teamPanel.Controls.Add(this.nextButton);
			this.teamPanel.Controls.Add(this.label4);
			this.teamPanel.Controls.Add(this.countryTextBox);
			this.teamPanel.Controls.Add(this.teamTextBox);
			this.teamPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.teamPanel.Location = new System.Drawing.Point(0, 0);
			this.teamPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.teamPanel.Name = "teamPanel";
			this.teamPanel.Size = new System.Drawing.Size(601, 394);
			this.teamPanel.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(132, 85);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Соревнование";
			// 
			// compComboBox
			// 
			this.compComboBox.FormattingEnabled = true;
			this.compComboBox.Location = new System.Drawing.Point(136, 107);
			this.compComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.compComboBox.Name = "compComboBox";
			this.compComboBox.Size = new System.Drawing.Size(318, 28);
			this.compComboBox.TabIndex = 8;
			this.compComboBox.SelectedIndexChanged += new System.EventHandler(this.CompComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 137);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Команда";
			// 
			// nextButton
			// 
			this.nextButton.Enabled = false;
			this.nextButton.Location = new System.Drawing.Point(199, 239);
			this.nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(193, 35);
			this.nextButton.TabIndex = 7;
			this.nextButton.Text = "Далее";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(132, 187);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Страна";
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(136, 209);
			this.countryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(318, 26);
			this.countryTextBox.TabIndex = 5;
			this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
			// 
			// teamTextBox
			// 
			this.teamTextBox.Location = new System.Drawing.Point(136, 159);
			this.teamTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.teamTextBox.Name = "teamTextBox";
			this.teamTextBox.Size = new System.Drawing.Size(318, 26);
			this.teamTextBox.TabIndex = 4;
			this.teamTextBox.TextChanged += new System.EventHandler(this.TeamTextBox_TextChanged);
			// 
			// playerPanel
			// 
			this.playerPanel.Controls.Add(this.backButton);
			this.playerPanel.Controls.Add(this.requestButton);
			this.playerPanel.Controls.Add(this.PlayerTextBox);
			this.playerPanel.Controls.Add(this.label6);
			this.playerPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.playerPanel.Location = new System.Drawing.Point(-1, 0);
			this.playerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.playerPanel.Name = "playerPanel";
			this.playerPanel.Size = new System.Drawing.Size(600, 398);
			this.playerPanel.TabIndex = 9;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(52, 336);
			this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(157, 37);
			this.backButton.TabIndex = 9;
			this.backButton.Text = "Назад";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// requestButton
			// 
			this.requestButton.Location = new System.Drawing.Point(381, 336);
			this.requestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.requestButton.Name = "requestButton";
			this.requestButton.Size = new System.Drawing.Size(166, 37);
			this.requestButton.TabIndex = 8;
			this.requestButton.Text = "Подать заявку";
			this.requestButton.UseVisualStyleBackColor = true;
			this.requestButton.Click += new System.EventHandler(this.RequestButton_Click);
			// 
			// PlayerTextBox
			// 
			this.PlayerTextBox.Location = new System.Drawing.Point(52, 44);
			this.PlayerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PlayerTextBox.Multiline = true;
			this.PlayerTextBox.Name = "PlayerTextBox";
			this.PlayerTextBox.Size = new System.Drawing.Size(495, 288);
			this.PlayerTextBox.TabIndex = 1;
			this.PlayerTextBox.TextChanged += new System.EventHandler(this.PlayerTextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(162, 2);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(267, 40);
			this.label6.TabIndex = 0;
			this.label6.Text = "Введите Имя и Фамилию игроков\r\n(каждый игрок на новой строчке)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximumSize = new System.Drawing.Size(640, 480);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "LogForm";
			this.Text = "Basketball";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.teamPanel.ResumeLayout(false);
			this.teamPanel.PerformLayout();
			this.playerPanel.ResumeLayout(false);
			this.playerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton playerRadioButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton judgeRadioButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox compComboBox;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox teamTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel teamPanel;
		private System.Windows.Forms.Panel playerPanel;
		private System.Windows.Forms.TextBox PlayerTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button requestButton;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.Button backButton;
	}
}

