using connectDB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace To_Do_List___Forms
{
    public partial class Form1 : Form
    {

        private CadastroTarefas CadastroTarefas;

        public Form1()
        {
            InitializeComponent();

        }

        public bool isEditting = false;

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

        public void Form1_Load(object sender, EventArgs e)
        {
            this.CadastroTarefas = new CadastroTarefas();

            Conexao conexao = new Conexao();

            SqlDataReader temp = this.CadastroTarefas.listarTarefas();

            DataTable dt = new DataTable();
            dt.Load(temp);

            dataGridViewTable.DataSource = dt;


        }

        private void tb_TaskTittle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            tb_TaskTittle.Text = "";
            lb_IDTask.Text = "";
            tb_Description.Text = "";
            tb_TaskTittle.Focus();
            tb_TaskTittle.ReadOnly = false;
            tb_Description.ReadOnly = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            isEditting = true;
            tb_TaskTittle.ReadOnly = false;
            tb_Description.ReadOnly = false;
        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroTarefas.removeTarefas(lb_IDTask.Text);
                MessageBox.Show("Tarefa removida com sucesso!");
                SqlDataReader temp = this.CadastroTarefas.listarTarefas();
                DataTable dt = new DataTable();
                dt.Load(temp);
                dataGridViewTable.DataSource = dt;
                tb_TaskTittle.Text = "";
                tb_Description.Text = "";
                lb_IDTask.Text = "";
            }
            catch (Exception arg)
            {

                MessageBox.Show("A operação apresentou um erro" + arg.Message);
            }


        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (isEditting == true)
            {
                CadastroTarefas.editarTarefa(lb_IDTask.Text, tb_TaskTittle.Text, tb_Description.Text);
                SqlDataReader refresh = this.CadastroTarefas.listarTarefas();
                DataTable database = new DataTable();
                database.Load(refresh);
                dataGridViewTable.DataSource = database;
                isEditting = false;
            }
            else
            {
                CadastroTarefas.adicionaTarefa(tb_TaskTittle.Text, tb_Description.Text);
                SqlDataReader temp = this.CadastroTarefas.listarTarefas();
                DataTable dt = new DataTable();
                dt.Load(temp);
                dataGridViewTable.DataSource = dt;
            }
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewTable.Rows[e.RowIndex];

            lb_IDTask.Text = row.Cells[0].Value.ToString();

            tb_TaskTittle.Text = row.Cells[1].Value.ToString();

            tb_Description.Text = row.Cells[2].Value.ToString();

        }

        private void dataGridViewTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewTable.Rows[e.RowIndex];

            lb_IDTask.Text = row.Cells[0].Value.ToString();

            tb_TaskTittle.Text = row.Cells[1].Value.ToString();

            tb_Description.Text = row.Cells[2].Value.ToString();

            tb_TaskTittle.ReadOnly = true;

            isEditting = false;

            tb_Description.ReadOnly = true;

        }
    }
}
