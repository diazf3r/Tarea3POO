namespace WindowsFormsApp1
{
    partial class MasterForm
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
            this.SelectTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new WindowsFormsApp1.MasterDataSet();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectTabla
            // 
            this.SelectTabla.FormattingEnabled = true;
            this.SelectTabla.Items.AddRange(new object[] {
            "(Seleccione una opcion)",
            "Articulos",
            "Cliente",
            "Empleado",
            "Proveedor",
            "Servicio",
            "Detalle de Servicio"});
            this.SelectTabla.Location = new System.Drawing.Point(12, 99);
            this.SelectTabla.Name = "SelectTabla";
            this.SelectTabla.Size = new System.Drawing.Size(252, 21);
            this.SelectTabla.TabIndex = 0;
            this.SelectTabla.SelectedIndexChanged += new System.EventHandler(this.SelectTabla_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pantalla a mostrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToOrderColumns = true;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 135);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1007, 369);
            this.dg.TabIndex = 2;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "MasterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 510);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 48);
            this.save.TabIndex = 3;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(142, 510);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 48);
            this.delete.TabIndex = 3;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 584);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectTabla);
            this.Name = "MasterForm";
            this.Text = "Vista Maestra";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private MasterDataSet masterDataSet;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
    }
}

