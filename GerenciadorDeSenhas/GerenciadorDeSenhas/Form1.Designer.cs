namespace GerenciadorDeSenhas
{
    partial class fmrTela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(259, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador de senhas SW";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(296, 173);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(348, 23);
            this.txbLogin.TabIndex = 1;
            this.txbLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxbSenha
            // 
            this.TxbSenha.Location = new System.Drawing.Point(296, 230);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '*';
            this.TxbSenha.Size = new System.Drawing.Size(348, 23);
            this.TxbSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEntrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.Location = new System.Drawing.Point(296, 305);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(117, 41);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(516, 305);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(230, 230);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 21);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(234, 173);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 21);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(394, 372);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(140, 52);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // fmrTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(917, 487);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.label1);
            this.Name = "fmrTela";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbLogin;
        private TextBox TxbSenha;
        private Button btnEntrar;
        private Button btnLimpar;
        private Label lblSenha;
        private Label lblLogin;
        private Button btnCadastrar;
    }
}