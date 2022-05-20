namespace WindowsFormsApp1
{
    partial class User
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.środkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wpłataŚrodkówNaKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypłataŚrodkówZKontaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprawdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsumowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przelewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spłaćKredytToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 238);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(646, 56);
            this.trackBar1.TabIndex = 3;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(45, 378);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(638, 56);
            this.trackBar2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ilość potrzebnej gotówki";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ilość rat";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(743, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "Zatwierdź kredyt";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.środkiToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.podsumowanieToolStripMenuItem,
            this.przelewToolStripMenuItem,
            this.spłaćKredytToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // środkiToolStripMenuItem
            // 
            this.środkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wpłataŚrodkówNaKontoToolStripMenuItem,
            this.wypłataŚrodkówZKontaToolStripMenuItem});
            this.środkiToolStripMenuItem.Name = "środkiToolStripMenuItem";
            this.środkiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.środkiToolStripMenuItem.Text = "Środki";
            // 
            // wpłataŚrodkówNaKontoToolStripMenuItem
            // 
            this.wpłataŚrodkówNaKontoToolStripMenuItem.Name = "wpłataŚrodkówNaKontoToolStripMenuItem";
            this.wpłataŚrodkówNaKontoToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.wpłataŚrodkówNaKontoToolStripMenuItem.Text = "Wpłata środków na konto";
            // 
            // wypłataŚrodkówZKontaToolStripMenuItem
            // 
            this.wypłataŚrodkówZKontaToolStripMenuItem.Name = "wypłataŚrodkówZKontaToolStripMenuItem";
            this.wypłataŚrodkówZKontaToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.wypłataŚrodkówZKontaToolStripMenuItem.Text = "Wypłata środków z konta";
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprawdźToolStripMenuItem});
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // sprawdźToolStripMenuItem
            // 
            this.sprawdźToolStripMenuItem.Name = "sprawdźToolStripMenuItem";
            this.sprawdźToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.sprawdźToolStripMenuItem.Text = "Sprawdź";
            // 
            // podsumowanieToolStripMenuItem
            // 
            this.podsumowanieToolStripMenuItem.Name = "podsumowanieToolStripMenuItem";
            this.podsumowanieToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.podsumowanieToolStripMenuItem.Text = "Podsumowanie";
            // 
            // przelewToolStripMenuItem
            // 
            this.przelewToolStripMenuItem.Name = "przelewToolStripMenuItem";
            this.przelewToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.przelewToolStripMenuItem.Text = "Przelew";
            // 
            // spłaćKredytToolStripMenuItem
            // 
            this.spłaćKredytToolStripMenuItem.Name = "spłaćKredytToolStripMenuItem";
            this.spłaćKredytToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.spłaćKredytToolStripMenuItem.Text = "Spłać kredyt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(32, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(691, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Już dziś weź kredyt 0% i nie czekaj. Spełnij swoje marzenia dzięki bankowi polski" +
    "emu ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Potrzebujesz dodatkowej gotówki na wakacje?";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(743, 378);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(210, 45);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Wyloguj się";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 515);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "User";
            this.Text = "Konto";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem środkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wpłataŚrodkówNaKontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypłataŚrodkówZKontaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podsumowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przelewToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem sprawdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spłaćKredytToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Logout;
    }
}

