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
            lblTextNome.Text = Login.Nome.ToString(); ;
        }
        
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            Login.Nome = null;
            this.FindForm().Hide();
            form1.Show();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.FindForm().Hide();
            produto.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'excEntra21DataSet1.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroTableAdapter.Fill(this.excEntra21DataSet1.Cadastro);

        }

        //private void buttonPessoa_Click(object sender, EventArgs e)
        //{
        //    Pessoa pessoa = new Pessoa();
        //    this.FindForm().Hide();
        //    pessoa.Show();
        //}
    }
}
