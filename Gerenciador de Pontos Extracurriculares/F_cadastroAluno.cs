using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class F_cadastroAluno : Form
    {
        public F_cadastroAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_cadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" || tb_matricula.Text == "" || tb_cpf.Text == "" || tb_curso.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios!");
            }

            else
            {
                Image img = foto.Image;
                ImageConverter converter = new ImageConverter();


                Aluno aluno = new Aluno();
                aluno.t_nome = tb_nome.Text;
                aluno.n_matricula = Int64.Parse(tb_matricula.Text);
                aluno.n_cpf = Int64.Parse(tb_cpf.Text);
                aluno.t_curso = tb_curso.Text;
                aluno.t_acesso = cbx_acesso.Text;
                aluno.a_foto = (byte[])converter.ConvertTo(img, typeof(byte[]));
                
                Banco.NovoAluno(aluno);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_matricula.Clear();
            tb_curso.Text = "";
            tb_cpf.Clear();
            cbx_acesso.Text = "";
        }

    }
}
