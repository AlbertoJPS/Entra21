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
    public partial class Produto : Form
    {
       
        public Produto()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.FindForm().Hide();
            home.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            this.FindForm().Hide();
            cadastroProduto.Show();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
           this.produtoTableAdapter.Fill(this.excEntra21DataSet.Produto);

        }

        private void buttonRecarregar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("SELECT * from dbo.Produto");
        }
        private DataTable GetData(string sqlCommand)
        {
            string connectionString = DbConncetion.Connection.ConnectionString;

            SqlConnection northwindConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
    }
}
