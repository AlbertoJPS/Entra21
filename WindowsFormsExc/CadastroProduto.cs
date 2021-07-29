using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExc
{
    public partial class CadastroProduto : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=entra21serv.database.windows.net,1433;Initial Catalog=ExcEntra21;Persist Security Info=True;User ID=adm;Password=13062005x#");
        SqlCommand cmd;
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNome.Text;
            string preco = txtBoxPreco.Text;
            string qtdEstoque = txtBoxQtdEstoque.Text;

            if (nome != null || preco != null || qtdEstoque != null)
            {
                string insert = $"INSERT into dbo.Produto (Nome,Preco,QtdEstoque) values ('{nome}','{preco}','{qtdEstoque}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produto Salvo");
            }
            else
            {
                MessageBox.Show("Todos os campos são Obrigatórios!");
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.FindForm().Hide();
            produto.Show();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Clear();
            txtBoxPreco.Clear();
            txtBoxQtdEstoque.Clear();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            
            this.produtoTableAdapter.Fill(this.excEntra21DataSet.Produto);
           

        }

        private void buttonRecarregar_Click(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
