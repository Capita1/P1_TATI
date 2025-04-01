namespace P1_TATI
{
    partial class frm_menu
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
            menuStrip1 = new MenuStrip();
            estatísticaToolStripMenuItem = new ToolStripMenuItem();
            locaisSegurosToolStripMenuItem = new ToolStripMenuItem();
            acordosToolStripMenuItem = new ToolStripMenuItem();
            linhaDoTempoToolStripMenuItem = new ToolStripMenuItem();
            religiãoToolStripMenuItem = new ToolStripMenuItem();
            coletivasDeImprensaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { estatísticaToolStripMenuItem, locaisSegurosToolStripMenuItem, acordosToolStripMenuItem, linhaDoTempoToolStripMenuItem, religiãoToolStripMenuItem, coletivasDeImprensaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // estatísticaToolStripMenuItem
            // 
            estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            estatísticaToolStripMenuItem.Size = new Size(71, 20);
            estatísticaToolStripMenuItem.Text = "Estatística";
            // 
            // locaisSegurosToolStripMenuItem
            // 
            locaisSegurosToolStripMenuItem.Name = "locaisSegurosToolStripMenuItem";
            locaisSegurosToolStripMenuItem.Size = new Size(97, 20);
            locaisSegurosToolStripMenuItem.Text = "Locais Seguros";
            // 
            // acordosToolStripMenuItem
            // 
            acordosToolStripMenuItem.Name = "acordosToolStripMenuItem";
            acordosToolStripMenuItem.Size = new Size(63, 20);
            acordosToolStripMenuItem.Text = "Acordos";
            // 
            // linhaDoTempoToolStripMenuItem
            // 
            linhaDoTempoToolStripMenuItem.Name = "linhaDoTempoToolStripMenuItem";
            linhaDoTempoToolStripMenuItem.Size = new Size(104, 20);
            linhaDoTempoToolStripMenuItem.Text = "Linha do Tempo";
            // 
            // religiãoToolStripMenuItem
            // 
            religiãoToolStripMenuItem.Name = "religiãoToolStripMenuItem";
            religiãoToolStripMenuItem.Size = new Size(61, 20);
            religiãoToolStripMenuItem.Text = "Religião";
            // 
            // coletivasDeImprensaToolStripMenuItem
            // 
            coletivasDeImprensaToolStripMenuItem.Name = "coletivasDeImprensaToolStripMenuItem";
            coletivasDeImprensaToolStripMenuItem.Size = new Size(135, 20);
            coletivasDeImprensaToolStripMenuItem.Text = "Coletivas de Imprensa";
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_menu";
            Text = "Menu";
            Load += frm_menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem estatísticaToolStripMenuItem;
        private ToolStripMenuItem locaisSegurosToolStripMenuItem;
        private ToolStripMenuItem acordosToolStripMenuItem;
        private ToolStripMenuItem linhaDoTempoToolStripMenuItem;
        private ToolStripMenuItem religiãoToolStripMenuItem;
        private ToolStripMenuItem coletivasDeImprensaToolStripMenuItem;
    }
}