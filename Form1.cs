using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALUDO
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Btnsaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtnombre.Text;
            MessageBox.Show("HOLA:" + txtnombre.Text); 

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
