using System.Windows.Forms;
using System;

namespace DelegateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnClick.Click += delegate (object sender, EventArgs e)   //as duas formas funcionam
            btnClick.Click += delegate
            {
                MessageBox.Show("Olá Mundo!! Fui Clicado!!");
            };
        }
    }
}
