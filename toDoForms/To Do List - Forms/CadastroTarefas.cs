using connectDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace To_Do_List___Forms
{
    internal class CadastroTarefas  
    {

        private string connectionString = "Data Source = ISAC; Initial Catalog = Testes; Integrated Security = True";

        private string tituloTarefa, descricaoTarefa;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao;
        public SqlDataReader listarTarefas()
        {
            return this.conexao.Query("SELECT * FROM Tarefas order by ID_Tasks asc");
        }
        public void removeTarefas(string IDTask)
        {
            try
            {
                this.conexao.NonQuery("DELETE FROM Tarefas WHERE ID_Tasks = " + IDTask);
                int idDeletado = int.Parse(IDTask);
                string connectionString = "Data Source = ISAC; Initial Catalog = Testes; Integrated Security = True";
                string queryDelete = "UPDATE Tarefas SET ID_Tasks = ID_Tasks -1 WHERE ID_Tasks > @IDTask";
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(queryDelete, conexao))
                    {
                        cmd.Parameters.AddWithValue("@IDTask", idDeletado);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Houve um erro ao realizar a operação " + e.Message);
            }

        }
        public void adicionaTarefa(string arg1, string arg2)
        {
            try
            {
                string connectionString = "Data Source = ISAC; Initial Catalog = Testes; Integrated Security = True";
                string query = "INSERT INTO Tarefas (ID_Tasks, Titulo, Descricao) VALUES (@ID_Tasks, @Titulo, @Descricao)";
                string adicionaId = "SELECT ISNULL(MAX(ID_Tasks), 0) FROM Tarefas";
                int nextiD;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(adicionaId, connection))
                    {
                        connection.Open();
                        nextiD = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                        connection.Close();
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Tasks", nextiD);
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

        public void editarTarefa(string IDTask, string arg1, string arg2)
        {
            try
            {
                string connectionString = "Data Source = ISAC; Initial Catalog = Testes; Integrated Security = True";
                string query = "UPDATE Tarefas SET Titulo = @novoTitulo, Descricao = @novaDescricao WHERE ID_Tasks = @id"; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", IDTask);
                        command.Parameters.AddWithValue("@novoTitulo", arg1);
                        command.Parameters.AddWithValue("@novaDescricao", arg2);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tarefa editada com sucesso");
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

