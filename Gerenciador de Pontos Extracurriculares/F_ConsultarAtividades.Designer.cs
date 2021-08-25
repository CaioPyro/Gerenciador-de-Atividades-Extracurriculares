namespace Projeto
{
    partial class F_ConsultarAtividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ConsultarAtividades));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.dgv_atividade = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nova = new System.Windows.Forms.Button();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula do Aluno";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(441, 155);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(323, 20);
            this.tb_matricula.TabIndex = 1;
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
            this.dgv_atividade.Location = new System.Drawing.Point(302, 195);
            this.dgv_atividade.MultiSelect = false;
            this.dgv_atividade.Name = "dgv_atividade";
            this.dgv_atividade.ReadOnly = true;
            this.dgv_atividade.RowHeadersVisible = false;
            this.dgv_atividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atividade.Size = new System.Drawing.Size(589, 203);
            this.dgv_atividade.TabIndex = 23;
            this.dgv_atividade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellClick);
            this.dgv_atividade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellContentClick);
            this.dgv_atividade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellValueChanged);
            this.dgv_atividade.SelectionChanged += new System.EventHandler(this.dgv_atividade_SelectionChanged);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(780, 150);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(86, 29);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
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
            this.btn_fechar.Location = new System.Drawing.Point(989, 496);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(108, 29);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(192, 496);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(108, 29);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar Atividade";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nova
            // 
            this.btn_nova.BackColor = System.Drawing.Color.DarkRed;
            this.btn_nova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nova.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_nova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_nova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_nova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nova.ForeColor = System.Drawing.Color.White;
            this.btn_nova.Location = new System.Drawing.Point(50, 496);
            this.btn_nova.Name = "btn_nova";
            this.btn_nova.Size = new System.Drawing.Size(108, 29);
            this.btn_nova.TabIndex = 0;
            this.btn_nova.Text = "Nova Atividade";
            this.btn_nova.UseVisualStyleBackColor = false;
            this.btn_nova.Click += new System.EventHandler(this.btn_nova_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_descricao.Location = new System.Drawing.Point(398, 408);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(418, 70);
            this.tb_descricao.TabIndex = 0;
            this.tb_descricao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descrição";
            // 
            // F_ConsultarAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.Atividades_cadastradas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 598);
            this.Controls.Add(this.btn_nova);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dgv_atividade);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ConsultarAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Atividades";
            this.Load += new System.EventHandler(this.F_ConsultarAtividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.DataGridView dgv_atividade;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nova;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
    }
}