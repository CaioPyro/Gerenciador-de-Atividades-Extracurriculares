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
    public partial class F_consultarAluno : Form
    {
        public Int64 matricula1;
        public Int64 matricula;

        public F_consultarAluno()
        {
            InitializeComponent();
            matricula1 = 0;
            matricula = 0;
        }

        private void F_consultarAluno_Load(object sender, EventArgs e)
        {
            dgv_aluno.DataSource = Banco.ObterAlunosMatricula();
            dgv_aluno.Columns[0].Width = 130;
            dgv_aluno.Columns[1].Width = 301;
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosAlunos(vid);
                tb_matricula.Text = dt.Rows[0].Field<Int64>("n_matricula").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                tb_cpf.Text = dt.Rows[0].Field<Int64>("n_cpf").ToString();
                tb_curso.Text = dt.Rows[0].Field<string>("t_curso").ToString();
                cbx_acesso.Text = dt.Rows[0].Field<string>("t_acesso").ToString();
                tb_pontos.Text = dt.Rows[0].Field<Int64>("n_pontos").ToString();
                matricula1 = int.Parse(tb_matricula.Text);

                byte[] img = (byte[])dt.Rows[0][6];
                MemoryStream ms = new MemoryStream(img);
                foto.Image = Image.FromStream(ms);
            }
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_cadastroAluno f_cadastroAluno = new F_cadastroAluno();
            f_cadastroAluno.ShowDialog();
            dgv_aluno.DataSource = Banco.ObterAlunosMatricula();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_aluno.SelectedRows[0].Index;
            Aluno a = new Aluno();
            a.n_matricula = int.Parse(tb_matricula.Text);
            matricula = a.n_matricula;
            a.n_matricula1 = matricula1;
            a.t_nome = tb_nome.Text;
            a.n_cpf = int.Parse(tb_cpf.Text);
            a.t_curso = tb_curso.Text;
            a.t_acesso = cbx_acesso.Text;
            a.n_pontos = int.Parse(tb_pontos.Text);
            Banco.atualizarAluno(a);
            Banco.alterarMatricula(matricula,matricula1);
            dgv_aluno.DataSource = Banco.ObterAlunosMatricula();
            dgv_aluno.CurrentCell = dgv_aluno[0, linha];
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja fazer essa exclusão?","Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.excluirAluno(tb_matricula.Text);
                Banco.excluirAtividadeAluno(tb_matricula.Text);
                MessageBox.Show("Exclusão Concluída!");
                dgv_aluno.DataSource = Banco.ObterAlunosMatricula();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_aluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
