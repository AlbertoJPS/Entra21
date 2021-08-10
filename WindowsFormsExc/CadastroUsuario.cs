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
    public partial class CadastroUsuario : Form
    {
        
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;
            
            string insert = $"INSERT into dbo.Cadastro (LoginUser,PasswordKey) values ('{login}','{password}')";
            SqlCommand cmd = new SqlCommand(insert, DbConncetion.Connection);
            DbConncetion.Connection.Open();
            DbConncetion.Connection.Close();
            MessageBox.Show("SingUp Successful");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.FindForm().Hide();
            form1.Show();
        }
    }
}
