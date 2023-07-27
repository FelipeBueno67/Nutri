using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoFelipe
{
    class Banco
    {
        private String host = "localhost";
        private String nomeBanco = "bancoFelipe";
        private String usuario = "root";
        private String senha = "123456";
        private MySqlConnection con;
        private MySqlCommand command;
        public Banco() 
        { 
            Conectar();
        }

        public void Conectar()
        {
            string connectionString = "SERVER="+this.host+";DATABASE="+this.nomeBanco+";UID="+this.usuario+";PASSWORD="+this.senha+";";
            this.con = new MySqlConnection(connectionString);
            this.command = this.con.CreateCommand();
            this.con.Open();
        }

        public void NoQuery(string sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }

        public MySqlDataReader Query(string sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();

        }
    }
}
