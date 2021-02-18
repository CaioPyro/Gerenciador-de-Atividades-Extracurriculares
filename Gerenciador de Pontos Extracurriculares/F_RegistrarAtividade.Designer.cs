namespace Projeto
{
    partial class F_RegistrarAtividade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_nomeAtividade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.tb_pontos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tipoAtividade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_novaAtividade = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula do Aluno";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(13, 30);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(325, 20);
            this.tb_matricula.TabIndex = 1;
            // 
            // tb_nomeAtividade
            // 
            this.tb_nomeAtividade.Location = new System.Drawing.Point(13, 85);
            this.tb_nomeAtividade.Name = "tb_nomeAtividade";
            this.tb_nomeAtividade.Size = new System.Drawing.Size(325, 20);
            this.tb_nomeAtividade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Atividade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 134);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(110, 20);
            this.tb_data.TabIndex = 5;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_pontos
            // 
            this.tb_pontos.Location = new System.Drawing.Point(12, 186);
            this.tb_pontos.Name = "tb_pontos";
            this.tb_pontos.Size = new System.Drawing.Size(326, 20);
            this.tb_pontos.TabIndex = 7;
            this.tb_pontos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pontos Obtidos";
            // 
            // tb_tipoAtividade
            // 
            this.tb_tipoAtividade.Location = new System.Drawing.Point(12, 242);
            this.tb_tipoAtividade.Name = "tb_tipoAtividade";
            this.tb_tipoAtividade.Size = new System.Drawing.Size(326, 20);
            this.tb_tipoAtividade.TabIndex = 9;
            this.tb_tipoAtividade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Atividade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(12, 292);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(326, 78);
            this.tb_descricao.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_novaAtividade);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 45);
            this.panel1.TabIndex = 12;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(226, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(88, 28);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_novaAtividade
            // 
            this.btn_novaAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaAtividade.Location = new System.Drawing.Point(12, 5);
            this.btn_novaAtividade.Name = "btn_novaAtividade";
            this.btn_novaAtividade.Size = new System.Drawing.Size(88, 28);
            this.btn_novaAtividade.TabIndex = 5;
            this.btn_novaAtividade.Text = "Novo Atividade";
            this.btn_novaAtividade.UseVisualStyleBackColor = true;
            this.btn_novaAtividade.Click += new System.EventHandler(this.btn_novaAtividade_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(119, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(88, 28);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar ";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // F_RegistrarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tipoAtividade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_pontos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeAtividade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RegistrarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Atividade";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_nomeAtividade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.TextBox tb_pontos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tipoAtividade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_novaAtividade;
        private System.Windows.Forms.Button btn_salvar;
    }
}