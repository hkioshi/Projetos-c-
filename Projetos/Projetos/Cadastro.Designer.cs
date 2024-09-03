namespace Projetos
{
    partial class Cadastro
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCEmail = new TextBox();
            label4 = new Label();
            txtTel = new TextBox();
            label5 = new Label();
            txtSenha = new TextBox();
            label6 = new Label();
            txtCSenha = new TextBox();
            btn = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(154, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirmar email";
            // 
            // txtCEmail
            // 
            txtCEmail.Location = new Point(154, 100);
            txtCEmail.Name = "txtCEmail";
            txtCEmail.Size = new Size(125, 27);
            txtCEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 133);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "telefone";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(154, 133);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 166);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 9;
            label5.Text = "senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(154, 166);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 199);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 11;
            label6.Text = "Confirmar senha";
            // 
            // txtCSenha
            // 
            txtCSenha.Location = new Point(154, 199);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.Size = new Size(125, 27);
            txtCSenha.TabIndex = 10;
            // 
            // btn
            // 
            btn.Location = new Point(46, 247);
            btn.Name = "btn";
            btn.Size = new Size(218, 77);
            btn.TabIndex = 12;
            btn.Text = "Cadastrar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 360);
            Controls.Add(btn);
            Controls.Add(label6);
            Controls.Add(txtCSenha);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtTel);
            Controls.Add(label3);
            Controls.Add(txtCEmail);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCEmail;
        private Label label4;
        private TextBox txtTel;
        private Label label5;
        private TextBox txtSenha;
        private Label label6;
        private TextBox txtCSenha;
        private Button btn;
    }
}