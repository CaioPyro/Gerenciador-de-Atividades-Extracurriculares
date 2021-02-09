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
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade();
            atividade.n_matricula = int.Parse(tb_matricula.Text);
            atividade.t_nomeAtividade = tb_nomeAtividade.Text;
            atividade.n_data = Convert.ToDateTime(tb_data.Text);
            atividade.n_pontosObtidos = int.Parse(tb_pontos.Text);
            atividade.t_tipoAtividade = tb_tipoAtividade.Text;
            atividade.t_descricao = tb_descricao.Text;

            Banco.NovaAtividade(atividade);
        }
    }
}
