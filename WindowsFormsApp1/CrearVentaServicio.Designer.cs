namespace WindowsFormsApp1
{
    partial class CrearVentaServicio
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
            this.masterDataSet = new WindowsFormsApp1.MasterDataSet();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listaArticuloServicioDataView = new System.Windows.Forms.DataGridView();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.detalleGridView = new System.Windows.Forms.DataGridView();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.crearDetalleBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaArticuloServicioDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "MasterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(221, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // listaArticuloServicioDataView
            // 
            this.listaArticuloServicioDataView.AllowUserToAddRows = false;
            this.listaArticuloServicioDataView.AllowUserToDeleteRows = false;
            this.listaArticuloServicioDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaArticuloServicioDataView.Location = new System.Drawing.Point(107, 109);
            this.listaArticuloServicioDataView.Name = "listaArticuloServicioDataView";
            this.listaArticuloServicioDataView.ReadOnly = true;
            this.listaArticuloServicioDataView.Size = new System.Drawing.Size(308, 150);
            this.listaArticuloServicioDataView.TabIndex = 1;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(209, 280);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(104, 23);
            this.agregarBtn.TabIndex = 2;
            this.agregarBtn.Text = "Agregar a Factura";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // detalleGridView
            // 
            this.detalleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleGridView.Location = new System.Drawing.Point(33, 315);
            this.detalleGridView.Name = "detalleGridView";
            this.detalleGridView.Size = new System.Drawing.Size(461, 82);
            this.detalleGridView.TabIndex = 3;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(198, 409);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(130, 23);
            this.eliminarBtn.TabIndex = 4;
            this.eliminarBtn.Text = "Eliminar de Factura";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // crearDetalleBtn
            // 
            this.crearDetalleBtn.Location = new System.Drawing.Point(147, 452);
            this.crearDetalleBtn.Name = "crearDetalleBtn";
            this.crearDetalleBtn.Size = new System.Drawing.Size(225, 23);
            this.crearDetalleBtn.TabIndex = 5;
            this.crearDetalleBtn.Text = "Crear detalle";
            this.crearDetalleBtn.UseVisualStyleBackColor = true;
            this.crearDetalleBtn.Click += new System.EventHandler(this.crearDetalleBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(225, 481);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 6;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // CrearVentaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 531);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.crearDetalleBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.detalleGridView);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.listaArticuloServicioDataView);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CrearVentaServicio";
            this.Text = "CrearVentaServicio";
            this.Load += new System.EventHandler(this.CrearVentaServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaArticuloServicioDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterDataSet masterDataSet;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView listaArticuloServicioDataView;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DataGridView detalleGridView;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button crearDetalleBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}