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
    public partial class F_login : Form
    {
        Menu_Coordenador menu_coordenador;
        DataTable dt = new DataTable();

        public string matricula, cpf, acesso;
        
        public F_login(Menu_Coordenador f)
        {
            InitializeComponent();
            menu_coordenador = f;
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            matricula = tb_matricula.Text;
            cpf = tb_cpf.Text;

            if (matricula == "" || cpf == "")
            {
                MessageBox.Show("Matrícula e ou CPF inválidos!");
                tb_matricula.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_aluno WHERE n_matricula ='"+matricula+"' AND n_cpf ='"+cpf+"'";
            dt = Banco.consulta(sql);

            if (dt.Rows.Count == 1)
            {
                matricula = dt.Rows[0].Field<Int64>("n_matricula").ToString();
                cpf = dt.Rows[0].Field<Int64>("n_cpf").ToString();
                acesso = dt.Rows[0].ItemArray[4].ToString();
                Globais.logado = true;

                if (acesso == "Aluno")
                {
                    F_MenuAluno f_menuAluno = new F_MenuAluno(tb_matricula.Text);
                    f_menuAluno.ShowDialog();
                    this.Hide();
                }
                this.Close();

                if (acesso == "Coordenador")
                {
                    menu_coordenador.ShowDialog(); 
                }

                this.Close();
            }

            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
