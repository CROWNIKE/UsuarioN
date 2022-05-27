namespace GestaoDePessoas.Formularios

{
    partial class ListadeUsuarios
    {
        private void InitializeComponent()
        {
            this.listaUsuariosCadastrados = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuariosCadastrados
            // 
            this.listaUsuariosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosCadastrados.Location = new System.Drawing.Point(12, 12);
            this.listaUsuariosCadastrados.Name = "listaUsuariosCadastrados";
            this.listaUsuariosCadastrados.Size = new System.Drawing.Size(667, 303);
            this.listaUsuariosCadastrados.TabIndex = 0;
            this.listaUsuariosCadastrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(427, 321);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 26);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.AoClicarEmNovo);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(599, 321);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 26);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.AoClicaEmExcluir);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(513, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 26);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.AoClicarEmEditar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(98, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.AoClicarEmCancelar);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(12, 321);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(80, 26);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.AoClicarEmOK);
            // 
            // ListadeUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(691, 357);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.listaUsuariosCadastrados);
            this.Name = "ListadeUsuarios";
            this.Text = "Usuarios";
          
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosCadastrados)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView listaUsuariosCadastrados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnok;
    }
}