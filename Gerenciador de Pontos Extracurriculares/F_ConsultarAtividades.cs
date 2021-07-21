using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows;
using System.Data.SqlClient;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Projeto
{
    public partial class F_ConsultarAtividades : Form
    {
        public string id_atividade;
        
        public F_ConsultarAtividades()
        {
            InitializeComponent();
        }

        private void dgv_atividade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_atividade.Rows[e.RowIndex];
                tb_descricao.Text = row.Cells[6].Value.ToString();

                id_atividade = row.Cells[0].Value.ToString();
            }
        }

        public void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Atividade A = new Atividade();
            A.n_matricula = int.Parse(tb_matricula.Text);
            dgv_atividade.DataSource = Banco.consultaAtiv(A);
            dgv_atividade.Columns[0].Width = 75;
            dgv_atividade.Columns[1].Width = 75;
            dgv_atividade.Columns[2].Width = 130;
            dgv_atividade.Columns[3].Width = 75;
            dgv_atividade.Columns[4].Width = 55;
            dgv_atividade.Columns[5].Width = 95;
            dgv_atividade.Columns[6].Width = 140;

            if (dgv_atividade.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma atividade foi encontrada");
            }
        }

        private void F_ConsultarAtividades_Load(object sender, EventArgs e)
        {
            Atividade A = new Atividade();
            dgv_atividade.DataSource = Banco.consultaAtiv(A);
            dgv_atividade.Columns[0].Width = 75;
            dgv_atividade.Columns[1].Width = 75;
            dgv_atividade.Columns[2].Width = 130;
            dgv_atividade.Columns[3].Width = 75;
            dgv_atividade.Columns[4].Width = 55;
            dgv_atividade.Columns[5].Width = 95;
            dgv_atividade.Columns[6].Width = 140;
        }

        private void dgv_atividade_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_nova_Click(object sender, EventArgs e)
        {
            F_RegistrarAtividade registrarAtividade = new F_RegistrarAtividade();
            registrarAtividade.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_atividade == null)
            {
                MessageBox.Show("Nenhuma atividade foi selecionada!");
            }

            else
            {
                F_EditarAtividade editarAtividade = new F_EditarAtividade(id_atividade);
                editarAtividade.ShowDialog();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_atividade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_atividade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
