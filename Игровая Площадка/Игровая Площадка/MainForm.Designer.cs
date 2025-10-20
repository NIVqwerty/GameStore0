namespace Игровая_Площадка
{
    partial class MainForm
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
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.DevelopComboBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PlatforComboBox = new System.Windows.Forms.ComboBox();
            this.RegimComboBox = new System.Windows.Forms.ComboBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AuthPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AuthPanel.Controls.Add(this.SelectedButton);
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.PassTextBox);
            this.AuthPanel.Controls.Add(this.label7);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.EnterButton);
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AdminPanelButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1022, 62);
            this.AuthPanel.TabIndex = 0;
            this.AuthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AuthPanel_Paint);
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SelectedButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectedButton.Location = new System.Drawing.Point(690, 12);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(150, 40);
            this.SelectedButton.TabIndex = 1;
            this.SelectedButton.Text = "Избранное";
            this.SelectedButton.UseVisualStyleBackColor = false;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пароль";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(277, 21);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(204, 25);
            this.PassTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(67, 23);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(201, 25);
            this.LoginTextBox.TabIndex = 7;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EnterButton.Location = new System.Drawing.Point(843, 12);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(176, 40);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Вход";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RegButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegButton.Location = new System.Drawing.Point(690, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(150, 40);
            this.RegButton.TabIndex = 0;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(12, 26);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(150, 18);
            this.HelloLabel.TabIndex = 11;
            this.HelloLabel.Text = "Добро пожаловать,";
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AdminPanelButton.Location = new System.Drawing.Point(690, 12);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(150, 40);
            this.AdminPanelButton.TabIndex = 12;
            this.AdminPanelButton.Text = "Админ Панель";
            this.AdminPanelButton.UseVisualStyleBackColor = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Navy;
            this.SearchPanel.Controls.Add(this.DevelopComboBox);
            this.SearchPanel.Controls.Add(this.FindButton);
            this.SearchPanel.Controls.Add(this.HideButton);
            this.SearchPanel.Controls.Add(this.label6);
            this.SearchPanel.Controls.Add(this.PlatforComboBox);
            this.SearchPanel.Controls.Add(this.RegimComboBox);
            this.SearchPanel.Controls.Add(this.GenreComboBox);
            this.SearchPanel.Controls.Add(this.label4);
            this.SearchPanel.Controls.Add(this.label3);
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 62);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1022, 151);
            this.SearchPanel.TabIndex = 1;
            // 
            // DevelopComboBox
            // 
            this.DevelopComboBox.Location = new System.Drawing.Point(864, 122);
            this.DevelopComboBox.Name = "DevelopComboBox";
            this.DevelopComboBox.Size = new System.Drawing.Size(155, 25);
            this.DevelopComboBox.TabIndex = 11;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(511, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(91, 24);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HideButton.Location = new System.Drawing.Point(895, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(124, 27);
            this.HideButton.TabIndex = 10;
            this.HideButton.Text = "Развернуть";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Поиск";
            // 
            // PlatforComboBox
            // 
            this.PlatforComboBox.FormattingEnabled = true;
            this.PlatforComboBox.Items.AddRange(new object[] {
            "",
            "Консоль",
            "ПК",
            "Кроссплатформер"});
            this.PlatforComboBox.Location = new System.Drawing.Point(864, 79);
            this.PlatforComboBox.Name = "PlatforComboBox";
            this.PlatforComboBox.Size = new System.Drawing.Size(157, 26);
            this.PlatforComboBox.TabIndex = 7;
            this.PlatforComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // RegimComboBox
            // 
            this.RegimComboBox.FormattingEnabled = true;
            this.RegimComboBox.Items.AddRange(new object[] {
            "",
            "Одиночная",
            "Многопользовательская"});
            this.RegimComboBox.Location = new System.Drawing.Point(612, 118);
            this.RegimComboBox.Name = "RegimComboBox";
            this.RegimComboBox.Size = new System.Drawing.Size(137, 26);
            this.RegimComboBox.TabIndex = 6;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "",
            "Выживание",
            "Файтинг",
            "Экшен",
            "Шутер",
            "Хоррор",
            "Стратегия",
            "Автосимулятор"});
            this.GenreComboBox.Location = new System.Drawing.Point(614, 79);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(135, 26);
            this.GenreComboBox.TabIndex = 5;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Разработчик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Платформа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Режим Игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Жанр";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(693, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(173, 25);
            this.SearchTextBox.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 213);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1022, 386);
            this.InfoPanel.TabIndex = 2;
            this.InfoPanel.Resize += new System.EventHandler(this.InfoPanel_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 599);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Игровая Площадка";
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox PlatforComboBox;
        private System.Windows.Forms.ComboBox RegimComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button FindButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AdminPanelButton;
        private System.Windows.Forms.TextBox DevelopComboBox;
        private System.Windows.Forms.Button SelectedButton;
    }
}

