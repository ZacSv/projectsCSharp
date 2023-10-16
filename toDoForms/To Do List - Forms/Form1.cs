using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable todoList = new DataTable(); //Criando o 'banco de dados'
        bool isEditing = false; //Definindo uma propriedade de rastreamento da edição
        private void Form1_Load(object sender, EventArgs e)
        {
            //Criação das linhas e colunas
            todoList.Columns.Add("Titulo");
            todoList.Columns.Add("Descrição");

            //Apontando o datagrid para a tabela de modo que ele mostre o que consta na base de dados
            dataGridViewTable.DataSource = todoList;
        }

        

        private void tb_TaskTittle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            tb_TaskTittle.Text = "";
            tb_Description.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            tb_TaskTittle.Text = todoList.Rows[dataGridViewTable.CurrentCell.RowIndex].ItemArray[0].ToString();
            tb_Description.Text = todoList.Rows[dataGridViewTable.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[dataGridViewTable.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridViewTable.CurrentCell.RowIndex]["Título"] = tb_TaskTittle.Text;
                todoList.Rows[dataGridViewTable.CurrentCell.RowIndex]["Descrição"] = tb_Description.Text;
            }
            else
            {
                todoList.Rows.Add(tb_TaskTittle.Text, tb_Description.Text);
            }

            tb_Description.Text = "";
            tb_TaskTittle.Text = "";
            isEditing = false;
        }
    }
}
