namespace GestaoDePessoas
{
    partial class Cadastrodepessoas
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
            this.lblNome = new System.Windows.Forms.Label();
            this.caixaNome = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.caixaSenha = new System.Windows.Forms.TextBox();
            this.caixaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.caixacriacao = new System.Windows.Forms.DateTimePicker();
            this.OK = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.caixaId = new System.Windows.Forms.TextBox();
            this.caixaNascimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // caixaNome
            // 
            this.caixaNome.Location = new System.Drawing.Point(53, 56);
            this.caixaNome.Name = "caixaNome";
            this.caixaNome.Size = new System.Drawing.Size(164, 20);
            this.caixaNome.TabIndex = 1;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(12, 98);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(38, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // caixaSenha
            // 
            this.caixaSenha.Location = new System.Drawing.Point(53, 95);
            this.caixaSenha.Name = "caixaSenha";
            this.caixaSenha.PasswordChar = '*';
            this.caixaSenha.Size = new System.Drawing.Size(164, 20);
            this.caixaSenha.TabIndex = 4;
            
            // 
            // caixaEmail
            // 
            this.caixaEmail.Location = new System.Drawing.Point(53, 128);
            this.caixaEmail.Name = "caixaEmail";
            this.caixaEmail.Size = new System.Drawing.Size(164, 20);
            this.caixaEmail.TabIndex = 5;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Criacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Nascimento";
            // 
            // caixacriacao
            // 
            this.caixacriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.caixacriacao.Location = new System.Drawing.Point(107, 168);
            this.caixacriacao.Name = "caixacriacao";
            this.caixacriacao.Size = new System.Drawing.Size(110, 20);
            this.caixacriacao.TabIndex = 8;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(15, 301);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(66, 20);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.AoClicarEmOK);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(135, 301);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(66, 20);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.AoClicarEmCancelar);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id";
            // 
            // caixaId
            // 
            this.caixaId.Location = new System.Drawing.Point(53, 30);
            this.caixaId.Name = "caixaId";
            this.caixaId.Size = new System.Drawing.Size(164, 20);
            this.caixaId.TabIndex = 12;
            // 
            // caixaNascimento
            // 
            this.caixaNascimento.Location = new System.Drawing.Point(108, 223);
            this.caixaNascimento.Mask = "00/00/0000";
            this.caixaNascimento.Name = "caixaNascimento";
            this.caixaNascimento.Size = new System.Drawing.Size(109, 20);
            this.caixaNascimento.TabIndex = 14;
            this.caixaNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Cadastrodepessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 343);
            this.Controls.Add(this.caixaNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.caixaId);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.caixacriacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caixaEmail);
            this.Controls.Add(this.caixaSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.caixaNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Cadastrodepessoas";
            this.Text = "Cadastro de Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox caixaNome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox caixaSenha;
        private System.Windows.Forms.TextBox caixaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker caixacriacao;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox caixaId;
        private System.Windows.Forms.MaskedTextBox caixaNascimento;
    }
}