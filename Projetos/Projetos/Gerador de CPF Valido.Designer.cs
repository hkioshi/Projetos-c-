namespace Projetos
{
    partial class Gerador_de_CPF_Valido
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
            btnGerar = new Button();
            lblResult = new Label();
            btnCopiar = new Button();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(12, 12);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(158, 91);
            btnGerar.TabIndex = 0;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(176, 29);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // btnCopiar
            // 
            btnCopiar.Enabled = false;
            btnCopiar.Location = new Point(176, 61);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(94, 29);
            btnCopiar.TabIndex = 2;
            btnCopiar.Text = "Copiar Texto";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // Gerador_de_CPF_Valido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopiar);
            Controls.Add(lblResult);
            Controls.Add(btnGerar);
            Name = "Gerador_de_CPF_Valido";
            Text = "Gerador_de_CPF_Valido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerar;
        private Label lblResult;
        private Button btnCopiar;
    }
}