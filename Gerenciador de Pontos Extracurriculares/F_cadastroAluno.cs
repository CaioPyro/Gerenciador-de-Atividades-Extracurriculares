using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Aluno aluno = new Aluno();
            aluno.t_nome = tb_nome.Text;
            aluno.n_matricula = int.Parse(tb_matricula.Text);
            aluno.n_cpf = int.Parse(tb_cpf.Text);
            aluno.t_curso = tb_curso.Text;
            aluno.t_acesso = cbx_acesso.Text;

            Banco.NovoAluno(aluno);
            MessageBox.Show("Aluno Cadastrado");

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_matricula.Clear();
            tb_curso.Clear();
            tb_cpf.Clear();
            cbx_acesso.Text = "";
        }

    }
}
