using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsumowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaKredytowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dłużnicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaPieniędzyWBankuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ącznyKredytToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dłużnicyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUżytkownikaToolStripMenuItem,
            this.usuńUżytkownikaToolStripMenuItem});
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.użytkownicyToolStripMenuItem.Text = "Użytkownicy";
            // 
            // podsumowanieToolStripMenuItem
            // 
            this.podsumowanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaPieniędzyWBankuToolStripMenuItem,
            this.ącznyKredytToolStripMenuItem});
            this.podsumowanieToolStripMenuItem.Name = "podsumowanieToolStripMenuItem";
            this.podsumowanieToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.podsumowanieToolStripMenuItem.Text = "Podsumowanie";
            // 
            // historiaKredytowaToolStripMenuItem
            // 
            this.historiaKredytowaToolStripMenuItem.Name = "historiaKredytowaToolStripMenuItem";
            this.historiaKredytowaToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.historiaKredytowaToolStripMenuItem.Text = "Historia kredytowa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dłużnicyToolStripMenuItem
            // 
            this.dłużnicyToolStripMenuItem.Name = "dłużnicyToolStripMenuItem";
            this.dłużnicyToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.dłużnicyToolStripMenuItem.Text = "Dłużnicy";
            // 
            // dodajUżytkownikaToolStripMenuItem
            // 
            this.dodajUżytkownikaToolStripMenuItem.Name = "dodajUżytkownikaToolStripMenuItem";
            this.dodajUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajUżytkownikaToolStripMenuItem.Text = "Dodaj użytkownika";
            // 
            // usuńUżytkownikaToolStripMenuItem
            // 
            this.usuńUżytkownikaToolStripMenuItem.Name = "usuńUżytkownikaToolStripMenuItem";
            this.usuńUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuńUżytkownikaToolStripMenuItem.Text = "Usuń użytkownika";
            // 
            // sumaPieniędzyWBankuToolStripMenuItem
            // 
            this.sumaPieniędzyWBankuToolStripMenuItem.Name = "sumaPieniędzyWBankuToolStripMenuItem";
            this.sumaPieniędzyWBankuToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.sumaPieniędzyWBankuToolStripMenuItem.Text = "Suma pieniędzy w banku";
            // 
            // ącznyKredytToolStripMenuItem
            // 
            this.ącznyKredytToolStripMenuItem.Name = "ącznyKredytToolStripMenuItem";
            this.ącznyKredytToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.ącznyKredytToolStripMenuItem.Text = "Łączny kredyt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witamy na koncie administratora";
            // 
            // Welcome
            // 
            this.ClientSize = new System.Drawing.Size(760, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Welcome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
