﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class F_ConsultarAtividadesAluno : Form
    {
        public string matricula;
        public string id_atividade;
        public string certificado;
        
        public F_ConsultarAtividadesAluno(string m)
        {
            InitializeComponent();
            id_atividade = "";
            matricula = m;
            certificado = "";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_ConsultarAtividadesAluno_Load(object sender, EventArgs e)
        {
            Atividade a = new Atividade();
            a.n_matricula = int.Parse(matricula);
            dgv_atividade.DataSource = Banco.consultaAtiv(a);
            dgv_atividade.Columns[0].Width = 75;
            dgv_atividade.Columns[1].Width = 75;
            dgv_atividade.Columns[2].Width = 130;
            dgv_atividade.Columns[3].Width = 75;
            dgv_atividade.Columns[4].Width = 55;
            dgv_atividade.Columns[5].Width = 95;
            dgv_atividade.Columns[6].Width = 95;
            dgv_atividade.Columns[7].Width = 95;
        }

        private void dgv_atividade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_atividade.Rows[e.RowIndex];
            tb_descricao.Text = row.Cells[6].Value.ToString();
            id_atividade = row.Cells[0].Value.ToString();
            certificado = row.Cells[7].Value.ToString();
        }

        private void btn_certificado_Click(object sender, EventArgs e)
        {
            if (id_atividade == "")
            {
                MessageBox.Show("Nenhuma atividade foi selecionada!");
            }

            else
            {
                if (certificado == "Certificado não cadastrado")
                {
                    MessageBox.Show("Certificado não cadastrado");
                }

                else
                {
                    Banco.abrirCertificado(id_atividade);
                }                
            }
        }
    }
}
