using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbarrotesPrueba
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            ventas1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventas1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productos1.BringToFront();
        }
    }
}
