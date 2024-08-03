namespace Projetos
{
    partial class Gerador_De_Senha
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
            chcMa = new CheckBox();
            chcMi = new CheckBox();
            chcCE = new CheckBox();
            chcNum = new CheckBox();
            nmrNuns = new NumericUpDown();
            label1 = new Label();
            btnGerar = new Button();
            lblS = new Label();
            lblSenha = new Label();
            btnCopiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrNuns).BeginInit();
            SuspendLayout();
            // 
            // chcMa
            // 
            chcMa.AutoSize = true;
            chcMa.Location = new Point(12, 36);
            chcMa.Name = "chcMa";
            chcMa.Size = new Size(146, 24);
            chcMa.TabIndex = 0;
            chcMa.Text = "Letras Maiusculas";
            chcMa.UseVisualStyleBackColor = true;
            // 
            // chcMi
            // 
            chcMi.AutoSize = true;
            chcMi.Location = new Point(12, 66);
            chcMi.Name = "chcMi";
            chcMi.Size = new Size(146, 24);
            chcMi.TabIndex = 1;
            chcMi.Text = "Letras Minusculas";
            chcMi.UseVisualStyleBackColor = true;
            // 
            // chcCE
            // 
            chcCE.AutoSize = true;
            chcCE.Location = new Point(12, 126);
            chcCE.Name = "chcCE";
            chcCE.Size = new Size(164, 24);
            chcCE.TabIndex = 3;
            chcCE.Text = "Caracteres Especiais";
            chcCE.UseVisualStyleBackColor = true;
            // 
            // chcNum
            // 
            chcNum.AutoSize = true;
            chcNum.Checked = true;
            chcNum.CheckState = CheckState.Checked;
            chcNum.Location = new Point(12, 96);
            chcNum.Name = "chcNum";
            chcNum.Size = new Size(91, 24);
            chcNum.TabIndex = 2;
            chcNum.Text = "Numeros";
            chcNum.UseVisualStyleBackColor = true;
            // 
            // nmrNuns
            // 
            nmrNuns.Location = new Point(167, 7);
            nmrNuns.Name = "nmrNuns";
            nmrNuns.Size = new Size(150, 27);
            nmrNuns.TabIndex = 4;
            nmrNuns.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 5;
            label1.Text = "Numero de Carcteres";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(12, 328);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(339, 110);
            btnGerar.TabIndex = 6;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Location = new Point(17, 186);
            lblS.Name = "lblS";
            lblS.Size = new Size(103, 20);
            lblS.TabIndex = 7;
            lblS.Text = "Senha gerada:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(126, 186);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(0, 20);
            lblSenha.TabIndex = 8;
            // 
            // btnCopiar
            // 
            btnCopiar.Enabled = false;
            btnCopiar.Location = new Point(18, 221);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(94, 29);
            btnCopiar.TabIndex = 9;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // Gerador_De_Senha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopiar);
            Controls.Add(lblSenha);
            Controls.Add(lblS);
            Controls.Add(btnGerar);
            Controls.Add(label1);
            Controls.Add(nmrNuns);
            Controls.Add(chcCE);
            Controls.Add(chcNum);
            Controls.Add(chcMi);
            Controls.Add(chcMa);
            Name = "Gerador_De_Senha";
            Text = "Gerador_De_Senha";
            ((System.ComponentModel.ISupportInitialize)nmrNuns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chcMa;
        private CheckBox chcMi;
        private CheckBox chcCE;
        private CheckBox chcNum;
        private NumericUpDown nmrNuns;
        private Label label1;
        private Button btnGerar;
        private Label lblS;
        private Label lblSenha;
        private Button btnCopiar;
    }
}