using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.FindForm().Hide();
            form1.Show();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.FindForm().Hide();
            produto.Show();
        }
    }
}
