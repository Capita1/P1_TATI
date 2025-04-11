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
            lblNome = new Label();
            picFoto = new PictureBox();
            lblEmail = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            lblPais = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTelefone = new Label();
            lblNasc = new Label();
            lblOrg = new Label();
            lblSexo = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            groupBox1.SuspendLayout();
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(161, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "nome";
            lblNome.Click += lblNome_Click;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(6, 22);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(104, 105);
            picFoto.TabIndex = 2;
            picFoto.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(161, 37);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 22);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSexo);
            groupBox1.Controls.Add(lblOrg);
            groupBox1.Controls.Add(lblNasc);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblPais);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picFoto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 52);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 67);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Nascimento:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 82);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "País:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(153, 82);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 6;
            lblPais.Text = "pais";
            lblPais.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 97);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 10;
            label6.Text = "Organização:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 112);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 11;
            label7.Text = "Sexo:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(171, 52);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(50, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "telefone";
            // 
            // lblNasc
            // 
            lblNasc.AutoSize = true;
            lblNasc.Location = new Point(196, 67);
            lblNasc.Name = "lblNasc";
            lblNasc.Size = new Size(69, 15);
            lblNasc.TabIndex = 13;
            lblNasc.Text = "nascimento";
            // 
            // lblOrg
            // 
            lblOrg.AutoSize = true;
            lblOrg.Location = new Point(198, 97);
            lblOrg.Name = "lblOrg";
            lblOrg.Size = new Size(71, 15);
            lblOrg.TabIndex = 14;
            lblOrg.Text = "organização";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(153, 112);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 15;
            lblSexo.Text = "sexo";
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_menu";
            Text = "Menu";
            Load += frm_menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label lblNome;
        private PictureBox picFoto;
        private Label lblEmail;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label lblPais;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label lblSexo;
        private Label lblOrg;
        private Label lblNasc;
        private Label lblTelefone;
    }
}