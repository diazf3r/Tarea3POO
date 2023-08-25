namespace WindowsFormsApp1
{
    partial class ServicioCliente
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
            this.clienteCombo = new System.Windows.Forms.ComboBox();
            this.facturaDataGrid = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new WindowsFormsApp1.MasterDataSet();
            this.CrearInteraccionBtn = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.DetalleFacturaBtn = new System.Windows.Forms.Button();
            this.crearServicioBtn = new System.Windows.Forms.Button();
            this.crearVentaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteCombo
            // 
            this.clienteCombo.FormattingEnabled = true;
            this.clienteCombo.Location = new System.Drawing.Point(244, 99);
            this.clienteCombo.Name = "clienteCombo";
            this.clienteCombo.Size = new System.Drawing.Size(138, 21);
            this.clienteCombo.TabIndex = 0;
            this.clienteCombo.SelectedIndexChanged += new System.EventHandler(this.cambioSeleccionCliente);
            // 
            // facturaDataGrid
            // 
            this.facturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGrid.Location = new System.Drawing.Point(36, 165);
            this.facturaDataGrid.Name = "facturaDataGrid";
            this.facturaDataGrid.Size = new System.Drawing.Size(558, 150);
            this.facturaDataGrid.TabIndex = 1;
            this.facturaDataGrid.SelectionChanged += new System.EventHandler(this.FacturaSelectionChange);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "MasterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CrearInteraccionBtn
            // 
            this.CrearInteraccionBtn.Location = new System.Drawing.Point(197, 350);
            this.CrearInteraccionBtn.Name = "CrearInteraccionBtn";
            this.CrearInteraccionBtn.Size = new System.Drawing.Size(227, 23);
            this.CrearInteraccionBtn.TabIndex = 2;
            this.CrearInteraccionBtn.Text = "Crear Interaccion";
            this.CrearInteraccionBtn.UseVisualStyleBackColor = true;
            this.CrearInteraccionBtn.Click += new System.EventHandler(this.CrearInteraccionBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(285, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(240, 143);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Facturas Asociadas";
            // 
            // DetalleFacturaBtn
            // 
            this.DetalleFacturaBtn.Location = new System.Drawing.Point(255, 321);
            this.DetalleFacturaBtn.Name = "DetalleFacturaBtn";
            this.DetalleFacturaBtn.Size = new System.Drawing.Size(110, 23);
            this.DetalleFacturaBtn.TabIndex = 5;
            this.DetalleFacturaBtn.Text = "Detalle de Factura";
            this.DetalleFacturaBtn.UseVisualStyleBackColor = true;
            this.DetalleFacturaBtn.Click += new System.EventHandler(this.DetalleFacturaBtn_Click);
            // 
            // crearServicioBtn
            // 
            this.crearServicioBtn.Location = new System.Drawing.Point(343, 378);
            this.crearServicioBtn.Name = "crearServicioBtn";
            this.crearServicioBtn.Size = new System.Drawing.Size(81, 23);
            this.crearServicioBtn.TabIndex = 6;
            this.crearServicioBtn.Text = "Crear Servicio";
            this.crearServicioBtn.UseVisualStyleBackColor = true;
            this.crearServicioBtn.Click += new System.EventHandler(this.crearServicioBtn_Click);
            // 
            // crearVentaBtn
            // 
            this.crearVentaBtn.Location = new System.Drawing.Point(197, 378);
            this.crearVentaBtn.Name = "crearVentaBtn";
            this.crearVentaBtn.Size = new System.Drawing.Size(75, 23);
            this.crearVentaBtn.TabIndex = 7;
            this.crearVentaBtn.Text = "Crear Venta";
            this.crearVentaBtn.UseVisualStyleBackColor = true;
            this.crearVentaBtn.Click += new System.EventHandler(this.crearVentaBtn_Click);
            // 
            // ServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 470);
            this.Controls.Add(this.crearVentaBtn);
            this.Controls.Add(this.crearServicioBtn);
            this.Controls.Add(this.DetalleFacturaBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CrearInteraccionBtn);
            this.Controls.Add(this.facturaDataGrid);
            this.Controls.Add(this.clienteCombo);
            this.Name = "ServicioCliente";
            this.Text = "ServicioCliente";
            this.Load += new System.EventHandler(this.ServicioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clienteCombo;
        private System.Windows.Forms.DataGridView facturaDataGrid;
        private MasterDataSet masterDataSet;
        private System.Windows.Forms.Button CrearInteraccionBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button DetalleFacturaBtn;
        private System.Windows.Forms.Button crearServicioBtn;
        private System.Windows.Forms.Button crearVentaBtn;
    }
}