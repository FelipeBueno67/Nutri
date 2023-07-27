using ProjetoFelipe.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoFelipe.Model
{
    class PacienteModel
    {
        private int id;
        private string nome;
        private int idade;
        private int peso;
        private int altura;
        private Banco banco;

        //public void  Paciente()
        //{
        //    this.banco = new Banco();
        //}
        public MySqlDataReader ListarPacientes()
        {
            this.banco = new Banco();
            return this.banco.Query("select * from `bancofelipe`.`pacientes`");
        }
        public MySqlDataReader ListarPacientes(string campo, string filtro)
        {
            this.banco = new Banco();
            if (filtro == "")
            {
                return ListarPacientes();
            }
            return this.banco.Query("select * from `bancofelipe`.`pacientes` where "+campo+" = "+filtro+"");
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }
    }
}
