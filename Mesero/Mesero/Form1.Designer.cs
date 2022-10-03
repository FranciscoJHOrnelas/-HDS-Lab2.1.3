namespace Mesero
{
    partial class Form1
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
            this.lblMesero = new System.Windows.Forms.Label();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.txbEspecificacion = new System.Windows.Forms.TextBox();
            this.btnConfirmarOrden = new System.Windows.Forms.Button();
            this.lblOrdenes = new System.Windows.Forms.Label();
            this.pbxSoda = new System.Windows.Forms.PictureBox();
            this.pbxTacos = new System.Windows.Forms.PictureBox();
            this.pbxChilaquiles = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblChilaquiles = new System.Windows.Forms.Label();
            this.lblTacos = new System.Windows.Forms.Label();
            this.lblSoda = new System.Windows.Forms.Label();
            this.lblPrecioSoda = new System.Windows.Forms.Label();
            this.lblPrecioTacos = new System.Windows.Forms.Label();
            this.lblPrecioChilaquiles = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTacos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChilaquiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesero.Location = new System.Drawing.Point(52, 20);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(305, 91);
            this.lblMesero.TabIndex = 1;
            this.lblMesero.Text = "Mesero";
            this.lblMesero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(118, 152);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(174, 32);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Mesa No: 12";
            this.lblNumMesa.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(327, 152);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(150, 32);
            this.lblClientes.TabIndex = 3;
            this.lblClientes.Text = "Clientes: 4";
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificacion.Location = new System.Drawing.Point(119, 226);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(384, 29);
            this.lblEspecificacion.TabIndex = 4;
            this.lblEspecificacion.Text = "Ingresar especificación del cliente:";
            // 
            // txbEspecificacion
            // 
            this.txbEspecificacion.ForeColor = System.Drawing.Color.DarkGray;
            this.txbEspecificacion.Location = new System.Drawing.Point(121, 268);
            this.txbEspecificacion.Name = "txbEspecificacion";
            this.txbEspecificacion.Size = new System.Drawing.Size(381, 22);
            this.txbEspecificacion.TabIndex = 5;
            this.txbEspecificacion.Text = "Ingresar Especificación";
            this.txbEspecificacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbEspecificacion_MouseClick);
            this.txbEspecificacion.TextChanged += new System.EventHandler(this.txbEspecificacion_TextChanged);
            // 
            // btnConfirmarOrden
            // 
            this.btnConfirmarOrden.BackColor = System.Drawing.Color.Black;
            this.btnConfirmarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarOrden.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarOrden.Location = new System.Drawing.Point(227, 353);
            this.btnConfirmarOrden.Name = "btnConfirmarOrden";
            this.btnConfirmarOrden.Size = new System.Drawing.Size(176, 51);
            this.btnConfirmarOrden.TabIndex = 6;
            this.btnConfirmarOrden.Text = "CONFIRMAR ORDEN";
            this.btnConfirmarOrden.UseVisualStyleBackColor = false;
            this.btnConfirmarOrden.Visible = false;
            // 
            // lblOrdenes
            // 
            this.lblOrdenes.AutoSize = true;
            this.lblOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenes.Location = new System.Drawing.Point(539, 79);
            this.lblOrdenes.Name = "lblOrdenes";
            this.lblOrdenes.Size = new System.Drawing.Size(166, 44);
            this.lblOrdenes.TabIndex = 7;
            this.lblOrdenes.Text = "Ordenes";
            // 
            // pbxSoda
            // 
            this.pbxSoda.BackgroundImage = global::Mesero.Properties.Resources.Cold_Soda_PNG_Image;
            this.pbxSoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSoda.Location = new System.Drawing.Point(547, 436);
            this.pbxSoda.Name = "pbxSoda";
            this.pbxSoda.Size = new System.Drawing.Size(160, 120);
            this.pbxSoda.TabIndex = 10;
            this.pbxSoda.TabStop = false;
            // 
            // pbxTacos
            // 
            this.pbxTacos.BackgroundImage = global::Mesero.Properties.Resources.xd;
            this.pbxTacos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTacos.Location = new System.Drawing.Point(547, 282);
            this.pbxTacos.Name = "pbxTacos";
            this.pbxTacos.Size = new System.Drawing.Size(160, 120);
            this.pbxTacos.TabIndex = 9;
            this.pbxTacos.TabStop = false;
            // 
            // pbxChilaquiles
            // 
            this.pbxChilaquiles.BackgroundImage = global::Mesero.Properties.Resources.ChillVerdes;
            this.pbxChilaquiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxChilaquiles.Location = new System.Drawing.Point(547, 132);
            this.pbxChilaquiles.Name = "pbxChilaquiles";
            this.pbxChilaquiles.Size = new System.Drawing.Size(160, 120);
            this.pbxChilaquiles.TabIndex = 8;
            this.pbxChilaquiles.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BackgroundImage = global::Mesero.Properties.Resources._10462_house_building;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(69, 556);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(117, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblChilaquiles
            // 
            this.lblChilaquiles.AutoSize = true;
            this.lblChilaquiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChilaquiles.Location = new System.Drawing.Point(754, 177);
            this.lblChilaquiles.Name = "lblChilaquiles";
            this.lblChilaquiles.Size = new System.Drawing.Size(180, 32);
            this.lblChilaquiles.TabIndex = 11;
            this.lblChilaquiles.Text = "Chilaquiles 1";
            this.lblChilaquiles.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblTacos
            // 
            this.lblTacos.AutoSize = true;
            this.lblTacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacos.Location = new System.Drawing.Point(754, 329);
            this.lblTacos.Name = "lblTacos";
            this.lblTacos.Size = new System.Drawing.Size(115, 32);
            this.lblTacos.TabIndex = 12;
            this.lblTacos.Text = "Tacos 1";
            // 
            // lblSoda
            // 
            this.lblSoda.AutoSize = true;
            this.lblSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoda.Location = new System.Drawing.Point(754, 481);
            this.lblSoda.Name = "lblSoda";
            this.lblSoda.Size = new System.Drawing.Size(105, 32);
            this.lblSoda.TabIndex = 13;
            this.lblSoda.Text = "Soda 1";
            // 
            // lblPrecioSoda
            // 
            this.lblPrecioSoda.AutoSize = true;
            this.lblPrecioSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSoda.Location = new System.Drawing.Point(993, 479);
            this.lblPrecioSoda.Name = "lblPrecioSoda";
            this.lblPrecioSoda.Size = new System.Drawing.Size(172, 32);
            this.lblPrecioSoda.TabIndex = 16;
            this.lblPrecioSoda.Text = "$35.00 MXN";
            this.lblPrecioSoda.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblPrecioTacos
            // 
            this.lblPrecioTacos.AutoSize = true;
            this.lblPrecioTacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTacos.Location = new System.Drawing.Point(993, 327);
            this.lblPrecioTacos.Name = "lblPrecioTacos";
            this.lblPrecioTacos.Size = new System.Drawing.Size(172, 32);
            this.lblPrecioTacos.TabIndex = 15;
            this.lblPrecioTacos.Text = "$25.00 MXN";
            this.lblPrecioTacos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrecioChilaquiles
            // 
            this.lblPrecioChilaquiles.AutoSize = true;
            this.lblPrecioChilaquiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioChilaquiles.Location = new System.Drawing.Point(993, 175);
            this.lblPrecioChilaquiles.Name = "lblPrecioChilaquiles";
            this.lblPrecioChilaquiles.Size = new System.Drawing.Size(172, 32);
            this.lblPrecioChilaquiles.TabIndex = 14;
            this.lblPrecioChilaquiles.Text = "$55.00 MXN";
            this.lblPrecioChilaquiles.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(512, 585);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(174, 32);
            this.lblMesa.TabIndex = 17;
            this.lblMesa.Text = "Mesa No. 12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 645);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblPrecioSoda);
            this.Controls.Add(this.lblPrecioTacos);
            this.Controls.Add(this.lblPrecioChilaquiles);
            this.Controls.Add(this.lblSoda);
            this.Controls.Add(this.lblTacos);
            this.Controls.Add(this.lblChilaquiles);
            this.Controls.Add(this.pbxSoda);
            this.Controls.Add(this.pbxTacos);
            this.Controls.Add(this.pbxChilaquiles);
            this.Controls.Add(this.lblOrdenes);
            this.Controls.Add(this.btnConfirmarOrden);
            this.Controls.Add(this.txbEspecificacion);
            this.Controls.Add(this.lblEspecificacion);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.btnHome);
            this.Name = "Form1";
            this.Text = "Mesero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTacos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChilaquiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblMesero;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.TextBox txbEspecificacion;
        private System.Windows.Forms.Button btnConfirmarOrden;
        private System.Windows.Forms.Label lblOrdenes;
        private System.Windows.Forms.PictureBox pbxChilaquiles;
        private System.Windows.Forms.PictureBox pbxTacos;
        private System.Windows.Forms.PictureBox pbxSoda;
        private System.Windows.Forms.Label lblChilaquiles;
        private System.Windows.Forms.Label lblTacos;
        private System.Windows.Forms.Label lblSoda;
        private System.Windows.Forms.Label lblPrecioSoda;
        private System.Windows.Forms.Label lblPrecioTacos;
        private System.Windows.Forms.Label lblPrecioChilaquiles;
        private System.Windows.Forms.Label lblMesa;
    }
}

