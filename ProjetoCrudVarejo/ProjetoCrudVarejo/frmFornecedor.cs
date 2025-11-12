using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCrudVarejo
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nomeF = txtNomeF.Text;
            fornecedor.razao = txtRazao.Text;
            fornecedor.cnpj = txtCnpj.Text;

            string inserir = "INSERT INTO tblFornecedor VALUES(NULL, '" + fornecedor.nomeF + "', '" + fornecedor.razao + "', '" + fornecedor.cnpj + "')";
            Conexao conexao = new Conexao();
            MySqlCommand cmd = new MySqlCommand(inserir, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cadastro realizado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string sql = "DELETE FROM tblFornecedor WHERE Id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cliente excluído!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string sql = "UPDATE tblFornecedor SET Nome_fantasia='" + txtNomeF.Text + "', Razao_social='" + txtRazao.Text + "', Cnpj='" + txtCnpj.Text + "' WHERE Id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            MessageBox.Show("Cliente atualizado!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM tblFornecedor";
            MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexao.Desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
