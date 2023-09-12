namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtInformacoes = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(367, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(83, 13);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome do Aluno:";
            // 
            // txtIdade
            // 
            this.txtIdade.AutoSize = true;
            this.txtIdade.Location = new System.Drawing.Point(367, 82);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(82, 13);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.Text = "Idade do Aluno:";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(367, 137);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(78, 13);
            this.txtSexo.TabIndex = 2;
            this.txtSexo.Text = "Sexo do aluno:";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(367, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(82, 13);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "E-mail do aluno:";
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.AutoSize = true;
            this.txtInformacoes.Location = new System.Drawing.Point(347, 250);
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Size = new System.Drawing.Size(112, 13);
            this.txtInformacoes.TabIndex = 4;
            this.txtInformacoes.Text = "Informações do aluno:";
            this.txtInformacoes.Click += new System.EventHandler(this.label5_Click);
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(329, 48);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(152, 20);
            this.M.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(329, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(329, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(329, 266);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 9;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(361, 364);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(75, 23);
            this.txtEnviar.TabIndex = 10;
            this.txtEnviar.Text = "Enviar";
            this.txtEnviar.UseVisualStyleBackColor = true;
            this.txtEnviar.Click += new System.EventHandler(this.txtEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.M);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtIdade;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtInformacoes;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button txtEnviar;
    }
}

