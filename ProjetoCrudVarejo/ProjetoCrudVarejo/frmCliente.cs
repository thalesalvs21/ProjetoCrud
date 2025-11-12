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

namespace ProjetoCrudVarejo
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.SetNome(txtNome.Text);
            cliente.SetTelefone(txtTelefone.Text);
            cliente.SetSexo(cmbSexo.Text);
            string inserir = "INSERT INTO tblCliente VALUES(NULL, '" + cliente.GetNome() + "', '" + cliente.GetTelefone() + "', '" + cliente.GetSexo() + "')";
            Conexao conexao = new Conexao();
            MySqlCommand cmd = new MySqlCommand(inserir, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cadastro realizado!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM tblcliente";
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexao.Desconectar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string sql = "UPDATE tblcliente SET Nome='" + txtNome.Text + "', Telefone='" + txtTelefone.Text + "', Sexo='" + cmbSexo.Text + "' WHERE Id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cliente atualizado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string sql = "DELETE FROM tblcliente WHERE Id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cliente excluído!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
