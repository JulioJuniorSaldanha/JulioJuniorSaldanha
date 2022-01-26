namespace GerenciadorDeSenhas
{
    partial class FormCadastrar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txblogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbConfsenha = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(264, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 56);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastrar novo usuario";
            this.lblTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(264, 193);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 21);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txblogin
            // 
            this.txblogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txblogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txblogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txblogin.Location = new System.Drawing.Point(323, 191);
            this.txblogin.Name = "txblogin";
            this.txblogin.Size = new System.Drawing.Size(299, 29);
            this.txblogin.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(264, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 21);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(212, 228);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(105, 21);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha mestra";
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmaSenha.Location = new System.Drawing.Point(139, 263);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(178, 21);
            this.lblConfirmaSenha.TabIndex = 6;
            this.lblConfirmaSenha.Text = "Confirmar senha mestra";
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenha.Location = new System.Drawing.Point(323, 226);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(299, 29);
            this.txbSenha.TabIndex = 7;
            // 
            // txbConfsenha
            // 
            this.txbConfsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConfsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbConfsenha.Location = new System.Drawing.Point(323, 261);
            this.txbConfsenha.Name = "txbConfsenha";
            this.txbConfsenha.PasswordChar = '*';
            this.txbConfsenha.Size = new System.Drawing.Size(299, 29);
            this.txbConfsenha.TabIndex = 8;
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(323, 156);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(299, 29);
            this.txbNome.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(519, 339);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 41);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(288, 339);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 41);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(32, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 41);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(917, 487);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbConfsenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txblogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormCadastrar";
            this.Text = "FormCadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitulo;
        private Label lblLogin;
        private TextBox txblogin;
        private Label lblNome;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private TextBox txbSenha;
        private TextBox txbConfsenha;
        private TextBox txbNome;
        private Button btnLimpar;
        private Button btnCadastrar;
        private Button btnVoltar;
    }
}