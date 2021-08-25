namespace Projeto
{
    partial class F_dadosAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_dadosAluno));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_curso = new System.Windows.Forms.TextBox();
            this.tb_acesso = new System.Windows.Forms.TextBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.btn_alterarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo de Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 21;
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
            this.btn_fechar.Location = new System.Drawing.Point(947, 498);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 28);
            this.btn_fechar.TabIndex = 31;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nome.Location = new System.Drawing.Point(254, 205);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(325, 20);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TabStop = false;
            // 
            // tb_matricula
            // 
            this.tb_matricula.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_matricula.Location = new System.Drawing.Point(254, 261);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.ReadOnly = true;
            this.tb_matricula.Size = new System.Drawing.Size(158, 20);
            this.tb_matricula.TabIndex = 0;
            this.tb_matricula.TabStop = false;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_cpf.Location = new System.Drawing.Point(254, 314);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.ReadOnly = true;
            this.tb_cpf.Size = new System.Drawing.Size(158, 20);
            this.tb_cpf.TabIndex = 0;
            this.tb_cpf.TabStop = false;
            // 
            // tb_curso
            // 
            this.tb_curso.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_curso.Location = new System.Drawing.Point(254, 364);
            this.tb_curso.Name = "tb_curso";
            this.tb_curso.ReadOnly = true;
            this.tb_curso.Size = new System.Drawing.Size(158, 20);
            this.tb_curso.TabIndex = 0;
            this.tb_curso.TabStop = false;
            // 
            // tb_acesso
            // 
            this.tb_acesso.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_acesso.Location = new System.Drawing.Point(254, 416);
            this.tb_acesso.Name = "tb_acesso";
            this.tb_acesso.ReadOnly = true;
            this.tb_acesso.Size = new System.Drawing.Size(158, 20);
            this.tb_acesso.TabIndex = 0;
            this.tb_acesso.TabStop = false;
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.DarkRed;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foto.Location = new System.Drawing.Point(807, 206);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(110, 130);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 32;
            this.foto.TabStop = false;
            // 
            // btn_alterarImagem
            // 
            this.btn_alterarImagem.BackColor = System.Drawing.Color.DarkRed;
            this.btn_alterarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterarImagem.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_alterarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_alterarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_alterarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarImagem.ForeColor = System.Drawing.Color.White;
            this.btn_alterarImagem.Location = new System.Drawing.Point(816, 343);
            this.btn_alterarImagem.Name = "btn_alterarImagem";
            this.btn_alterarImagem.Size = new System.Drawing.Size(94, 25);
            this.btn_alterarImagem.TabIndex = 33;
            this.btn_alterarImagem.Text = "Alterar imagem";
            this.btn_alterarImagem.UseVisualStyleBackColor = false;
            this.btn_alterarImagem.Click += new System.EventHandler(this.btn_alterarImagem_Click);
            // 
            // F_dadosAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projeto.Properties.Resources.dados_pessoais;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 598);
            this.Controls.Add(this.btn_alterarImagem);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.tb_acesso);
            this.Controls.Add(this.tb_curso);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_dadosAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Pessoais";
            this.Load += new System.EventHandler(this.F_dadosAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_curso;
        private System.Windows.Forms.TextBox tb_acesso;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button btn_alterarImagem;
    }
}