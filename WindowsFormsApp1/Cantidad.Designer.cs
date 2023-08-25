namespace WindowsFormsApp1
{
    partial class Cantidad
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
            this.acetparbtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acetparbtn
            // 
            this.acetparbtn.Location = new System.Drawing.Point(57, 135);
            this.acetparbtn.Name = "acetparbtn";
            this.acetparbtn.Size = new System.Drawing.Size(75, 23);
            this.acetparbtn.TabIndex = 0;
            this.acetparbtn.Text = "Aceptar";
            this.acetparbtn.UseVisualStyleBackColor = true;
            this.acetparbtn.Click += new System.EventHandler(this.acetparbtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(138, 129);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(157, 34);
            this.CancelarBtn.TabIndex = 1;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.acetparbtn);
            this.Name = "Cantidad";
            this.Text = "Cantidad";
            this.Load += new System.EventHandler(this.Cantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acetparbtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}