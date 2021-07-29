
namespace WindowsFormsExc
{
    partial class Produto
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
            this.lblProdutos = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonRecarregar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excEntra21DataSet = new WindowsFormsExc.ExcEntra21DataSet();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new WindowsFormsExc.ExcEntra21DataSetTableAdapters.ProdutoTableAdapter();
            this.excEntra21DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdutos.Location = new System.Drawing.Point(51, 31);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(157, 35);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Produtos";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonCadastrar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonCadastrar.Location = new System.Drawing.Point(51, 103);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(156, 23);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAtualizar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAtualizar.Location = new System.Drawing.Point(51, 144);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(156, 23);
            this.buttonAtualizar.TabIndex = 2;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonRemover.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonRemover.Location = new System.Drawing.Point(51, 187);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(156, 23);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonVoltar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVoltar.Location = new System.Drawing.Point(51, 245);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonRecarregar
            // 
            this.buttonRecarregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRecarregar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecarregar.ForeColor = System.Drawing.Color.Navy;
            this.buttonRecarregar.Location = new System.Drawing.Point(132, 245);
            this.buttonRecarregar.Name = "buttonRecarregar";
            this.buttonRecarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecarregar.TabIndex = 5;
            this.buttonRecarregar.Text = "Recarregar";
            this.buttonRecarregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.produtoBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(268, 17);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(443, 276);
            this.dataGridView1.TabIndex = 6;
            // 
            // excEntra21DataSet
            // 
            this.excEntra21DataSet.DataSetName = "ExcEntra21DataSet";
            this.excEntra21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.excEntra21DataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
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
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::WindowsFormsExc.Properties.Resources.colorful_razer_rgb_hd_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(723, 305);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRecarregar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.lblProdutos);
            this.Font = new System.Drawing.Font("Magneto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Produto";
            this.Text = "OpcoesDeProduto";
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonRecarregar;
        private System.Windows.Forms.BindingSource bindingSource1;
       
        private System.Windows.Forms.BindingSource produtoBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ExcEntra21DataSet excEntra21DataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private ExcEntra21DataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource excEntra21DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}