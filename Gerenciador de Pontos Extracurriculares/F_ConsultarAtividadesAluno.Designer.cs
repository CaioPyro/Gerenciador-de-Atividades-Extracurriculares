namespace Projeto
{
    partial class F_ConsultarAtividadesAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_atividade = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_atividade
            // 
            this.dgv_atividade.AllowUserToAddRows = false;
            this.dgv_atividade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_atividade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_atividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atividade.EnableHeadersVisualStyles = false;
            this.dgv_atividade.Location = new System.Drawing.Point(35, 25);
            this.dgv_atividade.MultiSelect = false;
            this.dgv_atividade.Name = "dgv_atividade";
            this.dgv_atividade.ReadOnly = true;
            this.dgv_atividade.RowHeadersVisible = false;
            this.dgv_atividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atividade.Size = new System.Drawing.Size(575, 204);
            this.dgv_atividade.TabIndex = 24;
            this.dgv_atividade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descrição";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_descricao.Location = new System.Drawing.Point(109, 265);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(418, 70);
            this.tb_descricao.TabIndex = 0;
            this.tb_descricao.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(512, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(98, 23);
            this.btn_fechar.TabIndex = 35;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 47);
            this.panel1.TabIndex = 36;
            // 
            // F_ConsultarAtividadesAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.dgv_atividade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ConsultarAtividadesAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Atividades";
            this.Load += new System.EventHandler(this.F_ConsultarAtividadesAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_atividade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel1;
    }
}