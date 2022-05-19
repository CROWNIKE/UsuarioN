using System;
using System.Windows.Forms;

namespace GestaoDePessoas
{
    public partial class cadastrodepessoas : Form
    {
        public Usuario Usuario { get; }
       

        public cadastrodepessoas(Usuario usuario)
        {

            InitializeComponent();
            this.Usuario = usuario;

            
        }

        public cadastrodepessoas()
        {
        }

        private void OK_Click(object sender, EventArgs e)
        {
           
     




            Console.WriteLine("Foi Adicionado com Sucesso");

        }

       
    }
}
