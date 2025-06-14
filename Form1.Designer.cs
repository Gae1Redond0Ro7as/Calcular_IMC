namespace Calcular_IMC
{
    partial class FormCalcularIMC
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
            lblEstatura = new Label();
            lblPeso = new Label();
            lblZancada = new Label();
            lblPasos = new Label();
            txtEstatura = new TextBox();
            txtPeso = new TextBox();
            txtZancada = new TextBox();
            txtPasos = new TextBox();
            btnIMC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.BackColor = SystemColors.Control;
            lblEstatura.BorderStyle = BorderStyle.FixedSingle;
            lblEstatura.ForeColor = SystemColors.ActiveCaptionText;
            lblEstatura.Location = new Point(42, 122);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(139, 22);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Indique su estatura:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = SystemColors.ButtonFace;
            lblPeso.BorderStyle = BorderStyle.FixedSingle;
            lblPeso.Location = new Point(42, 177);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(118, 22);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "Indique su peso:";
            // 
            // lblZancada
            // 
            lblZancada.AutoSize = true;
            lblZancada.BackColor = SystemColors.Control;
            lblZancada.BorderStyle = BorderStyle.FixedSingle;
            lblZancada.Location = new Point(42, 235);
            lblZancada.Name = "lblZancada";
            lblZancada.Size = new Size(141, 22);
            lblZancada.TabIndex = 2;
            lblZancada.Text = "Indique su zancada:";
            // 
            // lblPasos
            // 
            lblPasos.AutoSize = true;
            lblPasos.BackColor = SystemColors.Control;
            lblPasos.BorderStyle = BorderStyle.FixedSingle;
            lblPasos.Location = new Point(42, 286);
            lblPasos.Name = "lblPasos";
            lblPasos.Size = new Size(199, 22);
            lblPasos.TabIndex = 3;
            lblPasos.Text = "Indique su catidad de pasos:";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(254, 122);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(172, 27);
            txtEstatura.TabIndex = 4;
            txtEstatura.KeyPress += txtEstatura_KeyPress;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(254, 177);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(172, 27);
            txtPeso.TabIndex = 5;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // txtZancada
            // 
            txtZancada.Location = new Point(254, 235);
            txtZancada.Name = "txtZancada";
            txtZancada.Size = new Size(172, 27);
            txtZancada.TabIndex = 6;
            txtZancada.KeyPress += txtZancada_KeyPress;
            // 
            // txtPasos
            // 
            txtPasos.Location = new Point(254, 286);
            txtPasos.Name = "txtPasos";
            txtPasos.Size = new Size(172, 27);
            txtPasos.TabIndex = 7;
            txtPasos.KeyPress += txtPasos_KeyPress;
            // 
            // btnIMC
            // 
            btnIMC.BackColor = Color.Transparent;
            btnIMC.Location = new Point(254, 345);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(130, 29);
            btnIMC.TabIndex = 8;
            btnIMC.Text = "Calcular IMC";
            btnIMC.UseVisualStyleBackColor = false;
            btnIMC.Click += btnIMC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 129);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 9;
            label1.Text = "Ejemplo: 1.70";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 184);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 10;
            label2.Text = "Ejemplo: 50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 242);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 11;
            label3.Text = "Ejemplo: 0.90";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 293);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 12;
            label4.Text = "Ejemplo: 1000";
            // 
            // FormCalcularIMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(612, 562);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIMC);
            Controls.Add(txtPasos);
            Controls.Add(txtZancada);
            Controls.Add(txtPeso);
            Controls.Add(txtEstatura);
            Controls.Add(lblPasos);
            Controls.Add(lblZancada);
            Controls.Add(lblPeso);
            Controls.Add(lblEstatura);
            Name = "FormCalcularIMC";
            Text = "Calculador IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstatura;
        private Label lblPeso;
        private Label lblZancada;
        private Label lblPasos;
        private TextBox txtEstatura;
        private TextBox txtPeso;
        private TextBox txtZancada;
        private TextBox txtPasos;
        private Button btnIMC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
