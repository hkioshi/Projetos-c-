namespace Projetos
{
    partial class Calculadora
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
            txtn1 = new TextBox();
            txtn2 = new TextBox();
            lbln1 = new Label();
            label2 = new Label();
            btnCalc = new Button();
            rdbSoma = new RadioButton();
            rdbSub = new RadioButton();
            lblR = new Label();
            lblResult = new Label();
            rdbMult = new RadioButton();
            rdbDiv = new RadioButton();
            rdbMod = new RadioButton();
            rdbPot = new RadioButton();
            SuspendLayout();
            // 
            // txtn1
            // 
            txtn1.Location = new Point(88, 12);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(125, 27);
            txtn1.TabIndex = 0;
            txtn1.Text = "0";
            // 
            // txtn2
            // 
            txtn2.Location = new Point(88, 45);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(125, 27);
            txtn2.TabIndex = 1;
            txtn2.Text = "0";
            // 
            // lbln1
            // 
            lbln1.AutoSize = true;
            lbln1.Location = new Point(4, 19);
            lbln1.Name = "lbln1";
            lbln1.Size = new Size(78, 20);
            lbln1.TabIndex = 2;
            lbln1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Numero 2:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(597, 12);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(191, 129);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Checked = true;
            rdbSoma.Location = new Point(4, 94);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(68, 24);
            rdbSoma.TabIndex = 5;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            rdbSub.AutoSize = true;
            rdbSub.Location = new Point(4, 124);
            rdbSub.Name = "rdbSub";
            rdbSub.Size = new Size(97, 24);
            rdbSub.TabIndex = 6;
            rdbSub.Text = "Subtração";
            rdbSub.UseVisualStyleBackColor = true;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(322, 254);
            lblR.Name = "lblR";
            lblR.Size = new Size(78, 20);
            lblR.TabIndex = 7;
            lblR.Text = "Resultado:";
            lblR.Click += lblR_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(406, 254);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 8;
            // 
            // rdbMult
            // 
            rdbMult.AutoSize = true;
            rdbMult.Location = new Point(4, 154);
            rdbMult.Name = "rdbMult";
            rdbMult.Size = new Size(120, 24);
            rdbMult.TabIndex = 9;
            rdbMult.Text = "Multiplicação";
            rdbMult.UseVisualStyleBackColor = true;
            // 
            // rdbDiv
            // 
            rdbDiv.AutoSize = true;
            rdbDiv.Location = new Point(4, 184);
            rdbDiv.Name = "rdbDiv";
            rdbDiv.Size = new Size(79, 24);
            rdbDiv.TabIndex = 10;
            rdbDiv.Text = "Divisao";
            rdbDiv.UseVisualStyleBackColor = true;
            // 
            // rdbMod
            // 
            rdbMod.AutoSize = true;
            rdbMod.Location = new Point(4, 214);
            rdbMod.Name = "rdbMod";
            rdbMod.Size = new Size(82, 24);
            rdbMod.TabIndex = 11;
            rdbMod.Text = "Modulo";
            rdbMod.UseVisualStyleBackColor = true;
            rdbMod.CheckedChanged += rdbMod_CheckedChanged;
            // 
            // rdbPot
            // 
            rdbPot.AutoSize = true;
            rdbPot.Location = new Point(4, 244);
            rdbPot.Name = "rdbPot";
            rdbPot.Size = new Size(86, 24);
            rdbPot.TabIndex = 12;
            rdbPot.Text = "Potencia";
            rdbPot.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdbPot);
            Controls.Add(rdbMod);
            Controls.Add(rdbDiv);
            Controls.Add(rdbMult);
            Controls.Add(lblResult);
            Controls.Add(lblR);
            Controls.Add(rdbSub);
            Controls.Add(rdbSoma);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(lbln1);
            Controls.Add(txtn2);
            Controls.Add(txtn1);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtn1;
        private TextBox txtn2;
        private Label lbln1;
        private Label label2;
        private Button btnCalc;
        private RadioButton rdbSoma;
        private RadioButton rdbSub;
        private Label lblR;
        private Label lblResult;
        private RadioButton rdbMult;
        private RadioButton rdbDiv;
        private RadioButton rdbMod;
        private RadioButton rdbPot;
    }
}