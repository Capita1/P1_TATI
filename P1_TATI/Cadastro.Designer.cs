namespace P1_TATI
{
    partial class frm_Cadastro
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
            lbl_nome = new Label();
            lbl_senha = new Label();
            lbl_pais = new Label();
            lbl_emissora = new Label();
            lbl_telefone = new Label();
            lbl_email = new Label();
            btn_cadastrar = new Button();
            btn_limpar = new Button();
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            textBox5 = new TextBox();
            grb_cadastro = new GroupBox();
            date_Nasc = new DateTimePicker();
            label2 = new Label();
            pais_cmbBox = new ComboBox();
            org_cmbBox = new ComboBox();
            label1 = new Label();
            radio_Masc = new RadioButton();
            radio_Fem = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.ImageAlign = ContentAlignment.MiddleRight;
            lbl_nome.Location = new Point(18, 35);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(123, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome Completo:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.ImageAlign = ContentAlignment.MiddleRight;
            lbl_senha.Location = new Point(18, 76);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(52, 20);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.ImageAlign = ContentAlignment.MiddleRight;
            lbl_pais.Location = new Point(18, 273);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(37, 20);
            lbl_pais.TabIndex = 3;
            lbl_pais.Text = "País:";
            // 
            // lbl_emissora
            // 
            lbl_emissora.AutoSize = true;
            lbl_emissora.ImageAlign = ContentAlignment.MiddleRight;
            lbl_emissora.Location = new Point(18, 312);
            lbl_emissora.Name = "lbl_emissora";
            lbl_emissora.Size = new Size(161, 20);
            lbl_emissora.TabIndex = 5;
            lbl_emissora.Text = "Emissora/Organização:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.ImageAlign = ContentAlignment.MiddleRight;
            lbl_telefone.Location = new Point(18, 153);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(69, 20);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.ImageAlign = ContentAlignment.MiddleRight;
            lbl_email.Location = new Point(18, 115);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(55, 20);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.HotTrack;
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.Location = new Point(490, 396);
            btn_cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(86, 31);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(595, 396);
            btn_limpar.Margin = new Padding(3, 4, 3, 4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(86, 31);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(523, 35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 155);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 32);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(348, 27);
            txtNome.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(147, 73);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(348, 27);
            txtSenha.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 116);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 27);
            txtEmail.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(147, 151);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(348, 27);
            textBox5.TabIndex = 15;
            // 
            // grb_cadastro
            // 
            grb_cadastro.Anchor = AnchorStyles.None;
            grb_cadastro.Controls.Add(date_Nasc);
            grb_cadastro.Controls.Add(label2);
            grb_cadastro.Controls.Add(pais_cmbBox);
            grb_cadastro.Controls.Add(org_cmbBox);
            grb_cadastro.Controls.Add(label1);
            grb_cadastro.Controls.Add(radio_Masc);
            grb_cadastro.Controls.Add(textBox5);
            grb_cadastro.Controls.Add(txtEmail);
            grb_cadastro.Controls.Add(radio_Fem);
            grb_cadastro.Controls.Add(txtSenha);
            grb_cadastro.Controls.Add(btn_limpar);
            grb_cadastro.Controls.Add(btn_cadastrar);
            grb_cadastro.Controls.Add(txtNome);
            grb_cadastro.Controls.Add(pictureBox1);
            grb_cadastro.Controls.Add(lbl_email);
            grb_cadastro.Controls.Add(lbl_nome);
            grb_cadastro.Controls.Add(lbl_telefone);
            grb_cadastro.Controls.Add(lbl_emissora);
            grb_cadastro.Controls.Add(lbl_senha);
            grb_cadastro.Controls.Add(lbl_pais);
            grb_cadastro.Location = new Point(11, 5);
            grb_cadastro.Margin = new Padding(3, 4, 3, 4);
            grb_cadastro.Name = "grb_cadastro";
            grb_cadastro.Padding = new Padding(3, 4, 3, 4);
            grb_cadastro.Size = new Size(688, 435);
            grb_cadastro.TabIndex = 16;
            grb_cadastro.TabStop = false;
            grb_cadastro.Text = "Cadastro de imprensa";
            grb_cadastro.Enter += grb_cadastro_Enter;
            // 
            // date_Nasc
            // 
            date_Nasc.Location = new Point(185, 229);
            date_Nasc.Margin = new Padding(3, 4, 3, 4);
            date_Nasc.Name = "date_Nasc";
            date_Nasc.Size = new Size(151, 27);
            date_Nasc.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(18, 236);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 20;
            label2.Text = "Data de nascimento:";
            // 
            // pais_cmbBox
            // 
            pais_cmbBox.FormattingEnabled = true;
            pais_cmbBox.Location = new Point(185, 269);
            pais_cmbBox.Name = "pais_cmbBox";
            pais_cmbBox.Size = new Size(151, 28);
            pais_cmbBox.TabIndex = 19;
            // 
            // org_cmbBox
            // 
            org_cmbBox.FormattingEnabled = true;
            org_cmbBox.Location = new Point(185, 309);
            org_cmbBox.Name = "org_cmbBox";
            org_cmbBox.Size = new Size(151, 28);
            org_cmbBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(21, 356);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 17;
            label1.Text = "Sexo:";
            // 
            // radio_Masc
            // 
            radio_Masc.AutoSize = true;
            radio_Masc.Location = new Point(168, 355);
            radio_Masc.Name = "radio_Masc";
            radio_Masc.Size = new Size(97, 24);
            radio_Masc.TabIndex = 16;
            radio_Masc.TabStop = true;
            radio_Masc.Text = "Masculino";
            radio_Masc.UseVisualStyleBackColor = true;
            // 
            // radio_Fem
            // 
            radio_Fem.AutoSize = true;
            radio_Fem.Location = new Point(71, 355);
            radio_Fem.Name = "radio_Fem";
            radio_Fem.Size = new Size(91, 24);
            radio_Fem.TabIndex = 10;
            radio_Fem.TabStop = true;
            radio_Fem.Text = "Feminino";
            radio_Fem.UseVisualStyleBackColor = true;
            // 
            // frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 453);
            Controls.Add(grb_cadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Cadastro";
            Text = "Cadastro";
            Load += frm_Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_cadastro.ResumeLayout(false);
            grb_cadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_senha;
        private Label lbl_pais;
        private Label lbl_emissora;
        private Label lbl_telefone;
        private Label lbl_email;
        private Button btn_cadastrar;
        private Button btn_limpar;
        private PictureBox pictureBox1;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox textBox5;
        private GroupBox grb_cadastro;
        private RadioButton radio_Fem;
        private RadioButton radio_Masc;
        private Label label1;
        private ComboBox pais_cmbBox;
        private ComboBox org_cmbBox;
        private Label label2;
        private DateTimePicker date_Nasc;
    }
}