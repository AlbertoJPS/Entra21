
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHome.Location = new System.Drawing.Point(88, 21);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(80, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBemVindo.Location = new System.Drawing.Point(79, 57);
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
            this.buttonProduto.Location = new System.Drawing.Point(51, 103);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsExc.Properties.Resources.colorful_razer_rgb_hd_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(247, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblHome);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label3;
    }
}