
namespace CapaPresentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CerrarFormulario = new System.Windows.Forms.PictureBox();
            this.RestaurarFormulario = new System.Windows.Forms.PictureBox();
            this.MinimizarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BotFormulario = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).BeginInit();
            this.TopFormulario.SuspendLayout();
            this.BotFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestor de pedidos";
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
            this.TopFormulario.TabIndex = 1;
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "Clientes";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCliente.Iconimage")));
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 90D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(12, 73);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(123, 48);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.BorderRadius = 0;
            this.btnProducto.ButtonText = "Producto";
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProducto.Iconimage")));
            this.btnProducto.Iconimage_right = null;
            this.btnProducto.Iconimage_right_Selected = null;
            this.btnProducto.Iconimage_Selected = null;
            this.btnProducto.IconMarginLeft = 0;
            this.btnProducto.IconMarginRight = 0;
            this.btnProducto.IconRightVisible = true;
            this.btnProducto.IconRightZoom = 0D;
            this.btnProducto.IconVisible = true;
            this.btnProducto.IconZoom = 90D;
            this.btnProducto.IsTab = false;
            this.btnProducto.Location = new System.Drawing.Point(297, 73);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProducto.selected = false;
            this.btnProducto.Size = new System.Drawing.Size(123, 48);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Textcolor = System.Drawing.Color.White;
            this.btnProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedido.BorderRadius = 0;
            this.btnPedido.ButtonText = "Pedido";
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedido.Iconimage")));
            this.btnPedido.Iconimage_right = null;
            this.btnPedido.Iconimage_right_Selected = null;
            this.btnPedido.Iconimage_Selected = null;
            this.btnPedido.IconMarginLeft = 0;
            this.btnPedido.IconMarginRight = 0;
            this.btnPedido.IconRightVisible = true;
            this.btnPedido.IconRightZoom = 0D;
            this.btnPedido.IconVisible = true;
            this.btnPedido.IconZoom = 90D;
            this.btnPedido.IsTab = false;
            this.btnPedido.Location = new System.Drawing.Point(441, 73);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnPedido.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPedido.selected = false;
            this.btnPedido.Size = new System.Drawing.Size(123, 48);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Textcolor = System.Drawing.Color.White;
            this.btnPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // BotFormulario
            // 
            this.BotFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.BotFormulario.Controls.Add(this.pictureBox5);
            this.BotFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotFormulario.Location = new System.Drawing.Point(0, 383);
            this.BotFormulario.Name = "BotFormulario";
            this.BotFormulario.Size = new System.Drawing.Size(800, 67);
            this.BotFormulario.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(725, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuenta.BorderRadius = 0;
            this.btnCuenta.ButtonText = "Cuenta";
            this.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCuenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCuenta.Iconimage")));
            this.btnCuenta.Iconimage_right = null;
            this.btnCuenta.Iconimage_right_Selected = null;
            this.btnCuenta.Iconimage_Selected = null;
            this.btnCuenta.IconMarginLeft = 0;
            this.btnCuenta.IconMarginRight = 0;
            this.btnCuenta.IconRightVisible = true;
            this.btnCuenta.IconRightZoom = 0D;
            this.btnCuenta.IconVisible = true;
            this.btnCuenta.IconZoom = 90D;
            this.btnCuenta.IsTab = false;
            this.btnCuenta.Location = new System.Drawing.Point(155, 73);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(105)))));
            this.btnCuenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCuenta.selected = false;
            this.btnCuenta.Size = new System.Drawing.Size(123, 48);
            this.btnCuenta.TabIndex = 39;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.Textcolor = System.Drawing.Color.White;
            this.btnCuenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.BotFormulario);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de pedidos";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarFormulario)).EndInit();
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            this.BotFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CerrarFormulario;
        private System.Windows.Forms.PictureBox RestaurarFormulario;
        private System.Windows.Forms.PictureBox MinimizarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnPedido;
        private System.Windows.Forms.Panel BotFormulario;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnCuenta;
    }
}

