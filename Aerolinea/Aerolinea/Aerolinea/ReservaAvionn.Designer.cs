namespace Aerolinea
{
    partial class ReservaAvionn
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
            this.txtOcup4 = new System.Windows.Forms.TextBox();
            this.txtOchenta = new System.Windows.Forms.TextBox();
            this.txtCuarenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOcup8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOcup4
            // 
            this.txtOcup4.Location = new System.Drawing.Point(228, 57);
            this.txtOcup4.Multiline = true;
            this.txtOcup4.Name = "txtOcup4";
            this.txtOcup4.Size = new System.Drawing.Size(129, 39);
            this.txtOcup4.TabIndex = 24;
            this.txtOcup4.TextChanged += new System.EventHandler(this.txtAviones_TextChanged);
            // 
            // txtOchenta
            // 
            this.txtOchenta.Location = new System.Drawing.Point(31, 173);
            this.txtOchenta.Multiline = true;
            this.txtOchenta.Name = "txtOchenta";
            this.txtOchenta.Size = new System.Drawing.Size(117, 35);
            this.txtOchenta.TabIndex = 22;
            // 
            // txtCuarenta
            // 
            this.txtCuarenta.Location = new System.Drawing.Point(31, 57);
            this.txtCuarenta.Multiline = true;
            this.txtCuarenta.Name = "txtCuarenta";
            this.txtCuarenta.Size = new System.Drawing.Size(117, 35);
            this.txtCuarenta.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aviones 80:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Aviones 40:";
            // 
            // txtOcup8
            // 
            this.txtOcup8.Location = new System.Drawing.Point(228, 173);
            this.txtOcup8.Multiline = true;
            this.txtOcup8.Name = "txtOcup8";
            this.txtOcup8.Size = new System.Drawing.Size(129, 39);
            this.txtOcup8.TabIndex = 24;
            this.txtOcup8.TextChanged += new System.EventHandler(this.txtAviones_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ocupacion Aviones:";
            // 
            // ReservaAvionn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(403, 276);
            this.Controls.Add(this.txtOcup8);
            this.Controls.Add(this.txtOcup4);
            this.Controls.Add(this.txtOchenta);
            this.Controls.Add(this.txtCuarenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "ReservaAvionn";
            this.Text = "ReservaAvionn";
            this.Load += new System.EventHandler(this.ReservaAvionn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcup4;
        private System.Windows.Forms.TextBox txtOchenta;
        private System.Windows.Forms.TextBox txtCuarenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOcup8;
        private System.Windows.Forms.Label label1;
    }
}