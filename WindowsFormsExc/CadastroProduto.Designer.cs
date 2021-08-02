
namespace WindowsFormsExc
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.txtBoxQtdEstoque = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excEntra21DataSet = new WindowsFormsExc.ExcEntra21DataSet();
            this.produtoTableAdapter = new WindowsFormsExc.ExcEntra21DataSetTableAdapters.ProdutoTableAdapter();
            this.buttonRecarregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.excEntra21DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(46, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreco.Location = new System.Drawing.Point(46, 103);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(70, 24);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCadastroProduto.Location = new System.Drawing.Point(0, 9);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(246, 25);
            this.lblCadastroProduto.TabIndex = 2;
            this.lblCadastroProduto.Text = "Cadastro de Produto";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdEstoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQtdEstoque.Location = new System.Drawing.Point(46, 153);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(162, 24);
            this.lblQtdEstoque.TabIndex = 3;
            this.lblQtdEstoque.Text = "Quantidade em";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(50, 75);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(156, 20);
            this.txtBoxNome.TabIndex = 4;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(50, 130);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPreco.TabIndex = 5;
            // 
            // txtBoxQtdEstoque
            // 
            this.txtBoxQtdEstoque.Location = new System.Drawing.Point(50, 204);
            this.txtBoxQtdEstoque.Name = "txtBoxQtdEstoque";
            this.txtBoxQtdEstoque.Size = new System.Drawing.Size(156, 20);
            this.txtBoxQtdEstoque.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSalvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSalvar.Location = new System.Drawing.Point(50, 244);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonVoltar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVoltar.Location = new System.Drawing.Point(50, 273);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 8;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Salmon;
            this.buttonLimpar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonLimpar.Location = new System.Drawing.Point(131, 244);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstoque.Location = new System.Drawing.Point(46, 177);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(91, 24);
            this.lblEstoque.TabIndex = 10;
            this.lblEstoque.Text = "Estoque";
            // 
            // excEntra21DataSet
            // 
            this.excEntra21DataSet.DataSetName = "ExcEntra21DataSet";
            this.excEntra21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRecarregar
            // 
            this.buttonRecarregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRecarregar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecarregar.ForeColor = System.Drawing.Color.Navy;
            this.buttonRecarregar.Location = new System.Drawing.Point(132, 273);
            this.buttonRecarregar.Name = "buttonRecarregar";
            this.buttonRecarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecarregar.TabIndex = 12;
            this.buttonRecarregar.Text = "Recarregar";
            this.buttonRecarregar.UseVisualStyleBackColor = false;
            this.buttonRecarregar.Click += new System.EventHandler(this.buttonRecarregar_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.produtoBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(268, 17);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(443, 276);
            this.dataGridView2.TabIndex = 13;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.excEntra21DataSetBindingSource;
            // 
            // excEntra21DataSetBindingSource
            // 
            this.excEntra21DataSetBindingSource.DataSource = this.excEntra21DataSet;
            this.excEntra21DataSetBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QtdEstoque";
            this.dataGridViewTextBoxColumn4.HeaderText = "QtdEstoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsExc.Properties.Resources.colorful_razer_rgb_hd_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(722, 305);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonRecarregar);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.txtBoxQtdEstoque);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.lblCadastroProduto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroProduto";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.Label lblQtdEstoque;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.TextBox txtBoxQtdEstoque;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label lblEstoque;
        private ExcEntra21DataSet excEntra21DataSet;
        private ExcEntra21DataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button buttonRecarregar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource excEntra21DataSetBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}