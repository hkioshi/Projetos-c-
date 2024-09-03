namespace Projetos
{
    partial class Login
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
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            btnEsqueciSenha = new Button();
            lblConctado = new Label();
            lblNome = new Label();
            lblTel = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(63, 12);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 27);
            txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(11, 12);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "email";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(11, 45);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(63, 45);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(11, 78);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 113);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Location = new Point(338, 119);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(140, 29);
            btnEsqueciSenha.TabIndex = 6;
            btnEsqueciSenha.Text = "Esqueci a senha";
            btnEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // lblConctado
            // 
            lblConctado.AutoSize = true;
            lblConctado.Location = new Point(228, 15);
            lblConctado.Name = "lblConctado";
            lblConctado.Size = new Size(45, 20);
            lblConctado.TabIndex = 7;
            lblConctado.Text = "Texto";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(350, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 20);
            lblNome.TabIndex = 9;
            lblNome.Text = "Texto";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(350, 45);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(45, 20);
            lblTel.TabIndex = 10;
            lblTel.Text = "Texto";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 160);
            Controls.Add(lblTel);
            Controls.Add(lblNome);
            Controls.Add(lblConctado);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCadastrar;
        private Button btnEsqueciSenha;
        private Label lblConctado;
        private Label lblNome;
        private Label lblTel;
    }
}