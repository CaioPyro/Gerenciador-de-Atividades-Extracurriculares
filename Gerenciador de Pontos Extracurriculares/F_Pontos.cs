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
    public partial class F_Pontos : Form
    {
        public string matricula;

        public F_Pontos(string m)
        {
            InitializeComponent();

            matricula = m;
        }

        private void F_Pontos_Load(object sender, EventArgs e)
        {
            string queryConsultarPontos = String.Format(@"
                SELECT 
                    t_nomeAtividade AS 'Nome da Atividade',
                    n_data AS 'Data',
                    n_pontosObtidos AS 'Pontos Obtidos'
                FROM
                    tb_atividade
                WHERE
                    n_matricula = {0}", matricula);

            string queryConsultarPontosTotais = String.Format(@"SELECT n_pontos FROM tb_aluno WHERE n_matricula = {0}", matricula);

            dgv_atividade.DataSource = Banco.consulta(queryConsultarPontos);
            dgv_atividade.Columns[0].Width = 190;
            dgv_atividade.Columns[1].Width = 112;
            dgv_atividade.Columns[2].Width = 112;

            tb_pontos.Text = Banco.consulta(queryConsultarPontosTotais).Rows[0].Field<Int64>("n_pontos").ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_atividade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_pontos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
