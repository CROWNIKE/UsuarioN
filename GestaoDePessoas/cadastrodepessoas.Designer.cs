namespace GestaoDePessoas
{
    partial class cadastrodepessoas
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.criacao = new System.Windows.Forms.DateTimePicker();
            this.nascimento = new System.Windows.Forms.MaskedTextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(53, 56);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(164, 20);
            this.Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(53, 95);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(164, 20);
            this.Senha.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(53, 128);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(164, 20);
            this.Email.TabIndex = 5;
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
            // criacao
            // 
            this.criacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.criacao.Location = new System.Drawing.Point(107, 168);
            this.criacao.Name = "criacao";
            this.criacao.Size = new System.Drawing.Size(110, 20);
            this.criacao.TabIndex = 8;
            // 
            // nascimento
            // 
            this.nascimento.Location = new System.Drawing.Point(107, 218);
            this.nascimento.Mask = "00/00/0000";
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(110, 20);
            this.nascimento.TabIndex = 9;
            this.nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(15, 301);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(66, 20);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(135, 301);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(66, 20);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(53, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(164, 20);
            this.id.TabIndex = 12;
            
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
            // cadastrodepessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.nascimento);
            this.Controls.Add(this.criacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Name = "cadastrodepessoas";
            this.Text = "Cadastro de Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker criacao;
        private System.Windows.Forms.MaskedTextBox nascimento;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label6;
    }
}