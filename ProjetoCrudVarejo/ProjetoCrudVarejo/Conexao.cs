using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoCrudVarejo
{
    using MySql.Data.MySqlClient;

    public class Conexao
    {
        private MySqlConnection conexao;
        //Serve para dizer onde esta o banco, qual o nome e quem pode acessar
        private string stringConexao = "server=localhost;database=ProjetoCrudVarejo;uid=root;pwd=;";

        public MySqlConnection Conectar()
        {
            conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
        public void Desconectar()
        {
            conexao.Close();
        }

    }
}
