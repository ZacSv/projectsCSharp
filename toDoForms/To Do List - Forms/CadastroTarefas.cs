using connectDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List___Forms
{
    internal class CadastroTarefas
    {


        private string tituloTarefa, descricaoTarefa;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao;

        public SqlDataReader listarTarefas()
        {
            return  this.conexao.Query("SELECT * FROM Tarefas order by ID_Tasks asc");
        }
        public void removeTarefas(string IDTask)
        {
            this.conexao.NonQuery("DELETE FROM Tarefas WHERE ID_Tasks = " + IDTask);
        }

        public void adicionaTarefa(string arg1, string arg2)
        {
            try
            {

                //Sua linha de conexão
                string query = "INSERT INTO Tarefas (Titulo, Descricao) VALUES (@Titulo, @Descricao)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", arg1);
                        command.Parameters.AddWithValue("@Descricao", arg2);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tarefa inserida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro na operação: " + ex.Message);
            }
        }



        public CadastroTarefas() 

        {
            this.conexao = new Conexao();
        }
        
    }
}
