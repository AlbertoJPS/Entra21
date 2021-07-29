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
    public partial class Login : Form
    { 
            private SqlConnection conn = new SqlConnection(@"Data Source=entra21serv.database.windows.net,1433;Initial Catalog=ExcEntra21;Persist Security Info=True;User ID=adm;Password=13062005x#"); 
            SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Cadastro WHERE LoginUser = '{txtBoxLogin.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (txtBoxSenha.Text == dr["PasswordKey"].ToString())
                {
                    MessageBox.Show("Login Successful");
                    Home home = new Home();
                    this.FindForm().Hide();
                    home.Show();
                }
                else 
                {
                    MessageBox.Show("Login Failed");
                }
            }
            dr.Close();
            conn.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Clear();
            txtBoxSenha.Clear();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            CadastroUsuario form2 = new CadastroUsuario();
            this.FindForm().Hide();
            form2.Show();
        }
    }
}
