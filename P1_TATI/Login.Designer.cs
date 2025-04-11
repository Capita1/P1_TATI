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
            btnEntrar = new Button();
            btnCancelar = new Button();
            btnRedefinir = new Button();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkLembre = new CheckBox();
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
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(69, 22);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(44, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "E-Mail:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(69, 62);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(161, 54);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(259, 23);
            txtSenha.TabIndex = 6;
            // 
            // chkLembre
            // 
            chkLembre.AutoSize = true;
            chkLembre.Location = new Point(230, 83);
            chkLembre.Name = "chkLembre";
            chkLembre.RightToLeft = RightToLeft.No;
            chkLembre.Size = new Size(100, 19);
            chkLembre.TabIndex = 7;
            chkLembre.Text = "Lembrar login";
            chkLembre.UseVisualStyleBackColor = true;
            chkLembre.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 165);
            Controls.Add(chkLembre);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(btnRedefinir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Name = "frm_Login";
            Text = "Login";
            Load += frm_Login_Load;
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
    }
}