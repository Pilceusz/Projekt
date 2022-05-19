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
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zablokujUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsumowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.historiaKredytowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAktualnychDłużnikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.użytkownicyToolStripMenuItem,
            this.podsumowanieToolStripMenuItem,
            this.historiaKredytowaToolStripMenuItem,
            this.listaAktualnychDłużnikówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUżytkownikaToolStripMenuItem,
            this.usuńUżytkownikaToolStripMenuItem,
            this.zablokujUżytkownikaToolStripMenuItem});
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.użytkownicyToolStripMenuItem.Text = "Użytkownicy";
            this.użytkownicyToolStripMenuItem.Click += new System.EventHandler(this.użytkownicyToolStripMenuItem_Click);
            // 
            // dodajUżytkownikaToolStripMenuItem
            // 
            this.dodajUżytkownikaToolStripMenuItem.Name = "dodajUżytkownikaToolStripMenuItem";
            this.dodajUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dodajUżytkownikaToolStripMenuItem.Text = "Dodaj użytkownika";
            // 
            // usuńUżytkownikaToolStripMenuItem
            // 
            this.usuńUżytkownikaToolStripMenuItem.Name = "usuńUżytkownikaToolStripMenuItem";
            this.usuńUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.usuńUżytkownikaToolStripMenuItem.Text = "Usuń użytkownika";
            // 
            // zablokujUżytkownikaToolStripMenuItem
            // 
            this.zablokujUżytkownikaToolStripMenuItem.Name = "zablokujUżytkownikaToolStripMenuItem";
            this.zablokujUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.zablokujUżytkownikaToolStripMenuItem.Text = "Zablokuj użytkownika";
            // 
            // podsumowanieToolStripMenuItem
            // 
            this.podsumowanieToolStripMenuItem.Name = "podsumowanieToolStripMenuItem";
            this.podsumowanieToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.podsumowanieToolStripMenuItem.Text = "Podsumowanie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // historiaKredytowaToolStripMenuItem
            // 
            this.historiaKredytowaToolStripMenuItem.Name = "historiaKredytowaToolStripMenuItem";
            this.historiaKredytowaToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.historiaKredytowaToolStripMenuItem.Text = "Historia kredytowa";
            // 
            // listaAktualnychDłużnikówToolStripMenuItem
            // 
            this.listaAktualnychDłużnikówToolStripMenuItem.Name = "listaAktualnychDłużnikówToolStripMenuItem";
            this.listaAktualnychDłużnikówToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.listaAktualnychDłużnikówToolStripMenuItem.Text = "Lista aktualnych dłużników";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo banku :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Łączny kredyt klientów :";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(61, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(675, 38);
            this.progressBar1.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem użytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zablokujUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podsumowanieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiaKredytowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAktualnychDłużnikówToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}