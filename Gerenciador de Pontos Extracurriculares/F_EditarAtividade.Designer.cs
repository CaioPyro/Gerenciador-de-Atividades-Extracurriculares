namespace Projeto
{
    partial class F_EditarAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EditarAtividade));
            this.tb_nomeAtividade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pontosObtidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tipoAtividade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_certificado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscarCertificado = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nomeAtividade
            // 
            this.tb_nomeAtividade.Location = new System.Drawing.Point(131, 282);
            this.tb_nomeAtividade.Name = "tb_nomeAtividade";
            this.tb_nomeAtividade.Size = new System.Drawing.Size(406, 21);
            this.tb_nomeAtividade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome da Atividade";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(131, 327);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(128, 21);
            this.tb_data.TabIndex = 5;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data";
            // 
            // tb_pontosObtidos
            // 
            this.tb_pontosObtidos.Location = new System.Drawing.Point(131, 371);
            this.tb_pontosObtidos.Name = "tb_pontosObtidos";
            this.tb_pontosObtidos.Size = new System.Drawing.Size(128, 21);
            this.tb_pontosObtidos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pontos Obtidos";
            // 
            // tb_tipoAtividade
            // 
            this.tb_tipoAtividade.Location = new System.Drawing.Point(657, 187);
            this.tb_tipoAtividade.Name = "tb_tipoAtividade";
            this.tb_tipoAtividade.Size = new System.Drawing.Size(406, 21);
            this.tb_tipoAtividade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo de Atividade";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(657, 245);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(406, 81);
            this.tb_descricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Descrição";
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(308, 488);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(121, 29);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir Atividade";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
            this.btn_fechar.Location = new System.Drawing.Point(1009, 488);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(105, 29);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.btn_salvar.Location = new System.Drawing.Point(137, 488);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(121, 29);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(131, 235);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(406, 21);
            this.tb_matricula.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Matrícula do Aluno";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(131, 187);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(406, 21);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID da Atividade";
            // 
            // tbx_certificado
            // 
            this.tbx_certificado.Location = new System.Drawing.Point(657, 358);
            this.tbx_certificado.Name = "tbx_certificado";
            this.tbx_certificado.Size = new System.Drawing.Size(406, 21);
            this.tbx_certificado.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Certificado";
            // 
            // btn_buscarCertificado
            // 
            this.btn_buscarCertificado.BackColor = System.Drawing.Color.DarkRed;
            this.btn_buscarCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarCertificado.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_buscarCertificado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_buscarCertificado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_buscarCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarCertificado.ForeColor = System.Drawing.Color.White;
            this.btn_buscarCertificado.Location = new System.Drawing.Point(1148, 355);
            this.btn_buscarCertificado.Name = "btn_buscarCertificado";
            this.btn_buscarCertificado.Size = new System.Drawing.Size(70, 26);
            this.btn_buscarCertificado.TabIndex = 46;
            this.btn_buscarCertificado.Text = "Alterar";
            this.btn_buscarCertificado.UseVisualStyleBackColor = false;
            this.btn_buscarCertificado.Click += new System.EventHandler(this.btn_buscarCertificado_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abrir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_abrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.ForeColor = System.Drawing.Color.White;
            this.btn_abrir.Location = new System.Drawing.Point(1070, 355);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(70, 26);
            this.btn_abrir.TabIndex = 47;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = false;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // F_EditarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Projeto.Properties.Resources.edição_de_atividade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 598);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_buscarCertificado);
            this.Controls.Add(this.tbx_certificado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tipoAtividade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pontosObtidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeAtividade);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_EditarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_EditarAtividade";
            this.Load += new System.EventHandler(this.F_EditarAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nomeAtividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pontosObtidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tipoAtividade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox tbx_certificado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buscarCertificado;
        private System.Windows.Forms.Button btn_abrir;
    }
}