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
    public partial class Menu_Coordenador : Form
    {
        public Menu_Coordenador()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_cadastroAluno cadastroAluno = new F_cadastroAluno();
            cadastroAluno.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Coordenador_Load(object sender, EventArgs e)
        {

        }

        private void consultarAluno_Click(object sender, EventArgs e)
        {
            F_consultarAluno consultarAluno = new F_consultarAluno();
            consultarAluno.ShowDialog();
        }

        private void registrarAtividade_Click(object sender, EventArgs e)
        {
            F_RegistrarAtividade registrarAtividade = new F_RegistrarAtividade();
            registrarAtividade.ShowDialog();
        }
    }
}
