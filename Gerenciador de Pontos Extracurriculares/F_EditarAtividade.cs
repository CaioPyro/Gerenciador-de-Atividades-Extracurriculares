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
    public partial class F_EditarAtividade : Form
    {
        int valorAtual;
        
        public F_EditarAtividade()
        {
            InitializeComponent();
            valorAtual = 0;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string queryAtualizarAtividade = String.Format(@"
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
                    id_atividade= '{7}'", tb_id.Text, tb_matricula.Text, tb_nomeAtividade.Text, (tb_data.Text), tb_pontosObtidos.Text, tb_tipoAtividade.Text, tb_descricao.Text, tb_id.Text);
            Banco.dml(queryAtualizarAtividade);

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

            MessageBox.Show("Alterações Salvas");
            Atividade a = new Atividade();
            dgv_atividade.DataSource = Banco.consultaAtivID(a);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_EditarAtividade_Load(object sender, EventArgs e)
        {
            Atividade A = new Atividade();
            dgv_atividade.DataSource = Banco.consultaAtivID(A);
            dgv_atividade.Columns[0].Width = 60;
            dgv_atividade.Columns[1].Width = 60;
            dgv_atividade.Columns[2].Width = 130;
            dgv_atividade.Columns[3].Width = 75;
            dgv_atividade.Columns[4].Width = 55;
            dgv_atividade.Columns[5].Width = 95;
            dgv_atividade.Columns[6].Width = 140;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Atividade A = new Atividade();
            A.id_atividade = int.Parse(tb_pesquisar.Text);
            dgv_atividade.DataSource = Banco.consultaAtivID(A);
            dgv_atividade.Columns[0].Width = 60;
            dgv_atividade.Columns[1].Width = 60;
            dgv_atividade.Columns[2].Width = 130;
            dgv_atividade.Columns[3].Width = 75;
            dgv_atividade.Columns[4].Width = 55;
            dgv_atividade.Columns[5].Width = 95;
            dgv_atividade.Columns[6].Width = 140;
        }

        private void dgv_atividade_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_atividade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_atividade.Rows[e.RowIndex];

                tb_id.Text = row.Cells[0].Value.ToString();
                tb_matricula.Text = row.Cells[1].Value.ToString();
                tb_nomeAtividade.Text = row.Cells[2].Value.ToString();
                tb_data.Text = row.Cells[3].Value.ToString();
                tb_pontosObtidos.Text = row.Cells[4].Value.ToString();
                tb_tipoAtividade.Text = row.Cells[5].Value.ToString();
                tb_descricao.Text = row.Cells[6].Value.ToString();
                valorAtual = int.Parse(tb_pontosObtidos.Text);
            }
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
                
                Atividade A = new Atividade();
                dgv_atividade.DataSource = Banco.consultaAtivID(A);
                tb_pesquisar.Clear();
                tb_id.Clear();
                tb_matricula.Clear();
                tb_nomeAtividade.Clear();
                tb_data.Clear();
                tb_pontosObtidos.Clear();
                tb_tipoAtividade.Clear();
                tb_descricao.Clear();
            }
        }

    }
}
