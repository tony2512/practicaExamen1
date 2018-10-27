namespace PracticaExamen1
{
    partial class Form1
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
            this.cbmedida = new System.Windows.Forms.ComboBox();
            this.cbcuadrado = new System.Windows.Forms.ComboBox();
            this.primerLado = new System.Windows.Forms.NumericUpDown();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.primerLado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmedida
            // 
            this.cbmedida.FormattingEnabled = true;
            this.cbmedida.Items.AddRange(new object[] {
            "Area"});
            this.cbmedida.Location = new System.Drawing.Point(199, 65);
            this.cbmedida.Name = "cbmedida";
            this.cbmedida.Size = new System.Drawing.Size(121, 21);
            this.cbmedida.TabIndex = 0;
            // 
            // cbcuadrado
            // 
            this.cbcuadrado.FormattingEnabled = true;
            this.cbcuadrado.Items.AddRange(new object[] {
            "Cuadrado"});
            this.cbcuadrado.Location = new System.Drawing.Point(199, 103);
            this.cbcuadrado.Name = "cbcuadrado";
            this.cbcuadrado.Size = new System.Drawing.Size(121, 21);
            this.cbcuadrado.TabIndex = 1;
            // 
            // primerLado
            // 
            this.primerLado.DecimalPlaces = 1;
            this.primerLado.Location = new System.Drawing.Point(199, 143);
            this.primerLado.Name = "primerLado";
            this.primerLado.Size = new System.Drawing.Size(120, 20);
            this.primerLado.TabIndex = 2;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(95, 68);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(42, 13);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Calculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Forma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lado 1";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(98, 197);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(233, 23);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(199, 247);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(121, 20);
            this.tbResultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.primerLado);
            this.Controls.Add(this.cbcuadrado);
            this.Controls.Add(this.cbmedida);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.primerLado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmedida;
        private System.Windows.Forms.ComboBox cbcuadrado;
        private System.Windows.Forms.NumericUpDown primerLado;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label3;
    }
}

