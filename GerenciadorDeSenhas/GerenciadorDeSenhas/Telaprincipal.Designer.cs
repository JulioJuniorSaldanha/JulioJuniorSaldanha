namespace GerenciadorDeSenhas
{
    partial class Tela_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lvServicos = new System.Windows.Forms.ListView();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colUsuario = new System.Windows.Forms.ColumnHeader();
            this.colSenha = new System.Windows.Forms.ColumnHeader();
            this.collink = new System.Windows.Forms.ColumnHeader();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GerenciadorDeSenhas.Properties.Resources.kisspng_user_profile_computer_icons_user_interface_mystique_5aceb02483a7d5_1624122115234949485393;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(22, 205);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(167, 28);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Seja bem vindo";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(12, 263);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUser.Location = new System.Drawing.Point(12, 308);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(186, 39);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarSenha.Location = new System.Drawing.Point(12, 353);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(186, 39);
            this.btnAlterarSenha.TabIndex = 4;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::GerenciadorDeSenhas.Properties.Resources._48764_search_file_find_search_icon;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(916, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(39, 36);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(220, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(690, 23);
            this.textBox1.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::GerenciadorDeSenhas.Properties.Resources.add_77928;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Location = new System.Drawing.Point(961, 334);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(53, 51);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::GerenciadorDeSenhas.Properties.Resources.kisspng_computer_icons_scalable_vector_graphics_apple_icon_edit_png_icon_blue_pencil_5ab065d43019b7_7432604215215098441971;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Location = new System.Drawing.Point(961, 391);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(53, 51);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(961, 448);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(53, 51);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lvServicos
            // 
            this.lvServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNome,
            this.colUsuario,
            this.colSenha,
            this.collink});
            this.lvServicos.FullRowSelect = true;
            this.lvServicos.Location = new System.Drawing.Point(220, 69);
            this.lvServicos.MultiSelect = false;
            this.lvServicos.Name = "lvServicos";
            this.lvServicos.Size = new System.Drawing.Size(735, 487);
            this.lvServicos.TabIndex = 11;
            this.lvServicos.UseCompatibleStateImageBehavior = false;
            this.lvServicos.View = System.Windows.Forms.View.Details;
            this.lvServicos.SelectedIndexChanged += new System.EventHandler(this.lvServicos_SelectedIndexChanged);
            // 
            // colNome
            // 
            this.colNome.Text = "Serviço";
            this.colNome.Width = 120;
            // 
            // colUsuario
            // 
            this.colUsuario.Text = "Usuario";
            this.colUsuario.Width = 120;
            // 
            // colSenha
            // 
            this.colSenha.Text = "Senha";
            this.colSenha.Width = 120;
            // 
            // collink
            // 
            this.collink.Text = "Link";
            this.collink.Width = 200;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::GerenciadorDeSenhas.Properties.Resources._293271_replay_restart_refresh_icon;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(961, 505);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(53, 51);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Tela_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1039, 625);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lvServicos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tela_principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tela_principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Button btnHome;
        private Button btnUser;
        private Button btnAlterarSenha;
        private Button btnPesquisar;
        private TextBox textBox1;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnExcluir;
        private ListView lvServicos;
        private ColumnHeader colNome;
        private ColumnHeader colUsuario;
        private ColumnHeader colSenha;
        private ColumnHeader collink;
        private Button btnAtualizar;
        private ColumnHeader colID;
    }
}