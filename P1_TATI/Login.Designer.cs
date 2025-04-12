namespace P1_TATI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            btnEntrar = new Button();
            btnCancelar = new Button();
            btnRedefinir = new Button();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkLembre = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(68, 119);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(184, 119);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRedefinir
            // 
            btnRedefinir.Location = new Point(299, 119);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(121, 23);
            btnRedefinir.TabIndex = 2;
            btnRedefinir.Text = "Redefinir Senha";
            btnRedefinir.UseVisualStyleBackColor = true;
            btnRedefinir.Click += btn_redefinir_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(3, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(63, 37);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "E-Mail:";
            lbl_usuario.TextAlign = ContentAlignment.MiddleRight;
            lbl_usuario.Click += lbl_usuario_Click;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(3, 37);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(63, 38);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            lbl_senha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(72, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(72, 40);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(316, 23);
            txtSenha.TabIndex = 6;
            // 
            // chkLembre
            // 
            chkLembre.AutoSize = true;
            chkLembre.Location = new Point(140, 90);
            chkLembre.Name = "chkLembre";
            chkLembre.RightToLeft = RightToLeft.No;
            chkLembre.Size = new Size(100, 19);
            chkLembre.TabIndex = 7;
            chkLembre.Text = "Lembrar login";
            chkLembre.UseVisualStyleBackColor = true;
            chkLembre.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6470585F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.35294F));
            tableLayoutPanel1.Controls.Add(lbl_usuario, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_senha, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSenha, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 0);
            tableLayoutPanel1.Location = new Point(68, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(391, 75);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 165);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(chkLembre);
            Controls.Add(btnRedefinir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Login";
            Text = "Login";
            Load += frm_Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Button btnCancelar;
        private Button btnRedefinir;
        private Label lbl_usuario;
        private Label lbl_senha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkLembre;
        private TableLayoutPanel tableLayoutPanel1;
    }
}