namespace GerenciadorDeSenhas
{
    partial class CadatrarServico
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLogindoServico = new System.Windows.Forms.Label();
            this.lblSenhadoServico = new System.Windows.Forms.Label();
            this.txbLoginSer = new System.Windows.Forms.TextBox();
            this.txbSenhaSer = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.txbLink = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(257, 138);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(402, 23);
            this.txbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(123, 138);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do serviço";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(228, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(421, 56);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerenciador de senhas SW";
            // 
            // lblLogindoServico
            // 
            this.lblLogindoServico.AutoSize = true;
            this.lblLogindoServico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblLogindoServico.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogindoServico.Location = new System.Drawing.Point(123, 192);
            this.lblLogindoServico.Name = "lblLogindoServico";
            this.lblLogindoServico.Size = new System.Drawing.Size(124, 21);
            this.lblLogindoServico.TabIndex = 3;
            this.lblLogindoServico.Text = "Login do serviço";
            // 
            // lblSenhadoServico
            // 
            this.lblSenhadoServico.AutoSize = true;
            this.lblSenhadoServico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSenhadoServico.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenhadoServico.Location = new System.Drawing.Point(119, 243);
            this.lblSenhadoServico.Name = "lblSenhadoServico";
            this.lblSenhadoServico.Size = new System.Drawing.Size(128, 21);
            this.lblSenhadoServico.TabIndex = 4;
            this.lblSenhadoServico.Text = "Senha do serviço";
            // 
            // txbLoginSer
            // 
            this.txbLoginSer.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLoginSer.Location = new System.Drawing.Point(257, 184);
            this.txbLoginSer.Name = "txbLoginSer";
            this.txbLoginSer.Size = new System.Drawing.Size(402, 29);
            this.txbLoginSer.TabIndex = 5;
            // 
            // txbSenhaSer
            // 
            this.txbSenhaSer.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenhaSer.Location = new System.Drawing.Point(257, 235);
            this.txbSenhaSer.Name = "txbSenhaSer";
            this.txbSenhaSer.Size = new System.Drawing.Size(402, 29);
            this.txbSenhaSer.TabIndex = 6;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLink.Location = new System.Drawing.Point(208, 290);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(39, 21);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Link";
            // 
            // txbLink
            // 
            this.txbLink.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLink.Location = new System.Drawing.Point(257, 282);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(402, 29);
            this.txbLink.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(520, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 41);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(279, 362);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 41);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(226, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.Cursor = System.Windows.Forms.Cursors.No;
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(257, 104);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(104, 23);
            this.txbID.TabIndex = 14;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // CadatrarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(826, 478);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txbSenhaSer);
            this.Controls.Add(this.txbLoginSer);
            this.Controls.Add(this.lblSenhadoServico);
            this.Controls.Add(this.lblLogindoServico);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Name = "CadatrarServico";
            this.Text = "CadatrarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNome;
        private Label lblNome;
        private Label lblTitulo;
        private Label lblLogindoServico;
        private Label lblSenhadoServico;
        private TextBox txbLoginSer;
        private TextBox txbSenhaSer;
        private Label lblLink;
        private TextBox txbLink;
        private Button btnLimpar;
        private Button btnCadastrar;
        private Label lblID;
        private TextBox txbID;
    }
}