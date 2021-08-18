using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbEntrando_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSaindo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void buttonExecutar_Click(object sender, EventArgs e)
        {

        }

        private void AtualizaDG()
        {
            dgVagas.Rows.Clear();
            string select = "Select * from dbo.Vaga";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString() };
                dgVagas.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void AtualizaCB(bool update)
        {
            comboBoxVagasLivres.Items.Clear();
            if (update == true)
            {
                string select = "Select NumeroDaVaga from dbo.Vaga WHERE EstaPreenchida = 0";
                SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
                DBFunction.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxVagasLivres.Items.Add(dr[0].ToString());
                }
                dr.Close();
                DBFunction.Connection.Close();
            }
            else
            {

            }

        }


    }
}
