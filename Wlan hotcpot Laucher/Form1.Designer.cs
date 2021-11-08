namespace Wlan_hotcpot_Laucher
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lSsid = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.ValuePass = new System.Windows.Forms.Label();
            this.textBoxSsid = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Restart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btStaring = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.lPicSize = new System.Windows.Forms.Label();
            this.tbPathFile = new System.Windows.Forms.TextBox();
            this.lScreen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lSsid
            // 
            this.lSsid.AutoSize = true;
            this.lSsid.Location = new System.Drawing.Point(10, 16);
            this.lSsid.Name = "lSsid";
            this.lSsid.Size = new System.Drawing.Size(30, 13);
            this.lSsid.TabIndex = 0;
            this.lSsid.Text = "Ssid:";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(9, 41);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(48, 13);
            this.lPass.TabIndex = 1;
            this.lPass.Text = "Пароль:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(63, 38);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(175, 20);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // ValuePass
            // 
            this.ValuePass.AutoSize = true;
            this.ValuePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuePass.Location = new System.Drawing.Point(250, 38);
            this.ValuePass.Name = "ValuePass";
            this.ValuePass.Size = new System.Drawing.Size(19, 20);
            this.ValuePass.TabIndex = 3;
            this.ValuePass.Text = "0";
            // 
            // textBoxSsid
            // 
            this.textBoxSsid.Location = new System.Drawing.Point(63, 13);
            this.textBoxSsid.Name = "textBoxSsid";
            this.textBoxSsid.Size = new System.Drawing.Size(175, 20);
            this.textBoxSsid.TabIndex = 4;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(193, 178);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(107, 178);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(80, 23);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Перезапуск";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 235);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxPass);
            this.tabPage1.Controls.Add(this.Restart);
            this.tabPage1.Controls.Add(this.lSsid);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.lPass);
            this.tabPage1.Controls.Add(this.ValuePass);
            this.tabPage1.Controls.Add(this.textBoxSsid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Whp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbImage);
            this.tabPage2.Controls.Add(this.btStaring);
            this.tabPage2.Controls.Add(this.btView);
            this.tabPage2.Controls.Add(this.lPicSize);
            this.tabPage2.Controls.Add(this.tbPathFile);
            this.tabPage2.Controls.Add(this.lScreen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Win7 Custom";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 67);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(164, 74);
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // btStaring
            // 
            this.btStaring.Location = new System.Drawing.Point(192, 178);
            this.btStaring.Name = "btStaring";
            this.btStaring.Size = new System.Drawing.Size(75, 23);
            this.btStaring.TabIndex = 4;
            this.btStaring.Text = "Старт";
            this.btStaring.UseVisualStyleBackColor = true;
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(193, 22);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 3;
            this.btView.Text = "Обзор";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // lPicSize
            // 
            this.lPicSize.AutoSize = true;
            this.lPicSize.Location = new System.Drawing.Point(9, 47);
            this.lPicSize.Name = "lPicSize";
            this.lPicSize.Size = new System.Drawing.Size(126, 13);
            this.lPicSize.TabIndex = 2;
            this.lPicSize.Text = "Разрешение картинки: ";
            // 
            // tbPathFile
            // 
            this.tbPathFile.Location = new System.Drawing.Point(12, 24);
            this.tbPathFile.Name = "tbPathFile";
            this.tbPathFile.Size = new System.Drawing.Size(175, 20);
            this.tbPathFile.TabIndex = 1;
            // 
            // lScreen
            // 
            this.lScreen.AutoSize = true;
            this.lScreen.Location = new System.Drawing.Point(9, 7);
            this.lScreen.Name = "lScreen";
            this.lScreen.Size = new System.Drawing.Size(115, 13);
            this.lScreen.TabIndex = 0;
            this.lScreen.Text = "Разрешение экрана: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "WH-P";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSsid;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label ValuePass;
        private System.Windows.Forms.TextBox textBoxSsid;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btStaring;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Label lPicSize;
        private System.Windows.Forms.TextBox tbPathFile;
        private System.Windows.Forms.Label lScreen;
    }
}

