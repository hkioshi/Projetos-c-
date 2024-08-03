namespace Projetos
{
    partial class ParOuImpar
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
            txtPOI = new TextBox();
            lblPOI = new Label();
            btnPOI = new Button();
            lblN = new Label();
            SuspendLayout();
            // 
            // txtPOI
            // 
            txtPOI.Font = new Font("Segoe UI", 20F);
            txtPOI.Location = new Point(154, 153);
            txtPOI.Name = "txtPOI";
            txtPOI.Size = new Size(223, 52);
            txtPOI.TabIndex = 0;
            // 
            // lblPOI
            // 
            lblPOI.AutoSize = true;
            lblPOI.Location = new Point(154, 222);
            lblPOI.Name = "lblPOI";
            lblPOI.Size = new Size(0, 20);
            lblPOI.TabIndex = 1;
            // 
            // btnPOI
            // 
            btnPOI.Location = new Point(415, 118);
            btnPOI.Name = "btnPOI";
            btnPOI.Size = new Size(217, 137);
            btnPOI.TabIndex = 2;
            btnPOI.Text = "Par Ou Impar";
            btnPOI.UseVisualStyleBackColor = true;
            btnPOI.Click += btnPOI_Click;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(156, 126);
            lblN.Name = "lblN";
            lblN.Size = new Size(70, 20);
            lblN.TabIndex = 3;
            lblN.Text = "Numero: ";
            // 
            // ParOuImpar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblN);
            Controls.Add(btnPOI);
            Controls.Add(lblPOI);
            Controls.Add(txtPOI);
            Name = "ParOuImpar";
            Text = "ParOuImpar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPOI;
        private Label lblPOI;
        private Button btnPOI;
        private Label lblN;
    }
}