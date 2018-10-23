namespace Facturación
{
    partial class F_Pago
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
            this.Combo_Box_Termino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBox_Inte_Haci = new System.Windows.Forms.CheckedListBox();
            this.ComboBox_Metodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LB_Vuelto = new System.Windows.Forms.Label();
            this.BT_Facturar = new System.Windows.Forms.Button();
            this.Cambio = new System.Windows.Forms.Label();
            this.btn_descuento = new System.Windows.Forms.Button();
            this.Cobrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termino de Pago: ";
            // 
            // Combo_Box_Termino
            // 
            this.Combo_Box_Termino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Combo_Box_Termino.FormattingEnabled = true;
            this.Combo_Box_Termino.Location = new System.Drawing.Point(144, 52);
            this.Combo_Box_Termino.Name = "Combo_Box_Termino";
            this.Combo_Box_Termino.Size = new System.Drawing.Size(159, 21);
            this.Combo_Box_Termino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Método de Pago: ";
            // 
            // ListBox_Inte_Haci
            // 
            this.ListBox_Inte_Haci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ListBox_Inte_Haci.FormattingEnabled = true;
            this.ListBox_Inte_Haci.Items.AddRange(new object[] {
            "Interna",
            "Hacienda"});
            this.ListBox_Inte_Haci.Location = new System.Drawing.Point(158, 186);
            this.ListBox_Inte_Haci.Name = "ListBox_Inte_Haci";
            this.ListBox_Inte_Haci.Size = new System.Drawing.Size(136, 61);
            this.ListBox_Inte_Haci.TabIndex = 3;
            // 
            // ComboBox_Metodo
            // 
            this.ComboBox_Metodo.FormattingEnabled = true;
            this.ComboBox_Metodo.Location = new System.Drawing.Point(144, 122);
            this.ComboBox_Metodo.Name = "ComboBox_Metodo";
            this.ComboBox_Metodo.Size = new System.Drawing.Size(159, 21);
            this.ComboBox_Metodo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(332, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto por Pagar: ";
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl_Monto.Location = new System.Drawing.Point(501, 47);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Monto.TabIndex = 6;
            this.Lbl_Monto.Text = "--------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(342, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paga con: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LB_Vuelto
            // 
            this.LB_Vuelto.AutoSize = true;
            this.LB_Vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LB_Vuelto.Location = new System.Drawing.Point(353, 184);
            this.LB_Vuelto.Name = "LB_Vuelto";
            this.LB_Vuelto.Size = new System.Drawing.Size(68, 18);
            this.LB_Vuelto.TabIndex = 9;
            this.LB_Vuelto.Text = "Cambio: ";
            // 
            // BT_Facturar
            // 
            this.BT_Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BT_Facturar.Location = new System.Drawing.Point(558, 369);
            this.BT_Facturar.Name = "BT_Facturar";
            this.BT_Facturar.Size = new System.Drawing.Size(76, 30);
            this.BT_Facturar.TabIndex = 11;
            this.BT_Facturar.Text = "Facturar";
            this.BT_Facturar.UseVisualStyleBackColor = true;
            // 
            // Cambio
            // 
            this.Cambio.AutoSize = true;
            this.Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambio.Location = new System.Drawing.Point(501, 179);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(68, 25);
            this.Cambio.TabIndex = 13;
            this.Cambio.Text = "--------";
            // 
            // btn_descuento
            // 
            this.btn_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descuento.Location = new System.Drawing.Point(31, 305);
            this.btn_descuento.Name = "btn_descuento";
            this.btn_descuento.Size = new System.Drawing.Size(143, 27);
            this.btn_descuento.TabIndex = 14;
            this.btn_descuento.Text = "Descuento";
            this.btn_descuento.UseVisualStyleBackColor = true;
            this.btn_descuento.Click += new System.EventHandler(this.btn_descuento_Click);
            // 
            // Cobrar
            // 
            this.Cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cobrar.Location = new System.Drawing.Point(462, 245);
            this.Cobrar.Name = "Cobrar";
            this.Cobrar.Size = new System.Drawing.Size(75, 28);
            this.Cobrar.TabIndex = 15;
            this.Cobrar.Text = "Cobrar";
            this.Cobrar.UseVisualStyleBackColor = true;
            this.Cobrar.Click += new System.EventHandler(this.Cobrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de Factura: ";
            // 
            // F_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cobrar);
            this.Controls.Add(this.btn_descuento);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.BT_Facturar);
            this.Controls.Add(this.LB_Vuelto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_Metodo);
            this.Controls.Add(this.ListBox_Inte_Haci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combo_Box_Termino);
            this.Controls.Add(this.label1);
            this.Name = "F_Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_Box_Termino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ListBox_Inte_Haci;
        private System.Windows.Forms.ComboBox ComboBox_Metodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LB_Vuelto;
        private System.Windows.Forms.Button BT_Facturar;
        private System.Windows.Forms.Label Cambio;
        private System.Windows.Forms.Button btn_descuento;
        private System.Windows.Forms.Button Cobrar;
        private System.Windows.Forms.Label label5;
    }
}