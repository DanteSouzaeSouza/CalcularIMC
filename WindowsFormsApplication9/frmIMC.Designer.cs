namespace WindowsFormsApplication9
{
    partial class FrmIMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso em kg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura em m:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(119, 15);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(119, 54);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(53, 94);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(132, 39);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 144);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIMC";
            this.Text = "Calcular o IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcula;
    }
}

