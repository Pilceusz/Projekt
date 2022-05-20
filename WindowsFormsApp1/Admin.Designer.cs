namespace WindowsFormsApp1
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.podsumowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaKredytowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAktualnychDłużnikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UsersFounds = new System.Windows.Forms.ListBox();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LastNameInsTxt = new System.Windows.Forms.TextBox();
            this.EmailAddressInsTxt = new System.Windows.Forms.TextBox();
            this.LoginInsTxt = new System.Windows.Forms.TextBox();
            this.FirstNameInsTxt = new System.Windows.Forms.TextBox();
            this.FirstNameIns = new System.Windows.Forms.Label();
            this.LastNameIns = new System.Windows.Forms.Label();
            this.EmailAddressIns = new System.Windows.Forms.Label();
            this.LoginIns = new System.Windows.Forms.Label();
            this.PasswordInsTxt = new System.Windows.Forms.TextBox();
            this.PasswordIns = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.AdminLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podsumowanieToolStripMenuItem,
            this.historiaKredytowaToolStripMenuItem,
            this.listaAktualnychDłużnikówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podsumowanieToolStripMenuItem
            // 
            this.podsumowanieToolStripMenuItem.Name = "podsumowanieToolStripMenuItem";
            this.podsumowanieToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.podsumowanieToolStripMenuItem.Text = "Podsumowanie";
            // 
            // historiaKredytowaToolStripMenuItem
            // 
            this.historiaKredytowaToolStripMenuItem.Name = "historiaKredytowaToolStripMenuItem";
            this.historiaKredytowaToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.historiaKredytowaToolStripMenuItem.Text = "Historia kredytowa";
            this.historiaKredytowaToolStripMenuItem.Click += new System.EventHandler(this.historiaKredytowaToolStripMenuItem_Click);
            // 
            // listaAktualnychDłużnikówToolStripMenuItem
            // 
            this.listaAktualnychDłużnikówToolStripMenuItem.Name = "listaAktualnychDłużnikówToolStripMenuItem";
            this.listaAktualnychDłużnikówToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.listaAktualnychDłużnikówToolStripMenuItem.Text = "Lista aktualnych dłużników";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UsersFounds
            // 
            this.UsersFounds.FormattingEnabled = true;
            this.UsersFounds.ItemHeight = 16;
            this.UsersFounds.Location = new System.Drawing.Point(12, 40);
            this.UsersFounds.Name = "UsersFounds";
            this.UsersFounds.Size = new System.Drawing.Size(524, 180);
            this.UsersFounds.TabIndex = 4;
            this.UsersFounds.SelectedIndexChanged += new System.EventHandler(this.UsersFounds_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(542, 40);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(68, 16);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Wyszukaj:";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(545, 76);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(182, 22);
            this.LastNameText.TabIndex = 6;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LastNameInsTxt
            // 
            this.LastNameInsTxt.Location = new System.Drawing.Point(89, 282);
            this.LastNameInsTxt.Name = "LastNameInsTxt";
            this.LastNameInsTxt.Size = new System.Drawing.Size(182, 22);
            this.LastNameInsTxt.TabIndex = 8;
            // 
            // EmailAddressInsTxt
            // 
            this.EmailAddressInsTxt.Location = new System.Drawing.Point(89, 327);
            this.EmailAddressInsTxt.Name = "EmailAddressInsTxt";
            this.EmailAddressInsTxt.Size = new System.Drawing.Size(182, 22);
            this.EmailAddressInsTxt.TabIndex = 9;
            this.EmailAddressInsTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginInsTxt
            // 
            this.LoginInsTxt.Location = new System.Drawing.Point(89, 364);
            this.LoginInsTxt.Name = "LoginInsTxt";
            this.LoginInsTxt.Size = new System.Drawing.Size(182, 22);
            this.LoginInsTxt.TabIndex = 10;
            // 
            // FirstNameInsTxt
            // 
            this.FirstNameInsTxt.Location = new System.Drawing.Point(89, 240);
            this.FirstNameInsTxt.Name = "FirstNameInsTxt";
            this.FirstNameInsTxt.Size = new System.Drawing.Size(182, 22);
            this.FirstNameInsTxt.TabIndex = 11;
            // 
            // FirstNameIns
            // 
            this.FirstNameIns.AutoSize = true;
            this.FirstNameIns.Location = new System.Drawing.Point(12, 243);
            this.FirstNameIns.Name = "FirstNameIns";
            this.FirstNameIns.Size = new System.Drawing.Size(38, 16);
            this.FirstNameIns.TabIndex = 12;
            this.FirstNameIns.Text = "Imię :";
            // 
            // LastNameIns
            // 
            this.LastNameIns.AutoSize = true;
            this.LastNameIns.Location = new System.Drawing.Point(9, 285);
            this.LastNameIns.Name = "LastNameIns";
            this.LastNameIns.Size = new System.Drawing.Size(68, 16);
            this.LastNameIns.TabIndex = 13;
            this.LastNameIns.Text = "Nazwisko:";
            // 
            // EmailAddressIns
            // 
            this.EmailAddressIns.AutoSize = true;
            this.EmailAddressIns.Location = new System.Drawing.Point(9, 330);
            this.EmailAddressIns.Name = "EmailAddressIns";
            this.EmailAddressIns.Size = new System.Drawing.Size(48, 16);
            this.EmailAddressIns.TabIndex = 14;
            this.EmailAddressIns.Text = "E-mail:";
            // 
            // LoginIns
            // 
            this.LoginIns.AutoSize = true;
            this.LoginIns.Location = new System.Drawing.Point(9, 367);
            this.LoginIns.Name = "LoginIns";
            this.LoginIns.Size = new System.Drawing.Size(43, 16);
            this.LoginIns.TabIndex = 15;
            this.LoginIns.Text = "Login:";
            // 
            // PasswordInsTxt
            // 
            this.PasswordInsTxt.Location = new System.Drawing.Point(89, 402);
            this.PasswordInsTxt.Name = "PasswordInsTxt";
            this.PasswordInsTxt.Size = new System.Drawing.Size(182, 22);
            this.PasswordInsTxt.TabIndex = 16;
            // 
            // PasswordIns
            // 
            this.PasswordIns.AutoSize = true;
            this.PasswordIns.Location = new System.Drawing.Point(9, 405);
            this.PasswordIns.Name = "PasswordIns";
            this.PasswordIns.Size = new System.Drawing.Size(49, 16);
            this.PasswordIns.TabIndex = 17;
            this.PasswordIns.Text = "Hasło:";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(327, 397);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(159, 33);
            this.AddUser.TabIndex = 18;
            this.AddUser.Text = "Dodaj użytkownika";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // AdminLogout
            // 
            this.AdminLogout.Location = new System.Drawing.Point(615, 397);
            this.AdminLogout.Name = "AdminLogout";
            this.AdminLogout.Size = new System.Drawing.Size(159, 33);
            this.AdminLogout.TabIndex = 19;
            this.AdminLogout.Text = "Wyloguj się";
            this.AdminLogout.UseVisualStyleBackColor = true;
            this.AdminLogout.Click += new System.EventHandler(this.AdminLogout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminLogout);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.PasswordIns);
            this.Controls.Add(this.PasswordInsTxt);
            this.Controls.Add(this.LoginIns);
            this.Controls.Add(this.EmailAddressIns);
            this.Controls.Add(this.LastNameIns);
            this.Controls.Add(this.FirstNameIns);
            this.Controls.Add(this.FirstNameInsTxt);
            this.Controls.Add(this.LoginInsTxt);
            this.Controls.Add(this.EmailAddressInsTxt);
            this.Controls.Add(this.LastNameInsTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.UsersFounds);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podsumowanieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiaKredytowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAktualnychDłużnikówToolStripMenuItem;
        private System.Windows.Forms.ListBox UsersFounds;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LastNameInsTxt;
        private System.Windows.Forms.TextBox EmailAddressInsTxt;
        private System.Windows.Forms.TextBox LoginInsTxt;
        private System.Windows.Forms.TextBox FirstNameInsTxt;
        private System.Windows.Forms.Label FirstNameIns;
        private System.Windows.Forms.Label LastNameIns;
        private System.Windows.Forms.Label EmailAddressIns;
        private System.Windows.Forms.Label LoginIns;
        private System.Windows.Forms.TextBox PasswordInsTxt;
        private System.Windows.Forms.Label PasswordIns;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button AdminLogout;
    }
}