
namespace CapaPresentacion
{
    partial class frmPrePedido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrePedido));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.CerrarFormulario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.cUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_PEDIDODataSet6 = new CapaPresentacion.GESTION_PEDIDODataSet6();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_PEDIDODataSet5 = new CapaPresentacion.GESTION_PEDIDODataSet5();
            this.btnAtras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSiguiente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cLIENTETableAdapter = new CapaPresentacion.GESTION_PEDIDODataSet5TableAdapters.CLIENTETableAdapter();
            this.cUENTATableAdapter = new CapaPresentacion.GESTION_PEDIDODataSet6TableAdapters.CUENTATableAdapter();
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.TopFormulario.Controls.Add(this.CerrarFormulario);
            this.TopFormulario.Controls.Add(this.pictureBox1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(335, 67);
            this.TopFormulario.TabIndex = 4;
            // 
            // CerrarFormulario
            // 
            this.CerrarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("CerrarFormulario.Image")));
            this.CerrarFormulario.Location = new System.Drawing.Point(289, 0);
            this.CerrarFormulario.Name = "CerrarFormulario";
            this.CerrarFormulario.Size = new System.Drawing.Size(46, 67);
            this.CerrarFormulario.TabIndex = 2;
            this.CerrarFormulario.TabStop = false;
            this.CerrarFormulario.Click += new System.EventHandler(this.CerrarFormulario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxCuenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(4, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cuenta";
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.DataSource = this.cUENTABindingSource;
            this.comboBoxCuenta.DisplayMember = "NUM_CUENTA";
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(4, 119);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(236, 32);
            this.comboBoxCuenta.TabIndex = 43;
            this.comboBoxCuenta.ValueMember = "BALANCE";
            // 
            // cUENTABindingSource
            // 
            this.cUENTABindingSource.DataMember = "CUENTA";
            this.cUENTABindingSource.DataSource = this.gESTION_PEDIDODataSet6;
            // 
            // gESTION_PEDIDODataSet6
            // 
            this.gESTION_PEDIDODataSet6.DataSetName = "GESTION_PEDIDODataSet6";
            this.gESTION_PEDIDODataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DataSource = this.cLIENTEBindingSource;
            this.comboBoxCliente.DisplayMember = "NOMBRE";
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(6, 51);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(236, 32);
            this.comboBoxCliente.TabIndex = 31;
            this.comboBoxCliente.ValueMember = "IDCLIENTE";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.gESTION_PEDIDODataSet5;
            // 
            // gESTION_PEDIDODataSet5
            // 
            this.gESTION_PEDIDODataSet5.DataSetName = "GESTION_PEDIDODataSet5";
            this.gESTION_PEDIDODataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAtras
            // 
            this.btnAtras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.BorderRadius = 0;
            this.btnAtras.ButtonText = "Atras";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAtras.Iconimage")));
            this.btnAtras.Iconimage_right = null;
            this.btnAtras.Iconimage_right_Selected = null;
            this.btnAtras.Iconimage_Selected = null;
            this.btnAtras.IconMarginLeft = 0;
            this.btnAtras.IconMarginRight = 0;
            this.btnAtras.IconRightVisible = true;
            this.btnAtras.IconRightZoom = 0D;
            this.btnAtras.IconVisible = true;
            this.btnAtras.IconZoom = 90D;
            this.btnAtras.IsTab = false;
            this.btnAtras.Location = new System.Drawing.Point(12, 276);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnAtras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAtras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtras.selected = false;
            this.btnAtras.Size = new System.Drawing.Size(134, 48);
            this.btnAtras.TabIndex = 45;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtras.Textcolor = System.Drawing.Color.White;
            this.btnAtras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.BorderRadius = 0;
            this.btnSiguiente.ButtonText = "Siguiente";
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.DisabledColor = System.Drawing.Color.Gray;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSiguiente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Iconimage = null;
            this.btnSiguiente.Iconimage_right = global::CapaPresentacion.Properties.Resources.icons8_derecha_círculo_48;
            this.btnSiguiente.Iconimage_right_Selected = null;
            this.btnSiguiente.Iconimage_Selected = null;
            this.btnSiguiente.IconMarginLeft = 0;
            this.btnSiguiente.IconMarginRight = 0;
            this.btnSiguiente.IconRightVisible = true;
            this.btnSiguiente.IconRightZoom = 0D;
            this.btnSiguiente.IconVisible = true;
            this.btnSiguiente.IconZoom = 90D;
            this.btnSiguiente.IsTab = false;
            this.btnSiguiente.Location = new System.Drawing.Point(174, 276);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnSiguiente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSiguiente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSiguiente.selected = false;
            this.btnSiguiente.Size = new System.Drawing.Size(131, 48);
            this.btnSiguiente.TabIndex = 46;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiguiente.Textcolor = System.Drawing.Color.White;
            this.btnSiguiente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cUENTATableAdapter
            // 
            this.cUENTATableAdapter.ClearBeforeFill = true;
            // 
            // frmPrePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrePedido";
            this.Load += new System.EventHandler(this.frmPrePedido_Load);
            this.TopFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.PictureBox CerrarFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtras;
        private Bunifu.Framework.UI.BunifuFlatButton btnSiguiente;
        private GESTION_PEDIDODataSet5 gESTION_PEDIDODataSet5;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private GESTION_PEDIDODataSet5TableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private GESTION_PEDIDODataSet6 gESTION_PEDIDODataSet6;
        private System.Windows.Forms.BindingSource cUENTABindingSource;
        private GESTION_PEDIDODataSet6TableAdapters.CUENTATableAdapter cUENTATableAdapter;
    }
}