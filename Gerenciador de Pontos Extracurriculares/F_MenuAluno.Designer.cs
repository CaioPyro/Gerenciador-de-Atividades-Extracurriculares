namespace Projeto
{
    partial class F_MenuAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.consultarPontos = new System.Windows.Forms.Button();
            this.btn_dadosPessoais = new System.Windows.Forms.Button();
            this.consultarAtividade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.consultarPontos);
            this.panel1.Controls.Add(this.btn_dadosPessoais);
            this.panel1.Controls.Add(this.consultarAtividade);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 472);
            this.panel1.TabIndex = 4;
            // 
            // consultarPontos
            // 
            this.consultarPontos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.consultarPontos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarPontos.FlatAppearance.BorderSize = 2;
            this.consultarPontos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.consultarPontos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.consultarPontos.Location = new System.Drawing.Point(20, 149);
            this.consultarPontos.Name = "consultarPontos";
            this.consultarPontos.Size = new System.Drawing.Size(116, 36);
            this.consultarPontos.TabIndex = 0;
            this.consultarPontos.TabStop = false;
            this.consultarPontos.Text = "Consultar Pontos";
            this.consultarPontos.UseVisualStyleBackColor = false;
            // 
            // btn_dadosPessoais
            // 
            this.btn_dadosPessoais.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dadosPessoais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dadosPessoais.FlatAppearance.BorderSize = 2;
            this.btn_dadosPessoais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_dadosPessoais.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dadosPessoais.Location = new System.Drawing.Point(20, 21);
            this.btn_dadosPessoais.Name = "btn_dadosPessoais";
            this.btn_dadosPessoais.Size = new System.Drawing.Size(116, 36);
            this.btn_dadosPessoais.TabIndex = 0;
            this.btn_dadosPessoais.TabStop = false;
            this.btn_dadosPessoais.Text = "Dados Pessoais";
            this.btn_dadosPessoais.UseVisualStyleBackColor = false;
            this.btn_dadosPessoais.Click += new System.EventHandler(this.btn_dadosPessoais_Click);
            // 
            // consultarAtividade
            // 
            this.consultarAtividade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.consultarAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarAtividade.FlatAppearance.BorderSize = 2;
            this.consultarAtividade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.consultarAtividade.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.consultarAtividade.Location = new System.Drawing.Point(20, 85);
            this.consultarAtividade.Name = "consultarAtividade";
            this.consultarAtividade.Size = new System.Drawing.Size(116, 36);
            this.consultarAtividade.TabIndex = 0;
            this.consultarAtividade.TabStop = false;
            this.consultarAtividade.Text = "Consultar Atividades";
            this.consultarAtividade.UseVisualStyleBackColor = false;
            // 
            // F_MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 473);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "F_MenuAluno";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Pontos Extracurriculares";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_MenuAluno_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button consultarPontos;
        private System.Windows.Forms.Button btn_dadosPessoais;
        private System.Windows.Forms.Button consultarAtividade;
    }
}