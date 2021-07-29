﻿using System;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
