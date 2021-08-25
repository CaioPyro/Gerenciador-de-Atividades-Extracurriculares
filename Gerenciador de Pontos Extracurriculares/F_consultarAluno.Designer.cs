namespace Projeto
{
    partial class F_consultarAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_consultarAluno));
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_acesso = new System.Windows.Forms.ComboBox();
            this.tb_curso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.tb_pontos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tipo de Acesso";
            // 
            // cbx_acesso
            // 
            this.cbx_acesso.FormattingEnabled = true;
            this.cbx_acesso.Items.AddRange(new object[] {
            "Aluno",
            "Coordenador"});
            this.cbx_acesso.Location = new System.Drawing.Point(240, 383);
            this.cbx_acesso.Name = "cbx_acesso";
            this.cbx_acesso.Size = new System.Drawing.Size(152, 21);
            this.cbx_acesso.TabIndex = 19;
            // 
            // tb_curso
            // 
            this.tb_curso.Location = new System.Drawing.Point(243, 329);
            this.tb_curso.Name = "tb_curso";
            this.tb_curso.Size = new System.Drawing.Size(149, 20);
            this.tb_curso.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Curso";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(243, 277);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(149, 20);
            this.tb_cpf.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPF";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(243, 225);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(149, 20);
            this.tb_matricula.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Matrícula";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(243, 170);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(428, 20);
            this.tb_nome.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
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
            this.btn_fechar.Location = new System.Drawing.Point(959, 497);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(108, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.btn_excluir.Location = new System.Drawing.Point(351, 497);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(108, 30);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.DarkRed;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Location = new System.Drawing.Point(68, 497);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(108, 30);
            this.btn_novo.TabIndex = 1;
            this.btn_novo.Text = "Novo Aluno";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
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
            this.btn_salvar.Location = new System.Drawing.Point(209, 497);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(108, 30);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.AllowUserToAddRows = false;
            this.dgv_aluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.EnableHeadersVisualStyles = false;
            this.dgv_aluno.Location = new System.Drawing.Point(677, 207);
            this.dgv_aluno.MultiSelect = false;
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.ReadOnly = true;
            this.dgv_aluno.RowHeadersVisible = false;
            this.dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aluno.Size = new System.Drawing.Size(434, 253);
            this.dgv_aluno.TabIndex = 22;
            this.dgv_aluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aluno_CellContentClick);
            this.dgv_aluno.SelectionChanged += new System.EventHandler(this.dgv_aluno_SelectionChanged);
            // 
            // tb_pontos
            // 
            this.tb_pontos.Location = new System.Drawing.Point(240, 436);
            this.tb_pontos.Name = "tb_pontos";
            this.tb_pontos.Size = new System.Drawing.Size(149, 20);
            this.tb_pontos.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total de Pontos";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.DarkRed;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foto.Location = new System.Drawing.Point(17, 171);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(110, 130);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 25;
            this.foto.TabStop = false;
            // 
            // F_consultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.Alunos_Cadastrados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 598);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.tb_pontos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_acesso);
            this.Controls.Add(this.tb_curso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_consultarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Aluno";
            this.Load += new System.EventHandler(this.F_consultarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_acesso;
        private System.Windows.Forms.TextBox tb_curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox tb_pontos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox foto;
    }
}