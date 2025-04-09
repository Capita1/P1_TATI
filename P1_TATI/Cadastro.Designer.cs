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
            txtTelefone = new TextBox();
            grb_cadastro = new GroupBox();
            txtOrg = new TextBox();
            dateNasc = new DateTimePicker();
            label2 = new Label();
            cmbPais = new ComboBox();
            label1 = new Label();
            radioMasc = new RadioButton();
            radioFem = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.ImageAlign = ContentAlignment.MiddleRight;
            lbl_nome.Location = new Point(16, 26);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(99, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome Completo:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.ImageAlign = ContentAlignment.MiddleRight;
            lbl_senha.Location = new Point(16, 57);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.ImageAlign = ContentAlignment.MiddleRight;
            lbl_pais.Location = new Point(16, 205);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(31, 15);
            lbl_pais.TabIndex = 3;
            lbl_pais.Text = "País:";
            // 
            // lbl_emissora
            // 
            lbl_emissora.AutoSize = true;
            lbl_emissora.ImageAlign = ContentAlignment.MiddleRight;
            lbl_emissora.Location = new Point(16, 234);
            lbl_emissora.Name = "lbl_emissora";
            lbl_emissora.Size = new Size(128, 15);
            lbl_emissora.TabIndex = 5;
            lbl_emissora.Text = "Emissora/Organização:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.ImageAlign = ContentAlignment.MiddleRight;
            lbl_telefone.Location = new Point(16, 115);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(54, 15);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.ImageAlign = ContentAlignment.MiddleRight;
            lbl_email.Location = new Point(16, 86);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(44, 15);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.HotTrack;
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.Location = new Point(429, 297);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(521, 297);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(458, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 116);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(129, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 23);
            txtNome.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(129, 55);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(305, 23);
            txtSenha.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(129, 113);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(305, 23);
            txtTelefone.TabIndex = 15;
            // 
            // grb_cadastro
            // 
            grb_cadastro.Anchor = AnchorStyles.None;
            grb_cadastro.Controls.Add(txtOrg);
            grb_cadastro.Controls.Add(dateNasc);
            grb_cadastro.Controls.Add(label2);
            grb_cadastro.Controls.Add(cmbPais);
            grb_cadastro.Controls.Add(label1);
            grb_cadastro.Controls.Add(radioMasc);
            grb_cadastro.Controls.Add(txtTelefone);
            grb_cadastro.Controls.Add(txtEmail);
            grb_cadastro.Controls.Add(radioFem);
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
            grb_cadastro.Location = new Point(10, 4);
            grb_cadastro.Name = "grb_cadastro";
            grb_cadastro.Size = new Size(602, 326);
            grb_cadastro.TabIndex = 16;
            grb_cadastro.TabStop = false;
            grb_cadastro.Text = "Cadastro de imprensa";
            grb_cadastro.Enter += grb_cadastro_Enter;
            // 
            // txtOrg
            // 
            txtOrg.Location = new Point(162, 230);
            txtOrg.Name = "txtOrg";
            txtOrg.Size = new Size(133, 23);
            txtOrg.TabIndex = 23;
            // 
            // dateNasc
            // 
            dateNasc.Location = new Point(162, 172);
            dateNasc.Name = "dateNasc";
            dateNasc.Size = new Size(133, 23);
            dateNasc.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(16, 177);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 20;
            label2.Text = "Data de nascimento:";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { " ", "AP \tOrganização Regional Africana da Propriedade Industrial (ARIPO)", "AR \tArgentina", "AT \tÁustria", "AU \tAustrália", "BA \tBósnia e Herzegovina", "BE \tBélgica", "BG \tBulgária", "BR \tBrazil", "CA \tCanadá", "CH \tSuíça", "CN \tChina", "CS \tChecoeslováquia (até 1993)", "CU \tCuba", "CY \tChipre", "CZ \tRepública Checa", "DD \tAlemanha, excluindo o território que, antes de 3 de Outubro de 1990, constituia a República Federal da Alemanha", "DE \tAlemanha", "DK \tDinamarca", "DZ \tArgélia", "EA \tOrganização Euroasiática de Patentes", "EE \tEstónia", "EG \tEgipto", "EP \tOrganização Europeia de Patentes (OPE/EPO)", "ES \tEspanha", "FI \tFinlândia", "FR \tFrança", "GB \tReino Unido", "GR \tGrécia", "HK \tHong Kong", "HR \tCroácia", "HU \tHungria", "IE \tIrlanda", "IL \tIsrael", "IN \tIndia", "IT \tItália", "JP \tJapão", "KE \tQuénia", "KR \tRepública da Coreia", "LT \tLituânia", "LU \tLuxemburgo", "LV \tLetónia", "MC \tMónaco", "MD \tRepública da Moldávia", "MN \tMongólia", "MT \tMalta", "MW \tMalawi", "MX \tMéxico", "MY \tMalásia", "NC \tNova Caledónia", "NL \tHolanda", "NO \tNoruega", "NZ \tNova Zelândia", "OA \tOrganização Africana da Propriedade Intelectual (OAPI)", "PH \tFilipinas", "PL \tPolónia", "PT \tPortugal", "RO \tRoménia", "RU \tFederação Russa", "SE \tSuécia", "SG \tSingapura", "SI \tEslovénia", "SK \tEslováquia", "SU \tUnião das Repúblicas Socialistas Soviéticas (URSS)", "TJ \tTadjiquistão", "TR \tTurquia", "TT \tTrindade e Tobago", "TW \tTaiwan", "US \tEstados Unidos da América", "VN \tVietname", "WO \tOrganização Mundial da Propriedade Intelectual (OMPI/WIPO)", "YU \tJugoslávia", "ZA \tÁfrica do Sul", "ZM \tZâmbia", "ZW \tZimbabwe" });
            cmbPais.Location = new Point(162, 202);
            cmbPais.Margin = new Padding(3, 2, 3, 2);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(133, 23);
            cmbPais.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(18, 267);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 17;
            label1.Text = "Sexo:";
            // 
            // radioMasc
            // 
            radioMasc.AutoSize = true;
            radioMasc.Location = new Point(147, 266);
            radioMasc.Margin = new Padding(3, 2, 3, 2);
            radioMasc.Name = "radioMasc";
            radioMasc.Size = new Size(80, 19);
            radioMasc.TabIndex = 16;
            radioMasc.TabStop = true;
            radioMasc.Text = "Masculino";
            radioMasc.UseVisualStyleBackColor = true;
            // 
            // radioFem
            // 
            radioFem.AutoSize = true;
            radioFem.Location = new Point(62, 266);
            radioFem.Margin = new Padding(3, 2, 3, 2);
            radioFem.Name = "radioFem";
            radioFem.Size = new Size(75, 19);
            radioFem.TabIndex = 10;
            radioFem.TabStop = true;
            radioFem.Text = "Feminino";
            radioFem.UseVisualStyleBackColor = true;
            // 
            // frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 340);
            Controls.Add(grb_cadastro);
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
        private TextBox txtTelefone;
        private GroupBox grb_cadastro;
        private RadioButton radioFem;
        private RadioButton radioMasc;
        private Label label1;
        private ComboBox cmbPais;
        private Label label2;
        private DateTimePicker dateNasc;
        private TextBox txtOrg;
    }
}