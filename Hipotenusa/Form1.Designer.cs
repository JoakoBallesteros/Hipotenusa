namespace Hipotenusa
{
    partial class FrmHipotenusa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCateto1 = new System.Windows.Forms.TextBox();
            this.TxtCateto2 = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblCateto1 = new System.Windows.Forms.Label();
            this.LblCateto2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCateto1
            // 
            this.TxtCateto1.Location = new System.Drawing.Point(190, 72);
            this.TxtCateto1.Name = "TxtCateto1";
            this.TxtCateto1.Size = new System.Drawing.Size(163, 20);
            this.TxtCateto1.TabIndex = 0;
            // 
            // TxtCateto2
            // 
            this.TxtCateto2.Location = new System.Drawing.Point(521, 72);
            this.TxtCateto2.Name = "TxtCateto2";
            this.TxtCateto2.Size = new System.Drawing.Size(163, 20);
            this.TxtCateto2.TabIndex = 1;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(379, 195);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(33, 25);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "...";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(252, 278);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(276, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click_1);
            // 
            // LblCateto1
            // 
            this.LblCateto1.AutoSize = true;
            this.LblCateto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCateto1.Location = new System.Drawing.Point(94, 70);
            this.LblCateto1.Name = "LblCateto1";
            this.LblCateto1.Size = new System.Drawing.Size(101, 25);
            this.LblCateto1.TabIndex = 4;
            this.LblCateto1.Text = "Cateto 1";
            // 
            // LblCateto2
            // 
            this.LblCateto2.AutoSize = true;
            this.LblCateto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCateto2.Location = new System.Drawing.Point(414, 70);
            this.LblCateto2.Name = "LblCateto2";
            this.LblCateto2.Size = new System.Drawing.Size(101, 25);
            this.LblCateto2.TabIndex = 5;
            this.LblCateto2.Text = "Cateto 2";
            // 
            // FrmHipotenusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCateto2);
            this.Controls.Add(this.LblCateto1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtCateto2);
            this.Controls.Add(this.TxtCateto1);
            this.Name = "FrmHipotenusa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCateto1;
        private System.Windows.Forms.TextBox TxtCateto2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblCateto1;
        private System.Windows.Forms.Label LblCateto2;
    }
}

