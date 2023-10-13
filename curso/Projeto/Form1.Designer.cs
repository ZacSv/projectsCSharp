namespace Projeto
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.TEXTO = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_mensagemLogin = new System.Windows.Forms.Label();
            this.lb_accept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(147, 222);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(103, 33);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEXTO
            // 
            this.TEXTO.AutoSize = true;
            this.TEXTO.Location = new System.Drawing.Point(37, 373);
            this.TEXTO.Name = "TEXTO";
            this.TEXTO.Size = new System.Drawing.Size(0, 16);
            this.TEXTO.TabIndex = 1;
            this.TEXTO.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(34, 117);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(216, 22);
            this.tb_1.TabIndex = 2;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(34, 166);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(216, 22);
            this.tb_2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // lb_mensagemLogin
            // 
            this.lb_mensagemLogin.AutoSize = true;
            this.lb_mensagemLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_mensagemLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensagemLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_mensagemLogin.Location = new System.Drawing.Point(35, 277);
            this.lb_mensagemLogin.Name = "lb_mensagemLogin";
            this.lb_mensagemLogin.Size = new System.Drawing.Size(0, 29);
            this.lb_mensagemLogin.TabIndex = 7;
            // 
            // lb_accept
            // 
            this.lb_accept.AutoSize = true;
            this.lb_accept.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_accept.Enabled = false;
            this.lb_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accept.Location = new System.Drawing.Point(0, 286);
            this.lb_accept.Name = "lb_accept";
            this.lb_accept.Size = new System.Drawing.Size(297, 20);
            this.lb_accept.TabIndex = 8;
            this.lb_accept.Text = "LOGIN EFETUADO COM SUCESSO !";
            this.lb_accept.Visible = false;
            this.lb_accept.Click += new System.EventHandler(this.lb_accept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 411);
            this.Controls.Add(this.lb_accept);
            this.Controls.Add(this.lb_mensagemLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.TEXTO);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label TEXTO;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_mensagemLogin;
        private System.Windows.Forms.Label lb_accept;
    }
}

