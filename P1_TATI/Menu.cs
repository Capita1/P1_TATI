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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P1_TATI
{
    public partial class frm_menu : Form
    {
        public string usuario;
        public frm_menu(string id)
        {
            InitializeComponent();
            usuario = id;
        }
        private void frm_menu_Load(object sender, EventArgs e)
        {
            string conexao = ("Server=localhost;Port=3306;Database=onu;Uid=root;Pwd=1324;");
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();//abre comunicação
                    //consulta informações do id
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", usuario);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //cria variaveis 
                            string nome = reader["nome"].ToString();
                            string email = reader["email"].ToString();
                            string telefone = reader["telefone"].ToString();
                            string data = reader["data"].ToString();
                            string pais = reader["pais"].ToString();
                            string org = reader["org"].ToString();
                            string sexo = reader["sexo"].ToString();
                            string foto = reader["foto"].ToString();
                            
                            //coloca a informação nos elementos
                            lblNome.Text = nome;
                            lblEmail.Text = email;
                            lblTelefone.Text = telefone;
                            lblNasc.Text = data;
                            lblPais.Text = pais;
                            lblOrg.Text = org;
                            lblSexo.Text = sexo;
                            picFoto.Image = Image.FromFile(foto);
                            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                            //MessageBox.Show($"Usuário: {nome} - Email: {email}"); //teste
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
