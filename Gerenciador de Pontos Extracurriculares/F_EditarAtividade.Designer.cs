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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_atividade = new System.Windows.Forms.DataGridView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nomeAtividade
            // 
            this.tb_nomeAtividade.Location = new System.Drawing.Point(12, 126);
            this.tb_nomeAtividade.Name = "tb_nomeAtividade";
            this.tb_nomeAtividade.Size = new System.Drawing.Size(349, 20);
            this.tb_nomeAtividade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome da Atividade";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 178);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(110, 20);
            this.tb_data.TabIndex = 5;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data";
            // 
            // tb_pontosObtidos
            // 
            this.tb_pontosObtidos.Location = new System.Drawing.Point(12, 238);
            this.tb_pontosObtidos.Name = "tb_pontosObtidos";
            this.tb_pontosObtidos.Size = new System.Drawing.Size(110, 20);
            this.tb_pontosObtidos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pontos Obtidos";
            // 
            // tb_tipoAtividade
            // 
            this.tb_tipoAtividade.Location = new System.Drawing.Point(12, 298);
            this.tb_tipoAtividade.Name = "tb_tipoAtividade";
            this.tb_tipoAtividade.Size = new System.Drawing.Size(349, 20);
            this.tb_tipoAtividade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo de Atividade";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(12, 355);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(349, 71);
            this.tb_descricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Descrição";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 54);
            this.panel1.TabIndex = 35;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(162, 15);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(110, 25);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir Atividade";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(563, 15);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(96, 25);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 15);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(110, 25);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(12, 75);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(349, 20);
            this.tb_matricula.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Matrícula do Aluno";
            // 
            // dgv_atividade
            // 
            this.dgv_atividade.AllowUserToAddRows = false;
            this.dgv_atividade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_atividade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_atividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atividade.EnableHeadersVisualStyles = false;
            this.dgv_atividade.Location = new System.Drawing.Point(385, 149);
            this.dgv_atividade.MultiSelect = false;
            this.dgv_atividade.Name = "dgv_atividade";
            this.dgv_atividade.ReadOnly = true;
            this.dgv_atividade.RowHeadersVisible = false;
            this.dgv_atividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atividade.Size = new System.Drawing.Size(274, 166);
            this.dgv_atividade.TabIndex = 38;
            this.dgv_atividade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellContentClick);
            this.dgv_atividade.SelectionChanged += new System.EventHandler(this.dgv_atividade_SelectionChanged);
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(12, 26);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(349, 20);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID da Atividade";
            // 
            // F_EditarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 502);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_atividade);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_EditarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_EditarAtividade";
            this.Load += new System.EventHandler(this.F_EditarAtividade_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_atividade;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_excluir;
    }
}