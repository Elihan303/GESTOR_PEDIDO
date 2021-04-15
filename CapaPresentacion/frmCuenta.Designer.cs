
namespace CapaPresentacion
{
    partial class frmCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuenta));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizarFormulario = new System.Windows.Forms.PictureBox();
            this.RestaurarFormulario = new System.Windows.Forms.PictureBox();
            this.CerrarFormulario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_PEDIDODataSet = new CapaPresentacion.GESTION_PEDIDODataSet();
            this.textNumeroCuenta = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.cUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_PEDIDODataSet1 = new CapaPresentacion.GESTION_PEDIDODataSet1();
            this.textMontoIngreso = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarMonto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cLIENTETableAdapter = new CapaPresentacion.GESTION_PEDIDODataSetTableAdapters.CLIENTETableAdapter();
            this.cUENTATableAdapter = new CapaPresentacion.GESTION_PEDIDODataSet1TableAdapters.CUENTATableAdapter();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnEliminarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.TopFormulario.Controls.Add(this.label1);
            this.TopFormulario.Controls.Add(this.MinimizarFormulario);
            this.TopFormulario.Controls.Add(this.RestaurarFormulario);
            this.TopFormulario.Controls.Add(this.CerrarFormulario);
            this.TopFormulario.Controls.Add(this.pictureBox1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(800, 67);
            this.TopFormulario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            // 
            // MinimizarFormulario
            // 
            this.MinimizarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarFormulario.Image")));
            this.MinimizarFormulario.Location = new System.Drawing.Point(662, 0);
            this.MinimizarFormulario.Name = "MinimizarFormulario";
            this.MinimizarFormulario.Size = new System.Drawing.Size(46, 67);
            this.MinimizarFormulario.TabIndex = 4;
            this.MinimizarFormulario.TabStop = false;
            this.MinimizarFormulario.Click += new System.EventHandler(this.MinimizarFormulario_Click);
            // 
            // RestaurarFormulario
            // 
            this.RestaurarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.RestaurarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarFormulario.Image")));
            this.RestaurarFormulario.Location = new System.Drawing.Point(708, 0);
            this.RestaurarFormulario.Name = "RestaurarFormulario";
            this.RestaurarFormulario.Size = new System.Drawing.Size(46, 67);
            this.RestaurarFormulario.TabIndex = 3;
            this.RestaurarFormulario.TabStop = false;
            this.RestaurarFormulario.Click += new System.EventHandler(this.RestaurarFormulario_Click);
            // 
            // CerrarFormulario
            // 
            this.CerrarFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("CerrarFormulario.Image")));
            this.CerrarFormulario.Location = new System.Drawing.Point(754, 0);
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
            // textBalance
            // 
            this.textBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBalance.Location = new System.Drawing.Point(18, 224);
            this.textBalance.Multiline = true;
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(223, 29);
            this.textBalance.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(236, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Balance";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DataSource = this.cLIENTEBindingSource;
            this.comboBoxCliente.DisplayMember = "NOMBRE";
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(12, 159);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(236, 21);
            this.comboBoxCliente.TabIndex = 26;
            this.comboBoxCliente.ValueMember = "IDCLIENTE";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.gESTION_PEDIDODataSet;
            // 
            // gESTION_PEDIDODataSet
            // 
            this.gESTION_PEDIDODataSet.DataSetName = "GESTION_PEDIDODataSet";
            this.gESTION_PEDIDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textNumeroCuenta
            // 
            this.textNumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroCuenta.Location = new System.Drawing.Point(18, 295);
            this.textNumeroCuenta.Multiline = true;
            this.textNumeroCuenta.Name = "textNumeroCuenta";
            this.textNumeroCuenta.Size = new System.Drawing.Size(223, 29);
            this.textNumeroCuenta.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numero de cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Crear cuenta";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCrearCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearCuenta.BorderRadius = 0;
            this.btnCrearCuenta.ButtonText = "Crear cuenta";
            this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCrearCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCrearCuenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCrearCuenta.Iconimage")));
            this.btnCrearCuenta.Iconimage_right = null;
            this.btnCrearCuenta.Iconimage_right_Selected = null;
            this.btnCrearCuenta.Iconimage_Selected = null;
            this.btnCrearCuenta.IconMarginLeft = 0;
            this.btnCrearCuenta.IconMarginRight = 0;
            this.btnCrearCuenta.IconRightVisible = true;
            this.btnCrearCuenta.IconRightZoom = 0D;
            this.btnCrearCuenta.IconVisible = true;
            this.btnCrearCuenta.IconZoom = 90D;
            this.btnCrearCuenta.IsTab = false;
            this.btnCrearCuenta.Location = new System.Drawing.Point(10, 351);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCrearCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCrearCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCrearCuenta.selected = false;
            this.btnCrearCuenta.Size = new System.Drawing.Size(238, 48);
            this.btnCrearCuenta.TabIndex = 33;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrearCuenta.Textcolor = System.Drawing.Color.White;
            this.btnCrearCuenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(381, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 386);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(412, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Añadir balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(410, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cuenta";
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.DataSource = this.cUENTABindingSource;
            this.comboBoxCuenta.DisplayMember = "NUM_CUENTA";
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(410, 159);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(236, 21);
            this.comboBoxCuenta.TabIndex = 38;
            this.comboBoxCuenta.ValueMember = "IDCUENTA";
            // 
            // cUENTABindingSource
            // 
            this.cUENTABindingSource.DataMember = "CUENTA";
            this.cUENTABindingSource.DataSource = this.gESTION_PEDIDODataSet1;
            // 
            // gESTION_PEDIDODataSet1
            // 
            this.gESTION_PEDIDODataSet1.DataSetName = "GESTION_PEDIDODataSet1";
            this.gESTION_PEDIDODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textMontoIngreso
            // 
            this.textMontoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMontoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoIngreso.Location = new System.Drawing.Point(416, 224);
            this.textMontoIngreso.Multiline = true;
            this.textMontoIngreso.Name = "textMontoIngreso";
            this.textMontoIngreso.Size = new System.Drawing.Size(223, 29);
            this.textMontoIngreso.TabIndex = 37;
            this.textMontoIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoIngreso_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(410, 218);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(236, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(410, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Monto a ingresar";
            // 
            // btnAgregarMonto
            // 
            this.btnAgregarMonto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnAgregarMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMonto.BorderRadius = 0;
            this.btnAgregarMonto.ButtonText = "Agregar monto";
            this.btnAgregarMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMonto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarMonto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarMonto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarMonto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMonto.Iconimage")));
            this.btnAgregarMonto.Iconimage_right = null;
            this.btnAgregarMonto.Iconimage_right_Selected = null;
            this.btnAgregarMonto.Iconimage_Selected = null;
            this.btnAgregarMonto.IconMarginLeft = 0;
            this.btnAgregarMonto.IconMarginRight = 0;
            this.btnAgregarMonto.IconRightVisible = true;
            this.btnAgregarMonto.IconRightZoom = 0D;
            this.btnAgregarMonto.IconVisible = true;
            this.btnAgregarMonto.IconZoom = 90D;
            this.btnAgregarMonto.IsTab = false;
            this.btnAgregarMonto.Location = new System.Drawing.Point(408, 276);
            this.btnAgregarMonto.Name = "btnAgregarMonto";
            this.btnAgregarMonto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnAgregarMonto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarMonto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarMonto.selected = false;
            this.btnAgregarMonto.Size = new System.Drawing.Size(238, 48);
            this.btnAgregarMonto.TabIndex = 44;
            this.btnAgregarMonto.Text = "Agregar monto";
            this.btnAgregarMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMonto.Textcolor = System.Drawing.Color.White;
            this.btnAgregarMonto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMonto.Click += new System.EventHandler(this.btnAgregarMonto_Click);
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cUENTATableAdapter
            // 
            this.cUENTATableAdapter.ClearBeforeFill = true;
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.TopFormulario;
            this.moverFormulario.Vertical = true;
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnEliminarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCuenta.BorderRadius = 0;
            this.btnEliminarCuenta.ButtonText = "Eliminar cuenta";
            this.btnEliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarCuenta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCuenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCuenta.Iconimage")));
            this.btnEliminarCuenta.Iconimage_right = null;
            this.btnEliminarCuenta.Iconimage_right_Selected = null;
            this.btnEliminarCuenta.Iconimage_Selected = null;
            this.btnEliminarCuenta.IconMarginLeft = 0;
            this.btnEliminarCuenta.IconMarginRight = 0;
            this.btnEliminarCuenta.IconRightVisible = true;
            this.btnEliminarCuenta.IconRightZoom = 0D;
            this.btnEliminarCuenta.IconVisible = true;
            this.btnEliminarCuenta.IconZoom = 90D;
            this.btnEliminarCuenta.IsTab = false;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(410, 351);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnEliminarCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEliminarCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.selected = false;
            this.btnEliminarCuenta.Size = new System.Drawing.Size(238, 48);
            this.btnEliminarCuenta.TabIndex = 45;
            this.btnEliminarCuenta.Text = "Eliminar cuenta";
            this.btnEliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCuenta.Textcolor = System.Drawing.Color.White;
            this.btnEliminarCuenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCuenta);
            this.Controls.Add(this.btnAgregarMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCuenta);
            this.Controls.Add(this.textMontoIngreso);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNumeroCuenta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuenta";
            this.Load += new System.EventHandler(this.frmCuenta_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_PEDIDODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MinimizarFormulario;
        private System.Windows.Forms.PictureBox RestaurarFormulario;
        private System.Windows.Forms.PictureBox CerrarFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.TextBox textNumeroCuenta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnCrearCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.TextBox textMontoIngreso;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarMonto;
        private GESTION_PEDIDODataSet gESTION_PEDIDODataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private GESTION_PEDIDODataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private GESTION_PEDIDODataSet1 gESTION_PEDIDODataSet1;
        private System.Windows.Forms.BindingSource cUENTABindingSource;
        private GESTION_PEDIDODataSet1TableAdapters.CUENTATableAdapter cUENTATableAdapter;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCuenta;
    }
}