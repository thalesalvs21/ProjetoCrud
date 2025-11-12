using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrudVarejo
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string telefone;
        private string sexo;
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetTelefone()
        {
            return telefone;
        }
        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string GetSexo()
        {
            return sexo;
        }
        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }
    }
}
