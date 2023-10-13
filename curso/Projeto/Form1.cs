using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
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
            string usuario = tb_1.Text.ToLower();
            string senha = tb_2.Text;
            string[] usuarioBanco = new string[5] {"isac", "maria", "karyne", "joão", "carlos" };
            string senhaBanco = "1234";
            bool usuarioExiste = false;

         for(int i = 0; i < usuarioBanco.Length; i++)
            {
                if(usuario == usuarioBanco[i])
                {
                    usuarioExiste = true;
                }
            }

            if (usuarioExiste)
            {
                if(senha == senhaBanco)
                {
                    lb_accept.Visible = true;
                }
            }
            else
            {
                lb_accept.Text = "Usuário/Senha não encontrados";
                lb_accept.Visible = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_1.Clear();
            tb_2.Clear();
            lb_accept.Visible = false;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_accept_Click(object sender, EventArgs e)
        {

        }
    }
}
