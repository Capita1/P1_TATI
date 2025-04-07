using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace P1_TATI
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string telefone = txtTelefone.Text;

            // Valida se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Conectar ao banco de dados MySQL
                    using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=onu;Uid=root;Pwd=1324;"))
                    {
                        conn.Open(); // Abre a conexão
                        // Comando SQL para inserir os dados
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha)", conn))
                        {

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@senha", senha);

                            // Executa o comando
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpar campos após cadastro
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtSenha.Clear();
                    }
                }
                catch (Exception ex)
                {
                    // Exibe mensagem de erro caso haja algum problema na conexão
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }
        private void grb_cadastro_Enter(object sender, EventArgs e)
        { }
        private void frm_Cadastro_Load(object sender, EventArgs e)
        { }
    }
}
