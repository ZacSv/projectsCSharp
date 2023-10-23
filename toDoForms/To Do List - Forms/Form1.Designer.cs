namespace To_Do_List___Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_tittle = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.iDTasksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaTarefas = new To_Do_List___Forms.TabelaTarefas();
            this.testesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testesDataSet = new To_Do_List___Forms.TestesDataSet();
            this.tb_TaskTittle = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tarefasTableAdapter = new To_Do_List___Forms.TabelaTarefasTableAdapters.TarefasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_IDTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tittle
            // 
            this.lb_tittle.AutoSize = true;
            this.lb_tittle.BackColor = System.Drawing.Color.White;
            this.lb_tittle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tittle.Location = new System.Drawing.Point(229, 9);
            this.lb_tittle.Name = "lb_tittle";
            this.lb_tittle.Size = new System.Drawing.Size(156, 28);
            this.lb_tittle.TabIndex = 1;
            this.lb_tittle.Text = "BEM - VINDO !";
            this.lb_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AllowUserToOrderColumns = true;
            this.dataGridViewTable.AutoGenerateColumns = false;
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTasksDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridViewTable.DataSource = this.tarefasBindingSource;
            this.dataGridViewTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTable.Location = new System.Drawing.Point(17, 469);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTable.Size = new System.Drawing.Size(599, 281);
            this.dataGridViewTable.TabIndex = 6;
            this.dataGridViewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellContentClick);
            this.dataGridViewTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTable_CellMouseClick);
            this.dataGridViewTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTable_CellMouseDoubleClick);
            // 
            // iDTasksDataGridViewTextBoxColumn
            // 
            this.iDTasksDataGridViewTextBoxColumn.DataPropertyName = "ID_Tasks";
            this.iDTasksDataGridViewTextBoxColumn.HeaderText = "ID_Tasks";
            this.iDTasksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTasksDataGridViewTextBoxColumn.Name = "iDTasksDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // tarefasBindingSource
            // 
            this.tarefasBindingSource.DataMember = "Tarefas";
            this.tarefasBindingSource.DataSource = this.tabelaTarefas;
            // 
            // tabelaTarefas
            // 
            this.tabelaTarefas.DataSetName = "TabelaTarefas";
            this.tabelaTarefas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testesDataSetBindingSource
            // 
            this.testesDataSetBindingSource.DataSource = this.testesDataSet;
            this.testesDataSetBindingSource.Position = 0;
            // 
            // testesDataSet
            // 
            this.testesDataSet.DataSetName = "TestesDataSet";
            this.testesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_TaskTittle
            // 
            this.tb_TaskTittle.Location = new System.Drawing.Point(35, 203);
            this.tb_TaskTittle.Name = "tb_TaskTittle";
            this.tb_TaskTittle.ReadOnly = true;
            this.tb_TaskTittle.Size = new System.Drawing.Size(581, 26);
            this.tb_TaskTittle.TabIndex = 7;
            this.tb_TaskTittle.TextChanged += new System.EventHandler(this.tb_TaskTittle_TextChanged);
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(35, 262);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ReadOnly = true;
            this.tb_Description.Size = new System.Drawing.Size(581, 65);
            this.tb_Description.TabIndex = 8;
            this.tb_Description.TextChanged += new System.EventHandler(this.tb_Description_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(35, 344);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 45);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(182, 344);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 45);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(365, 344);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 45);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Deletar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(516, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Título da tarefa";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descrição da Tarefa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "TAREFAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tarefasTableAdapter
            // 
            this.tarefasTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Tarefa";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_IDTask
            // 
            this.lb_IDTask.AutoSize = true;
            this.lb_IDTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDTask.Location = new System.Drawing.Point(36, 123);
            this.lb_IDTask.Name = "lb_IDTask";
            this.lb_IDTask.Size = new System.Drawing.Size(10, 24);
            this.lb_IDTask.TabIndex = 18;
            this.lb_IDTask.Text = "\r\n";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 787);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_IDTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_TaskTittle);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.lb_tittle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tittle;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.TextBox tb_TaskTittle;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource testesDataSetBindingSource;
        private TestesDataSet testesDataSet;
        private TabelaTarefas tabelaTarefas;
        private System.Windows.Forms.BindingSource tarefasBindingSource;
        private TabelaTarefasTableAdapters.TarefasTableAdapter tarefasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTasksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_IDTask;
    }
}

