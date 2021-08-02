
namespace WindowsFormsExc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.txtBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.buttonSingUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Magneto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(38, 24);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Magneto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(41, 94);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(109, 24);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Password";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(42, 51);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(160, 20);
            this.txtBoxLogin.TabIndex = 0;
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSingIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonSingIn.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSingIn.Location = new System.Drawing.Point(45, 167);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSingIn.TabIndex = 4;
            this.buttonSingIn.Text = "SingIn";
            this.buttonSingIn.UseVisualStyleBackColor = false;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Salmon;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClear.Location = new System.Drawing.Point(127, 167);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(45, 121);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(157, 20);
            this.txtBoxSenha.TabIndex = 1;
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSingUp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSingUp.Location = new System.Drawing.Point(85, 236);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSingUp.TabIndex = 7;
            this.buttonSingUp.Text = "SingUp";
            this.buttonSingUp.UseVisualStyleBackColor = false;
            this.buttonSingUp.Click += new System.EventHandler(this.buttonSingUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(63, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Não tem uma conta?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(247, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSingUp);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MaskedTextBox txtBoxSenha;
        private System.Windows.Forms.Button buttonSingUp;
        private System.Windows.Forms.Label label1;
    }
}

