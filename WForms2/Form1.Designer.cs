
namespace WForms2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.colunaNumeroVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaOcupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxVagasLivres = new System.Windows.Forms.ComboBox();
            this.lblVagasLivres = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.rbEntrando = new System.Windows.Forms.RadioButton();
            this.rbSaindo = new System.Windows.Forms.RadioButton();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNumeroVaga,
            this.colunaPlaca,
            this.colunaOcupado});
            this.dgVagas.Location = new System.Drawing.Point(12, 12);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowTemplate.Height = 50;
            this.dgVagas.Size = new System.Drawing.Size(760, 255);
            this.dgVagas.TabIndex = 0;
            // 
            // colunaNumeroVaga
            // 
            this.colunaNumeroVaga.HeaderText = "NumeroVaga";
            this.colunaNumeroVaga.Name = "colunaNumeroVaga";
            this.colunaNumeroVaga.ReadOnly = true;
            this.colunaNumeroVaga.Width = 300;
            // 
            // colunaPlaca
            // 
            this.colunaPlaca.HeaderText = "Placa";
            this.colunaPlaca.Name = "colunaPlaca";
            this.colunaPlaca.ReadOnly = true;
            this.colunaPlaca.Width = 180;
            // 
            // colunaOcupado
            // 
            this.colunaOcupado.HeaderText = "Ocupado";
            this.colunaOcupado.Name = "colunaOcupado";
            this.colunaOcupado.ReadOnly = true;
            this.colunaOcupado.Width = 200;
            // 
            // comboBoxVagasLivres
            // 
            this.comboBoxVagasLivres.FormattingEnabled = true;
            this.comboBoxVagasLivres.Location = new System.Drawing.Point(293, 331);
            this.comboBoxVagasLivres.Name = "comboBoxVagasLivres";
            this.comboBoxVagasLivres.Size = new System.Drawing.Size(216, 47);
            this.comboBoxVagasLivres.TabIndex = 1;
            // 
            // lblVagasLivres
            // 
            this.lblVagasLivres.AutoSize = true;
            this.lblVagasLivres.Location = new System.Drawing.Point(286, 289);
            this.lblVagasLivres.Name = "lblVagasLivres";
            this.lblVagasLivres.Size = new System.Drawing.Size(218, 39);
            this.lblVagasLivres.TabIndex = 2;
            this.lblVagasLivres.Text = "Vagas Livres";
            this.lblVagasLivres.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(286, 401);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 39);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(293, 443);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(216, 47);
            this.comboBoxPlaca.TabIndex = 4;
            // 
            // rbEntrando
            // 
            this.rbEntrando.AutoSize = true;
            this.rbEntrando.Location = new System.Drawing.Point(34, 354);
            this.rbEntrando.Name = "rbEntrando";
            this.rbEntrando.Size = new System.Drawing.Size(175, 43);
            this.rbEntrando.TabIndex = 5;
            this.rbEntrando.TabStop = true;
            this.rbEntrando.Text = "Entrando";
            this.rbEntrando.UseVisualStyleBackColor = true;
            this.rbEntrando.CheckedChanged += new System.EventHandler(this.rbEntrando_CheckedChanged);
            // 
            // rbSaindo
            // 
            this.rbSaindo.AutoSize = true;
            this.rbSaindo.Location = new System.Drawing.Point(34, 418);
            this.rbSaindo.Name = "rbSaindo";
            this.rbSaindo.Size = new System.Drawing.Size(142, 43);
            this.rbSaindo.TabIndex = 6;
            this.rbSaindo.TabStop = true;
            this.rbSaindo.Text = "Saindo";
            this.rbSaindo.UseVisualStyleBackColor = true;
            this.rbSaindo.CheckedChanged += new System.EventHandler(this.rbSaindo_CheckedChanged);
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonExecutar.Location = new System.Drawing.Point(583, 289);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(172, 204);
            this.buttonExecutar.TabIndex = 7;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = false;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(583, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonExecutar);
            this.Controls.Add(this.rbSaindo);
            this.Controls.Add(this.rbEntrando);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblVagasLivres);
            this.Controls.Add(this.comboBoxVagasLivres);
            this.Controls.Add(this.dgVagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.ComboBox comboBoxVagasLivres;
        private System.Windows.Forms.Label lblVagasLivres;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.RadioButton rbEntrando;
        private System.Windows.Forms.RadioButton rbSaindo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNumeroVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaOcupado;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.Button button2;
    }
}

