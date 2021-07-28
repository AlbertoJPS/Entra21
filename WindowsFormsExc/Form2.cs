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
    public partial class Form2 : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=entra21serv.database.windows.net,1433;Initial Catalog=ExcEntra21;Persist Security Info=True;User ID=adm;Password=13062005x#");
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;
            
            string insert = $"INSERT into dbo.Cadastro (LoginUser,PasswordKey) values ('{login}','{password}')";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SingUp Successful");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.FindForm().Hide();
            form1.Show();
        }
    }
}
