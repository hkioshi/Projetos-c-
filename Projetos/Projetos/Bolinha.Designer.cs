namespace Projetos
{
    partial class Bolinha
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
            btnCriarBola = new Button();
            btnCair = new Button();
            SuspendLayout();
            // 
            // btnCriarBola
            // 
            btnCriarBola.Location = new Point(3, 12);
            btnCriarBola.Name = "btnCriarBola";
            btnCriarBola.Size = new Size(138, 45);
            btnCriarBola.TabIndex = 0;
            btnCriarBola.Text = "Criar";
            btnCriarBola.UseVisualStyleBackColor = true;
            btnCriarBola.Click += btnCriarBola_Click;
            // 
            // btnCair
            // 
            btnCair.Location = new Point(3, 63);
            btnCair.Name = "btnCair";
            btnCair.Size = new Size(138, 45);
            btnCair.TabIndex = 1;
            btnCair.Text = "gravidade";
            btnCair.UseVisualStyleBackColor = true;
            btnCair.Click += btnCair_Click;
            // 
            // Bolinha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCair);
            Controls.Add(btnCriarBola);
            Name = "Bolinha";
            Text = "Bolinha";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriarBola;
        private Button btnCair;
    }
}