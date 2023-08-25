namespace WindowsFormsApp1
{
    partial class DetalleServicio
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
            this.label3 = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.CBServicio = new System.Windows.Forms.ComboBox();
            this.cantidad = new System.Windows.Forms.MaskedTextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.masterDataSet1 = new WindowsFormsApp1.MasterDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(63, 129);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(299, 21);
            this.CBArticulo.TabIndex = 1;
            // 
            // CBServicio
            // 
            this.CBServicio.FormattingEnabled = true;
            this.CBServicio.Location = new System.Drawing.Point(63, 95);
            this.CBServicio.Name = "CBServicio";
            this.CBServicio.Size = new System.Drawing.Size(299, 21);
            this.CBServicio.TabIndex = 1;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(63, 167);
            this.cantidad.Mask = "00000";
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(121, 20);
            this.cantidad.TabIndex = 2;
            this.cantidad.ValidatingType = typeof(int);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(368, 169);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(287, 169);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "MasterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 214);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.CBServicio);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetalleServicio";
            this.Text = "DetalleServicio";
            this.Load += new System.EventHandler(this.DetalleServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.ComboBox CBServicio;
        private System.Windows.Forms.MaskedTextBox cantidad;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private MasterDataSet masterDataSet1;
    }
}