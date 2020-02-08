using System;
using System.Windows.Forms;

namespace _01__Delegate01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn.Click += Metodo1;
            btn.Click += Metodo2;
        }

        private void Metodo1(object sender, EventArgs e)
        {
            MessageBox.Show("Método 1 Executado");
        }

        private void Metodo2(object sender, EventArgs e)
        {
            MessageBox.Show("Método 2 Executado");
        }
    }
}
