namespace Projetos
{
    partial class BancoDeDados
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
            LstBanco = new ListBox();
            SuspendLayout();
            // 
            // LstBanco
            // 
            LstBanco.FormattingEnabled = true;
            LstBanco.Location = new Point(275, 12);
            LstBanco.Name = "LstBanco";
            LstBanco.Size = new Size(282, 404);
            LstBanco.TabIndex = 0;
            // 
            // BancoDeDados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstBanco);
            Name = "BancoDeDados";
            Text = "BancoDeDados";
            Load += BancoDeDados_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstBanco;
    }
}