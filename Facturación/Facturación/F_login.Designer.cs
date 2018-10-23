namespace Facturación
{
    partial class F_login
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
            this.BtnAcUs = new System.Windows.Forms.Button();
            this.TBXCUS = new System.Windows.Forms.TextBox();
            this.LbLog = new System.Windows.Forms.Label();
            this.LbCU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAcUs
            // 
            this.BtnAcUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcUs.Location = new System.Drawing.Point(297, 336);
            this.BtnAcUs.Name = "BtnAcUs";
            this.BtnAcUs.Size = new System.Drawing.Size(85, 32);
            this.BtnAcUs.TabIndex = 0;
            this.BtnAcUs.Text = "Acceder";
            this.BtnAcUs.UseVisualStyleBackColor = true;
            this.BtnAcUs.Click += new System.EventHandler(this.BtnAcUs_Click);
            // 
            // TBXCUS
            // 
            this.TBXCUS.Location = new System.Drawing.Point(245, 151);
            this.TBXCUS.Name = "TBXCUS";
            this.TBXCUS.Size = new System.Drawing.Size(170, 20);
            this.TBXCUS.TabIndex = 1;
            this.TBXCUS.TextChanged += new System.EventHandler(this.TBXCUS_TextChanged);
            // 
            // LbLog
            // 
            this.LbLog.AutoSize = true;
            this.LbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLog.Location = new System.Drawing.Point(270, 9);
            this.LbLog.Name = "LbLog";
            this.LbLog.Size = new System.Drawing.Size(101, 37);
            this.LbLog.TabIndex = 4;
            this.LbLog.Text = "Login";
            // 
            // LbCU
            // 
            this.LbCU.AutoSize = true;
            this.LbCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCU.Location = new System.Drawing.Point(264, 94);
            this.LbCU.Name = "LbCU";
            this.LbCU.Size = new System.Drawing.Size(140, 24);
            this.LbCU.TabIndex = 5;
            this.LbCU.Text = "Código Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código de Caja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 411);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbCU);
            this.Controls.Add(this.LbLog);
            this.Controls.Add(this.TBXCUS);
            this.Controls.Add(this.BtnAcUs);
            this.Name = "F_login";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcUs;
        private System.Windows.Forms.TextBox TBXCUS;
        private System.Windows.Forms.Label LbLog;
        private System.Windows.Forms.Label LbCU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

