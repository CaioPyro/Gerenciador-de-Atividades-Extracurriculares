using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Projeto
{
    public partial class F_dadosAluno : Form
    {
        public string matricula;

        public F_dadosAluno(string m)
        {
            InitializeComponent();

            matricula = m;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_dadosAluno_Load(object sender, EventArgs e)
        {
            string queryConsultarDadosAluno = String.Format(@"
                SELECT n_matricula, t_nome, n_cpf, t_curso, t_acesso FROM tb_aluno WHERE n_matricula = {0}", matricula);
            
            tb_nome.Text = Banco.consulta(queryConsultarDadosAluno).Rows[0].Field<string>("t_nome").ToString();
            tb_matricula.Text = Banco.consulta(queryConsultarDadosAluno).Rows[0].Field<Int64>("n_matricula").ToString();
            tb_cpf.Text = Banco.consulta(queryConsultarDadosAluno).Rows[0].Field<Int64>("n_cpf").ToString();
            tb_curso.Text = Banco.consulta(queryConsultarDadosAluno).Rows[0].Field<string>("t_curso").ToString();
            tb_acesso.Text = Banco.consulta(queryConsultarDadosAluno).Rows[0].Field<string>("t_acesso").ToString();

            DataTable dt = new DataTable();
            dt = Banco.ObterDadosAlunos(tb_matricula.Text);
            byte[] img = (byte[])dt.Rows[0][6];
            MemoryStream ms = new MemoryStream(img);
            foto.Image = Image.FromStream(ms);
        }

        private void btn_alterarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog png = new OpenFileDialog();
            png.Filter = "png(*.png)|*.png";

            if (png.ShowDialog() == DialogResult.OK)
            {
                Image image;
                image = Image.FromFile(png.FileName);
                foto.Image = image;

                ImageConverter converter = new ImageConverter();
                Aluno aluno = new Aluno();
                aluno.a_foto = (byte[])converter.ConvertTo(image, typeof(byte[]));
                aluno.n_matricula = int.Parse(tb_matricula.Text);
                Banco.alterarImagem(aluno);
            }
        }
    }
}
