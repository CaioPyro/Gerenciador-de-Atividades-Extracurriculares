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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RegistrarAtividade));
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_novaAtividade = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tbx_buscaCertificado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscarCertificado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula do Aluno";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(220, 197);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(347, 20);
            this.tb_matricula.TabIndex = 1;
            // 
            // tb_nomeAtividade
            // 
            this.tb_nomeAtividade.Location = new System.Drawing.Point(220, 252);
            this.tb_nomeAtividade.Name = "tb_nomeAtividade";
            this.tb_nomeAtividade.Size = new System.Drawing.Size(347, 20);
            this.tb_nomeAtividade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da Atividade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(219, 301);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(132, 20);
            this.tb_data.TabIndex = 3;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_pontos
            // 
            this.tb_pontos.Location = new System.Drawing.Point(219, 353);
            this.tb_pontos.Name = "tb_pontos";
            this.tb_pontos.Size = new System.Drawing.Size(348, 20);
            this.tb_pontos.TabIndex = 4;
            this.tb_pontos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pontos Obtidos";
            // 
            // tb_tipoAtividade
            // 
            this.tb_tipoAtividade.Location = new System.Drawing.Point(764, 196);
            this.tb_tipoAtividade.Name = "tb_tipoAtividade";
            this.tb_tipoAtividade.Size = new System.Drawing.Size(348, 20);
            this.tb_tipoAtividade.TabIndex = 5;
            this.tb_tipoAtividade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de Atividade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(764, 246);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(348, 78);
            this.tb_descricao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descrição";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(999, 448);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 31);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_novaAtividade
            // 
            this.btn_novaAtividade.BackColor = System.Drawing.Color.DarkRed;
            this.btn_novaAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaAtividade.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_novaAtividade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_novaAtividade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_novaAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novaAtividade.ForeColor = System.Drawing.Color.White;
            this.btn_novaAtividade.Location = new System.Drawing.Point(219, 448);
            this.btn_novaAtividade.Name = "btn_novaAtividade";
            this.btn_novaAtividade.Size = new System.Drawing.Size(113, 31);
            this.btn_novaAtividade.TabIndex = 8;
            this.btn_novaAtividade.Text = "Nova Atividade";
            this.btn_novaAtividade.UseVisualStyleBackColor = false;
            this.btn_novaAtividade.Click += new System.EventHandler(this.btn_novaAtividade_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(370, 448);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(113, 31);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar ";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tbx_buscaCertificado
            // 
            this.tbx_buscaCertificado.Location = new System.Drawing.Point(764, 354);
            this.tbx_buscaCertificado.Name = "tbx_buscaCertificado";
            this.tbx_buscaCertificado.Size = new System.Drawing.Size(348, 20);
            this.tbx_buscaCertificado.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Certificado";
            // 
            // btn_buscarCertificado
            // 
            this.btn_buscarCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarCertificado.Location = new System.Drawing.Point(1119, 354);
            this.btn_buscarCertificado.Name = "btn_buscarCertificado";
            this.btn_buscarCertificado.Size = new System.Drawing.Size(27, 21);
            this.btn_buscarCertificado.TabIndex = 14;
            this.btn_buscarCertificado.Text = "...";
            this.btn_buscarCertificado.UseVisualStyleBackColor = true;
            this.btn_buscarCertificado.Click += new System.EventHandler(this.btn_buscarCertificado_Click);
            // 
            // F_RegistrarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.Registro_de_Atividades;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 564);
            this.Controls.Add(this.btn_buscarCertificado);
            this.Controls.Add(this.tbx_buscaCertificado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_novaAtividade);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_salvar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RegistrarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Atividade";
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
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_novaAtividade;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tbx_buscaCertificado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buscarCertificado;
    }
}