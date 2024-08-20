namespace Projetos
{
    partial class Form1
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
            btnCalculadora = new Button();
            btnGeradorSenha = new Button();
            btnParOuImpar = new Button();
            btnCPF = new Button();
            btnGerarCPF = new Button();
            btnColorir = new Button();
            SuspendLayout();
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(12, 12);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(151, 62);
            btnCalculadora.TabIndex = 0;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnGeradorSenha
            // 
            btnGeradorSenha.Location = new Point(12, 80);
            btnGeradorSenha.Name = "btnGeradorSenha";
            btnGeradorSenha.Size = new Size(151, 62);
            btnGeradorSenha.TabIndex = 1;
            btnGeradorSenha.Text = "Gerador De Senha";
            btnGeradorSenha.UseVisualStyleBackColor = true;
            btnGeradorSenha.Click += btnGeradorSenha_Click;
            // 
            // btnParOuImpar
            // 
            btnParOuImpar.Location = new Point(12, 148);
            btnParOuImpar.Name = "btnParOuImpar";
            btnParOuImpar.Size = new Size(151, 62);
            btnParOuImpar.TabIndex = 2;
            btnParOuImpar.Text = "Par ou Impar";
            btnParOuImpar.UseVisualStyleBackColor = true;
            btnParOuImpar.Click += button1_Click;
            // 
            // btnCPF
            // 
            btnCPF.Location = new Point(12, 216);
            btnCPF.Name = "btnCPF";
            btnCPF.Size = new Size(151, 62);
            btnCPF.TabIndex = 3;
            btnCPF.Text = "Validador de CPF";
            btnCPF.UseVisualStyleBackColor = true;
            btnCPF.Click += button1_Click_1;
            // 
            // btnGerarCPF
            // 
            btnGerarCPF.Location = new Point(12, 284);
            btnGerarCPF.Name = "btnGerarCPF";
            btnGerarCPF.Size = new Size(151, 62);
            btnGerarCPF.TabIndex = 4;
            btnGerarCPF.Text = "GerarCPF";
            btnGerarCPF.UseVisualStyleBackColor = true;
            btnGerarCPF.Click += button2_Click;
            // 
            // btnColorir
            // 
            btnColorir.Location = new Point(12, 352);
            btnColorir.Name = "btnColorir";
            btnColorir.Size = new Size(151, 62);
            btnColorir.TabIndex = 5;
            btnColorir.Text = "Bolinha";
            btnColorir.UseVisualStyleBackColor = true;
            btnColorir.Click += btnColorir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColorir);
            Controls.Add(btnGerarCPF);
            Controls.Add(btnCPF);
            Controls.Add(btnParOuImpar);
            Controls.Add(btnGeradorSenha);
            Controls.Add(btnCalculadora);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculadora;
        private Button btnGeradorSenha;
        private Button btnParOuImpar;
        private Button btnCPF;
        private Button btnGerarCPF;
        private Button btnColorir;
    }
}
