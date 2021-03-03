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
    public partial class F_MenuAluno : Form
    {
        public string matricula;

        public F_MenuAluno(string m)
        {
            InitializeComponent();

            matricula = m;
        }

        private void F_MenuAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_dadosPessoais_Click(object sender, EventArgs e)
        {
            F_dadosAluno f_dadosAluno = new F_dadosAluno(matricula);
            f_dadosAluno.ShowDialog();
        }
    }
}
