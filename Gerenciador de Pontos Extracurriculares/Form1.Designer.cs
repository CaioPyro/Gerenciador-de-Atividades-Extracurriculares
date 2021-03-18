namespace Projeto
{
    partial class Menu_Coordenador
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
            this.cadastroAluno = new System.Windows.Forms.Button();
            this.registrarAtividade = new System.Windows.Forms.Button();
            this.consultarAluno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consultarAtividades = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroAluno
            // 
            this.cadastroAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cadastroAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastroAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cadastroAluno.FlatAppearance.BorderSize = 2;
            this.cadastroAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.cadastroAluno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.cadastroAluno.Location = new System.Drawing.Point(20, 21);
            this.cadastroAluno.Name = "cadastroAluno";
            this.cadastroAluno.Size = new System.Drawing.Size(116, 36);
            this.cadastroAluno.TabIndex = 0;
            this.cadastroAluno.TabStop = false;
            this.cadastroAluno.Text = "Cadastrar Aluno";
            this.cadastroAluno.UseVisualStyleBackColor = false;
            this.cadastroAluno.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // registrarAtividade
            // 
            this.registrarAtividade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registrarAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarAtividade.FlatAppearance.BorderSize = 2;
            this.registrarAtividade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.registrarAtividade.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.registrarAtividade.Location = new System.Drawing.Point(20, 85);
            this.registrarAtividade.Name = "registrarAtividade";
            this.registrarAtividade.Size = new System.Drawing.Size(116, 36);
            this.registrarAtividade.TabIndex = 0;
            this.registrarAtividade.TabStop = false;
            this.registrarAtividade.Text = "Registrar Atividades";
            this.registrarAtividade.UseVisualStyleBackColor = false;
            this.registrarAtividade.Click += new System.EventHandler(this.registrarAtividade_Click);
            // 
            // consultarAluno
            // 
            this.consultarAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.consultarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarAluno.FlatAppearance.BorderSize = 2;
            this.consultarAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.consultarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.consultarAluno.Location = new System.Drawing.Point(20, 149);
            this.consultarAluno.Name = "consultarAluno";
            this.consultarAluno.Size = new System.Drawing.Size(116, 36);
            this.consultarAluno.TabIndex = 0;
            this.consultarAluno.TabStop = false;
            this.consultarAluno.Text = "Consultar Aluno";
            this.consultarAluno.UseVisualStyleBackColor = false;
            this.consultarAluno.Click += new System.EventHandler(this.consultarAluno_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_consultarAtividades);
            this.panel1.Controls.Add(this.consultarAluno);
            this.panel1.Controls.Add(this.cadastroAluno);
            this.panel1.Controls.Add(this.registrarAtividade);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 472);
            this.panel1.TabIndex = 3;
            // 
            // btn_consultarAtividades
            // 
            this.btn_consultarAtividades.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_consultarAtividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultarAtividades.FlatAppearance.BorderSize = 2;
            this.btn_consultarAtividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_consultarAtividades.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_consultarAtividades.Location = new System.Drawing.Point(20, 218);
            this.btn_consultarAtividades.Name = "btn_consultarAtividades";
            this.btn_consultarAtividades.Size = new System.Drawing.Size(116, 36);
            this.btn_consultarAtividades.TabIndex = 0;
            this.btn_consultarAtividades.TabStop = false;
            this.btn_consultarAtividades.Text = "Consultar Atividades";
            this.btn_consultarAtividades.UseVisualStyleBackColor = false;
            this.btn_consultarAtividades.Click += new System.EventHandler(this.btn_consultarAtividades_Click);
            // 
            // Menu_Coordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 473);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MaximizeBox = false;
            this.Name = "Menu_Coordenador";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Pontos Extracurriculares";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Coordenador_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Coordenador_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastroAluno;
        private System.Windows.Forms.Button registrarAtividade;
        private System.Windows.Forms.Button consultarAluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consultarAtividades;

    }
}

