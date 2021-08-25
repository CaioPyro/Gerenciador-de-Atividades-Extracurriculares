namespace Projeto
{
    partial class F_Pontos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Pontos));
            this.dgv_atividade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pontos = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_atividade.Location = new System.Drawing.Point(408, 206);
            this.dgv_atividade.MultiSelect = false;
            this.dgv_atividade.Name = "dgv_atividade";
            this.dgv_atividade.ReadOnly = true;
            this.dgv_atividade.RowHeadersVisible = false;
            this.dgv_atividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atividade.Size = new System.Drawing.Size(416, 189);
            this.dgv_atividade.TabIndex = 24;
            this.dgv_atividade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atividade_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total de Pontos Obtidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pontos
            // 
            this.tb_pontos.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pontos.Location = new System.Drawing.Point(408, 437);
            this.tb_pontos.Multiline = true;
            this.tb_pontos.Name = "tb_pontos";
            this.tb_pontos.ReadOnly = true;
            this.tb_pontos.Size = new System.Drawing.Size(169, 31);
            this.tb_pontos.TabIndex = 0;
            this.tb_pontos.TabStop = false;
            this.tb_pontos.TextChanged += new System.EventHandler(this.tb_pontos_TextChanged);
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
            this.btn_fechar.Location = new System.Drawing.Point(998, 495);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(95, 28);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Histórico de Pontos Obtidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // F_Pontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.pontos_obtidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 598);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_atividade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Pontos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontos";
            this.Load += new System.EventHandler(this.F_Pontos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atividade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_atividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pontos;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label2;

    }
}