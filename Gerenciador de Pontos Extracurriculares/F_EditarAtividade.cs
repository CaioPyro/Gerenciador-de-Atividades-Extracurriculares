using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;


namespace Projeto
{
    public partial class F_EditarAtividade : Form
    {
        int valorAtual;
        string pdfcheck;
        
        public string id_atividade;

        public F_EditarAtividade(string id)
        {
            InitializeComponent();
            valorAtual = 0;
            pdfcheck = "";
            id_atividade = id;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade();

            if (tbx_certificado.Text == "")
            {
                string queryAtualizarAtividadeVazio = String.Format(@"
                UPDATE
                    tb_atividade
                SET
                    id_atividade= '{0}',
                    n_matricula= '{1}',
                    t_nomeAtividade= '{2}',
                    n_data= '{3}',
                    n_pontosObtidos= '{4}',
                    t_tipoAtividade= '{5}',
                    t_descricao= '{6}',
                    t_nomeCertificado= 'Certificado não cadastrado',
                    a_pdf= NULL
                WHERE
                    id_atividade= '{7}'", tb_id.Text, tb_matricula.Text, tb_nomeAtividade.Text, tb_data.Text, tb_pontosObtidos.Text, tb_tipoAtividade.Text, tb_descricao.Text, tb_id.Text);
                Banco.dml(queryAtualizarAtividadeVazio);
                MessageBox.Show("Atividade alterada com sucesso");
            }

            if (tbx_certificado.Text == "Certificado não cadastrado")
            {
                string queryAtualizarAtividadeSemCertificado = String.Format(@"
                UPDATE
                    tb_atividade
                SET
                    id_atividade= '{0}',
                    n_matricula= '{1}',
                    t_nomeAtividade= '{2}',
                    n_data= '{3}',
                    n_pontosObtidos= '{4}',
                    t_tipoAtividade= '{5}',
                    t_descricao= '{6}',
                    t_nomeCertificado= '{7}'
                WHERE
                    id_atividade= '{8}'", tb_id.Text, tb_matricula.Text, tb_nomeAtividade.Text, tb_data.Text, tb_pontosObtidos.Text, tb_tipoAtividade.Text, tb_descricao.Text, tbx_certificado.Text, tb_id.Text);

                atividade.id_atividade = int.Parse(tb_id.Text);
                atividade.n_matricula = int.Parse(tb_matricula.Text);
                atividade.t_nomeAtividade = tb_nomeAtividade.Text;
                atividade.n_data = tb_data.Text;
                atividade.n_pontosObtidos = int.Parse(tb_pontosObtidos.Text);
                atividade.t_tipoAtividade = tb_tipoAtividade.Text;
                atividade.t_descricao = tb_descricao.Text;
                //Banco.dml(queryAtualizarAtividadeSemCertificado);
                Banco.editarAtividadeSemCertificado(atividade);
            }

            if (tbx_certificado.Text != "Certificado não cadastrado" && tbx_certificado.Text != "")
            {
                if (pdfcheck == tbx_certificado.Text)
                {
                    string queryAtualizarAtividadeComCertificado = String.Format(@"
                    UPDATE
                        tb_atividade
                    SET
                        id_atividade= '{0}',
                        n_matricula= '{1}',
                        t_nomeAtividade= '{2}',
                        n_data= '{3}',
                        n_pontosObtidos= '{4}',
                        t_tipoAtividade= '{5}',
                        t_descricao= '{6}'
                    WHERE
                        id_atividade= '{7}'", tb_id.Text, tb_matricula.Text, tb_nomeAtividade.Text, tb_data.Text, tb_pontosObtidos.Text, tb_tipoAtividade.Text, tb_descricao.Text, tb_id.Text);
                    Banco.dml(queryAtualizarAtividadeComCertificado);
                    MessageBox.Show("Atividade alterada com sucesso");
                }

                if (pdfcheck != tbx_certificado.Text && tbx_certificado.Text != "")
                {
                    atividade.id_atividade = int.Parse(tb_id.Text);
                    atividade.n_matricula = int.Parse(tb_matricula.Text);
                    atividade.t_nomeAtividade = tb_nomeAtividade.Text;
                    atividade.n_data = tb_data.Text;
                    atividade.n_pontosObtidos = int.Parse(tb_pontosObtidos.Text);
                    atividade.t_tipoAtividade = tb_tipoAtividade.Text;
                    atividade.t_descricao = tb_descricao.Text;
                    atividade.t_nomeCertificado = tbx_certificado.Text;
                    atividade.a_pdf = tbx_certificado.Text;
                
                    Banco.editarAtividadeComCertificado(atividade);
                }
                
            }

            if (valorAtual > int.Parse(tb_pontosObtidos.Text))
            {
                int res;
                res = valorAtual - int.Parse(tb_pontosObtidos.Text);
                string queryPontos = String.Format(@"
                UPDATE
                    tb_aluno
                SET
                    n_pontos = (n_pontos - '{0}')
                WHERE
                    n_matricula = {1}", res, tb_matricula.Text);
                Banco.dml(queryPontos);
            }

            if (valorAtual < int.Parse(tb_pontosObtidos.Text))
            {
                int res;
                res = int.Parse(tb_pontosObtidos.Text) - valorAtual;
                string queryPontos = String.Format(@"
                UPDATE
                    tb_aluno
                SET
                    n_pontos = (n_pontos + '{0}')
                WHERE
                    n_matricula = {1}", res, tb_matricula.Text);
                Banco.dml(queryPontos);
            }

            //MessageBox.Show("Alterações Salvas");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_EditarAtividade_Load(object sender, EventArgs e)
        {
            Atividade id = new Atividade();
            id.id_atividade = int.Parse(id_atividade);
            tb_id.Text = Banco.consultaAtivID(id).Rows[0].Field<Int64>("ID da Atividade").ToString();
            tb_matricula.Text = Banco.consultaAtivID(id).Rows[0].Field<Int64>("Matrícula do Aluno").ToString();
            tb_nomeAtividade.Text = Banco.consultaAtivID(id).Rows[0].Field<string>("Nome da Atividade").ToString();
            tb_data.Text = Banco.consultaAtivID(id).Rows[0].Field<string>("Data").ToString();
            tb_pontosObtidos.Text = Banco.consultaAtivID(id).Rows[0].Field<Int64>("Pontos Obtidos").ToString();
            tb_tipoAtividade.Text = Banco.consultaAtivID(id).Rows[0].Field<string>("Tipo de Atividade").ToString();
            tb_descricao.Text = Banco.consultaAtivID(id).Rows[0].Field<string>("Descrição").ToString();
            tbx_certificado.Text = Banco.consultaAtivID(id).Rows[0].Field<string>("Certificado").ToString();
            valorAtual = int.Parse(tb_pontosObtidos.Text);
            pdfcheck = tbx_certificado.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja fazer essa exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.excluirAtividade(tb_id.Text);
                MessageBox.Show("Atividade Excluída!");

                string queryPontos = String.Format(@"
                UPDATE
                    tb_aluno
                SET
                    n_pontos = (n_pontos - '{0}')
                WHERE
                    n_matricula = {1}", tb_pontosObtidos.Text, tb_matricula.Text);
                Banco.dml(queryPontos);
                
                tb_id.Clear();
                tb_matricula.Clear();
                tb_nomeAtividade.Clear();
                tb_data.Clear();
                tb_pontosObtidos.Clear();
                tb_tipoAtividade.Clear();
                tb_descricao.Clear();
                tbx_certificado.Clear();
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
                tbx_certificado.Text = pdf.FileName;
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Banco.abrirCertificado(id_atividade);
        }
    }
}
