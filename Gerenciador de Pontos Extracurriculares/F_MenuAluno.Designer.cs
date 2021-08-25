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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MenuAluno));
            this.consultarPontos = new System.Windows.Forms.Button();
            this.btn_dadosPessoais = new System.Windows.Forms.Button();
            this.consultarAtividade = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultarPontos
            // 
            this.consultarPontos.BackColor = System.Drawing.Color.DarkRed;
            this.consultarPontos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarPontos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.consultarPontos.FlatAppearance.BorderSize = 2;
            this.consultarPontos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.consultarPontos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.consultarPontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarPontos.Location = new System.Drawing.Point(810, 371);
            this.consultarPontos.Name = "consultarPontos";
            this.consultarPontos.Size = new System.Drawing.Size(131, 42);
            this.consultarPontos.TabIndex = 0;
            this.consultarPontos.TabStop = false;
            this.consultarPontos.Text = "Consultar Pontos";
            this.consultarPontos.UseVisualStyleBackColor = false;
            this.consultarPontos.Click += new System.EventHandler(this.consultarPontos_Click);
            // 
            // btn_dadosPessoais
            // 
            this.btn_dadosPessoais.BackColor = System.Drawing.Color.DarkRed;
            this.btn_dadosPessoais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dadosPessoais.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_dadosPessoais.FlatAppearance.BorderSize = 2;
            this.btn_dadosPessoais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_dadosPessoais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_dadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dadosPessoais.Location = new System.Drawing.Point(447, 371);
            this.btn_dadosPessoais.Name = "btn_dadosPessoais";
            this.btn_dadosPessoais.Size = new System.Drawing.Size(131, 42);
            this.btn_dadosPessoais.TabIndex = 0;
            this.btn_dadosPessoais.TabStop = false;
            this.btn_dadosPessoais.Text = "Dados Pessoais";
            this.btn_dadosPessoais.UseVisualStyleBackColor = false;
            this.btn_dadosPessoais.Click += new System.EventHandler(this.btn_dadosPessoais_Click);
            // 
            // consultarAtividade
            // 
            this.consultarAtividade.BackColor = System.Drawing.Color.DarkRed;
            this.consultarAtividade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarAtividade.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.consultarAtividade.FlatAppearance.BorderSize = 2;
            this.consultarAtividade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.consultarAtividade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.consultarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarAtividade.Location = new System.Drawing.Point(631, 371);
            this.consultarAtividade.Name = "consultarAtividade";
            this.consultarAtividade.Size = new System.Drawing.Size(131, 42);
            this.consultarAtividade.TabIndex = 0;
            this.consultarAtividade.TabStop = false;
            this.consultarAtividade.Text = "Consultar Atividades";
            this.consultarAtividade.UseVisualStyleBackColor = false;
            this.consultarAtividade.Click += new System.EventHandler(this.consultarAtividade_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DarkRed;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_sair.FlatAppearance.BorderSize = 2;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(1285, 166);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(81, 27);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.TabStop = false;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // F_MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_dadosPessoais);
            this.Controls.Add(this.consultarPontos);
            this.Controls.Add(this.consultarAtividade);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_MenuAluno";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Atividades Complementares";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_MenuAluno_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button consultarPontos;
        private System.Windows.Forms.Button btn_dadosPessoais;
        private System.Windows.Forms.Button consultarAtividade;
        private System.Windows.Forms.Button btn_sair;
    }
}