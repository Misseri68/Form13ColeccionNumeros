namespace WinFormsApp1
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
            lstElementos = new ListBox();
            btnGenerar = new Button();
            btnDatos = new Button();
            txtSuma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSumaPares = new TextBox();
            txtSumaImpares = new TextBox();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(21, 12);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(203, 334);
            lstElementos.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(255, 12);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(110, 34);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(255, 68);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(110, 39);
            btnDatos.TabIndex = 2;
            btnDatos.Text = "Mostrar Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(255, 171);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(110, 23);
            txtSuma.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 141);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 288);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Impares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 218);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(255, 248);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(110, 23);
            txtSumaPares.TabIndex = 7;
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(255, 323);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(110, 23);
            txtSumaImpares.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(txtSumaImpares);
            Controls.Add(txtSumaPares);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSuma);
            Controls.Add(btnDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstElementos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Button btnGenerar;
        private Button btnDatos;
        private TextBox txtSuma;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSumaPares;
        private TextBox txtSumaImpares;
    }
}
