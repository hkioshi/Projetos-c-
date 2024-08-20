namespace Projetos
{
    partial class Validador_de_CPF
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
            txtCPF = new TextBox();
            btnCPF = new Button();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 14F);
            txtCPF.Location = new Point(12, 12);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "Apenas Numeros";
            txtCPF.Size = new Size(203, 39);
            txtCPF.TabIndex = 0;
            txtCPF.TextChanged += txtCPF_TextChanged;
            txtCPF.KeyPress += textBox1_KeyPress;
            // 
            // btnCPF
            // 
            btnCPF.Location = new Point(12, 57);
            btnCPF.Name = "btnCPF";
            btnCPF.Size = new Size(160, 96);
            btnCPF.TabIndex = 1;
            btnCPF.Text = "Validar";
            btnCPF.UseVisualStyleBackColor = true;
            btnCPF.Click += btnCPF_Click;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI", 12F);
            lblValidar.Location = new Point(221, 17);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(65, 28);
            lblValidar.TabIndex = 2;
            lblValidar.Text = "label1";
            // 
            // Validador_de_CPF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidar);
            Controls.Add(btnCPF);
            Controls.Add(txtCPF);
            Name = "Validador_de_CPF";
            Text = "Validador_de_CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPF;
        private Button btnCPF;
        private Label lblValidar;
    }
}