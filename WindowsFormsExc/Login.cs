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

        public Login()
        {
            InitializeComponent();
        }
        //public string Nome {get; set;}
        public static string Nome { get; set; }
        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Cadastro WHERE LoginUser = '{txtBoxLogin.Text}'";
            SqlCommand cmd = new SqlCommand(select, DbConncetion.Connection);
            DbConncetion.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (txtBoxSenha.Text == dr["PasswordKey"].ToString())
                {
                    MessageBox.Show("Login Successful");
                    Login.Nome = txtBoxLogin.Text;
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
            DbConncetion.Connection.Close();
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
