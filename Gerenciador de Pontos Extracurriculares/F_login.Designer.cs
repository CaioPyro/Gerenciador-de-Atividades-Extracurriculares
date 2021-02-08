namespace Projeto
{
    partial class F_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.A_aluno = new System.Windows.Forms.CheckBox();
            this.A_coordenador = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(16, 30);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(242, 20);
            this.tb_matricula.TabIndex = 1;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(16, 86);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.PasswordChar = '*';
            this.tb_cpf.Size = new System.Drawing.Size(242, 20);
            this.tb_cpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(52, 132);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(154, 132);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // A_aluno
            // 
            this.A_aluno.AutoSize = true;
            this.A_aluno.Location = new System.Drawing.Point(52, 188);
            this.A_aluno.Name = "A_aluno";
            this.A_aluno.Size = new System.Drawing.Size(53, 17);
            this.A_aluno.TabIndex = 6;
            this.A_aluno.Text = "Aluno";
            this.A_aluno.UseVisualStyleBackColor = true;
            // 
            // A_coordenador
            // 
            this.A_coordenador.AutoSize = true;
            this.A_coordenador.Location = new System.Drawing.Point(154, 188);
            this.A_coordenador.Name = "A_coordenador";
            this.A_coordenador.Size = new System.Drawing.Size(87, 17);
            this.A_coordenador.TabIndex = 7;
            this.A_coordenador.Text = "Coordenador";
            this.A_coordenador.UseVisualStyleBackColor = true;
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 238);
            this.Controls.Add(this.A_coordenador);
            this.Controls.Add(this.A_aluno);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox A_aluno;
        private System.Windows.Forms.CheckBox A_coordenador;
    }
}