namespace PracGeraldineStreams
{
    partial class FormListarPalabras
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
            this.listPalabras = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPalabras
            // 
            this.listPalabras.FormattingEnabled = true;
            this.listPalabras.Location = new System.Drawing.Point(59, 36);
            this.listPalabras.Name = "listPalabras";
            this.listPalabras.Size = new System.Drawing.Size(246, 212);
            this.listPalabras.TabIndex = 0;
            this.listPalabras.SelectedIndexChanged += new System.EventHandler(this.listPalabras_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(170, 268);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(70, 33);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormListarPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 360);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.listPalabras);
            this.Name = "FormListarPalabras";
            this.Text = "FormListarPalabras";
            this.Load += new System.EventHandler(this.FormListarPalabras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPalabras;
        private System.Windows.Forms.Button btnAceptar;
    }
}