
namespace WindowsFormsExc
{
    partial class Home
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.excEntra21DataSet1 = new WindowsFormsExc.ExcEntra21DataSet1();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new WindowsFormsExc.ExcEntra21DataSet1TableAdapters.CadastroTableAdapter();
            this.lblTextNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPessoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHome.Location = new System.Drawing.Point(88, 35);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(80, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBemVindo.Location = new System.Drawing.Point(121, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(68, 14);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem vindo,";
            // 
            // buttonProduto
            // 
            this.buttonProduto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonProduto.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonProduto.Location = new System.Drawing.Point(52, 121);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(156, 23);
            this.buttonProduto.TabIndex = 2;
            this.buttonProduto.Text = "Produto";
            this.buttonProduto.UseVisualStyleBackColor = false;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogout.Location = new System.Drawing.Point(93, 239);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // excEntra21DataSet1
            // 
            this.excEntra21DataSet1.DataSetName = "ExcEntra21DataSet1";
            this.excEntra21DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "Cadastro";
            this.cadastroBindingSource.DataSource = this.excEntra21DataSet1;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // lblTextNome
            // 
            this.lblTextNome.AutoSize = true;
            this.lblTextNome.BackColor = System.Drawing.Color.Transparent;
            this.lblTextNome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNome.ForeColor = System.Drawing.Color.Aqua;
            this.lblTextNome.Location = new System.Drawing.Point(185, 7);
            this.lblTextNome.Name = "lblTextNome";
            this.lblTextNome.Size = new System.Drawing.Size(38, 16);
            this.lblTextNome.TabIndex = 4;
            this.lblTextNome.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operações";
            // 
            // buttonPessoa
            // 
            this.buttonPessoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPessoa.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPessoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonPessoa.Location = new System.Drawing.Point(52, 150);
            this.buttonPessoa.Name = "buttonPessoa";
            this.buttonPessoa.Size = new System.Drawing.Size(156, 23);
            this.buttonPessoa.TabIndex = 6;
            this.buttonPessoa.Text = "Pessoa";
            this.buttonPessoa.UseVisualStyleBackColor = false;
            this.buttonPessoa.Click += new System.EventHandler(this.buttonPessoa_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsExc.Properties.Resources.colorful_razer_rgb_hd_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(247, 305);
            this.Controls.Add(this.buttonPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTextNome);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblHome);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excEntra21DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonLogout;
        private ExcEntra21DataSet1 excEntra21DataSet1;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private ExcEntra21DataSet1TableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.Label lblTextNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPessoa;
    }
}