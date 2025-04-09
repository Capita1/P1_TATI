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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace P1_TATI
{
    public partial class frm_Cadastro : Form
    {
        public void limparForm()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            dateNasc.Value = DateTime.Now;
            cmbPais.SelectedIndex = 0;
            txtOrg.Clear();
            radioFem.Checked = false;
            radioMasc.Checked = false;
        }
        public frm_Cadastro()
        {
            InitializeComponent();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //sigla do país
            string selecao = cmbPais.SelectedItem.ToString();
            string[] partes = selecao.Split(' ');
            string pais = partes[0];
            //data de nascimento
            string data = dateNasc.Value.ToString("yyyy-MM-dd");
            //secsu
            string sexo = " ";
            if (radioFem.Checked) 
            {
                sexo = "F";
            }
            if (radioMasc.Checked)
            {
                sexo = "M";
            }
            
            List<string> campos = new List<string> { };
            campos.Add(txtNome.Text);
            campos.Add(txtEmail.Text);
            campos.Add(txtSenha.Text);
            campos.Add(txtTelefone.Text);
            campos.Add(data);
            campos.Add(pais);
            campos.Add(txtOrg.Text);
            campos.Add(sexo);

            // Valida se os campos estão preenchidos            
            int vazios = 0;
            foreach (var str in campos)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    vazios++;
                }
            }
            if (vazios == 0)
            {
                try
                {
                    // Conectar ao banco de dados MySQL
                    using (var conexao = new MySqlConnection("Server=localhost;Port=3306;Database=onu;Uid=root;Pwd=1324;"))
                    {
                        conexao.Open(); // Abre a conexão
                        string query = "INSERT INTO usuarios (nome, email, senha, telefone, data, pais, org, sexo) VALUES (@val0,@val1,@val2,@val3,@val4,@val5,@val6,@val7);";
                        using (var cmd = new MySqlCommand(query, conexao))
                        {
                            // Atribuir os valores 
                            cmd.Parameters.AddWithValue("@val0", campos[0]);
                            cmd.Parameters.AddWithValue("@val1", campos[1]);
                            cmd.Parameters.AddWithValue("@val2", campos[2]);
                            cmd.Parameters.AddWithValue("@val3", campos[3]);
                            cmd.Parameters.AddWithValue("@val4", campos[4]);
                            cmd.Parameters.AddWithValue("@val5", campos[5]);
                            cmd.Parameters.AddWithValue("@val6", campos[6]);
                            cmd.Parameters.AddWithValue("@val7", campos[7]);
                            cmd.ExecuteNonQuery();// Executa o comando
                        }
                        // Mensagem e limpar campos após cadastro
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparForm();
                    }
                }
                catch (Exception ex)
                {
                    // Exibe mensagem de erro caso haja algum problema na conexão
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim btn_cadastrar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparForm();
        }
        private void grb_cadastro_Enter(object sender, EventArgs e)
        { }
        private void frm_Cadastro_Load(object sender, EventArgs e)
        {
            cmbPais.SelectedIndex = 0;
            dateNasc.Format = DateTimePickerFormat.Custom;
            dateNasc.CustomFormat = "dd/MM/yyyy";
        }
    }
}
