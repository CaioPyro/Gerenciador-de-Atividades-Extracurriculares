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
    public partial class F_RegistrarAtividade : Form
    {
        public F_RegistrarAtividade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_novaAtividade_Click(object sender, EventArgs e)
        {
            tb_matricula.Clear();
            tb_nomeAtividade.Clear();
            tb_data.Clear();
            tb_pontos.Clear();
            tb_tipoAtividade.Clear();
            tb_descricao.Clear();
            tbx_buscaCertificado.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade();
            

            if (tb_matricula.Text == "" || tb_nomeAtividade.Text == "" || tb_data.Text == "" || tb_pontos.Text == "" || tb_tipoAtividade.Text == "" || tb_descricao.Text == "")
            {
                MessageBox.Show("Alguns campos não foram preenchidos!");
                return;
            }

            else
            {
                if (tbx_buscaCertificado.Text == "")
                {
                    atividade.n_matricula = int.Parse(tb_matricula.Text);
                    atividade.t_nomeAtividade = tb_nomeAtividade.Text;
                    atividade.n_data = tb_data.Text;
                    atividade.n_pontosObtidos = int.Parse(tb_pontos.Text);
                    atividade.t_tipoAtividade = tb_tipoAtividade.Text;
                    atividade.t_descricao = tb_descricao.Text;
                    Banco.NovaAtividadeSemCertificado(atividade);
                }

                else
                {
                    atividade.n_matricula = int.Parse(tb_matricula.Text);
                    atividade.t_nomeAtividade = tb_nomeAtividade.Text;
                    atividade.n_data = tb_data.Text;
                    atividade.n_pontosObtidos = int.Parse(tb_pontos.Text);
                    atividade.t_tipoAtividade = tb_tipoAtividade.Text;
                    atividade.t_descricao = tb_descricao.Text;
                    atividade.t_nomeCertificado = tbx_buscaCertificado.Text;
                    atividade.a_pdf = tbx_buscaCertificado.Text;
                    Banco.NovaAtividadeComCertificado(atividade);
                
                }   
            }
        }

        private void btn_buscarCertificado_Click(object sender, EventArgs e)
        {
            var retorno = string.Empty;
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.Filter = "pdf(*.pdf)|*.pdf";

            if (pdf.ShowDialog() == DialogResult.OK)
            {
                retorno = pdf.FileName;
                tbx_buscaCertificado.Text = pdf.FileName;
            }
        }
    }
}
