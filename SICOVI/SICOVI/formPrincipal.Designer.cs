namespace SICOVI
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelSubMenuUsuario = new System.Windows.Forms.Panel();
            this.btnRecepcionista = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDoctor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdmin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVacuna = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPaciente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnControles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubMenuUsuario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(189)))), ((int)(((byte)(154)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelSubMenuUsuario);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.btnVacuna);
            this.panelMenu.Controls.Add(this.btnPaciente);
            this.panelMenu.Controls.Add(this.btnControles);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 644);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(190, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // panelSubMenuUsuario
            // 
            this.panelSubMenuUsuario.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSubMenuUsuario.Controls.Add(this.btnRecepcionista);
            this.panelSubMenuUsuario.Controls.Add(this.btnDoctor);
            this.panelSubMenuUsuario.Controls.Add(this.btnAdmin);
            this.panelSubMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuUsuario.Location = new System.Drawing.Point(0, 235);
            this.panelSubMenuUsuario.Name = "panelSubMenuUsuario";
            this.panelSubMenuUsuario.Size = new System.Drawing.Size(190, 108);
            this.panelSubMenuUsuario.TabIndex = 2;
            // 
            // btnRecepcionista
            // 
            this.btnRecepcionista.AutoSize = true;
            this.btnRecepcionista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecepcionista.Depth = 0;
            this.btnRecepcionista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecepcionista.Location = new System.Drawing.Point(0, 72);
            this.btnRecepcionista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecepcionista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecepcionista.Name = "btnRecepcionista";
            this.btnRecepcionista.Primary = false;
            this.btnRecepcionista.Size = new System.Drawing.Size(190, 36);
            this.btnRecepcionista.TabIndex = 5;
            this.btnRecepcionista.Text = "Recepcionistas";
            this.btnRecepcionista.UseVisualStyleBackColor = true;
            this.btnRecepcionista.Click += new System.EventHandler(this.btnRecepcionista_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.AutoSize = true;
            this.btnDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDoctor.Depth = 0;
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctor.Location = new System.Drawing.Point(0, 36);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Primary = false;
            this.btnDoctor.Size = new System.Drawing.Size(190, 36);
            this.btnDoctor.TabIndex = 4;
            this.btnDoctor.Text = "Doctores";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Primary = false;
            this.btnAdmin.Size = new System.Drawing.Size(190, 36);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Administradores";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Depth = 0;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(0, 190);
            this.btnUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Primary = true;
            this.btnUsuario.Size = new System.Drawing.Size(190, 45);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnVacuna
            // 
            this.btnVacuna.Depth = 0;
            this.btnVacuna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacuna.Location = new System.Drawing.Point(0, 145);
            this.btnVacuna.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVacuna.Name = "btnVacuna";
            this.btnVacuna.Primary = true;
            this.btnVacuna.Size = new System.Drawing.Size(190, 45);
            this.btnVacuna.TabIndex = 3;
            this.btnVacuna.Text = "Vacunas";
            this.btnVacuna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacuna.UseVisualStyleBackColor = true;
            this.btnVacuna.Click += new System.EventHandler(this.btnVacuna_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Depth = 0;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Location = new System.Drawing.Point(0, 100);
            this.btnPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Primary = true;
            this.btnPaciente.Size = new System.Drawing.Size(190, 45);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnControles
            // 
            this.btnControles.Depth = 0;
            this.btnControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControles.Location = new System.Drawing.Point(0, 55);
            this.btnControles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnControles.Name = "btnControles";
            this.btnControles.Primary = true;
            this.btnControles.Size = new System.Drawing.Size(190, 45);
            this.btnControles.TabIndex = 1;
            this.btnControles.Text = "Controles";
            this.btnControles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControles.UseVisualStyleBackColor = true;
            this.btnControles.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.Controls.Add(this.materialLabel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(190, 55);
            this.panelLogo.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(53, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "S I C O V I";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(190, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 50);
            this.panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(190, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1048, 594);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 644);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1254, 682);
            this.Name = "formPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S I C O V I";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubMenuUsuario.ResumeLayout(false);
            this.panelSubMenuUsuario.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnControles;
        private System.Windows.Forms.Panel panelSubMenuUsuario;
        private MaterialSkin.Controls.MaterialFlatButton btnRecepcionista;
        private MaterialSkin.Controls.MaterialFlatButton btnDoctor;
        private MaterialSkin.Controls.MaterialFlatButton btnAdmin;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnVacuna;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaciente;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

