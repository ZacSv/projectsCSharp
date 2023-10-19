using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace connectDB
{
    public class Conexao
    {
        private SqlCommand cmd;
        SqlConnection con = new SqlConnection();
        public Conexao() 
        {
            ////Linha de conexão
            this.con = new SqlConnection(con.ConnectionString);
            this.cmd = this.con.CreateCommand();
            this.con.Open();

        }
        public SqlConnection Conectar()
        {   if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
            
        //Majoritariamente irá cuidar dde operações como Update, delete e create.
        public void NonQuery(string sql)
        {
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
        }

        //Irá cuidar de operações de Read pois necessitam de um retorno.
        public SqlDataReader Query(string sql)
        {
            this.cmd.CommandText = sql;
            return this.cmd.ExecuteReader();    
        }
    }
}
