namespace SICOVI
{
    partial class formAdmin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtRango = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtContra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.txtDUI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(27, 242);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(977, 264);
            this.dgvAdmin.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(852, 194);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Rotation = 0D;
            this.btnLimpiar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconSize = 25;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(964, 194);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Rotation = 0D;
            this.btnModificar.Size = new System.Drawing.Size(40, 35);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(908, 194);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(40, 35);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "ADMINISTRADORES";
            // 
            // iconButton1
            // 
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(29, 77);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(44, 19);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(375, 77);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(44, 19);
            this.iconButton2.TabIndex = 30;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // txtRango
            // 
            this.txtRango.Depth = 0;
            this.txtRango.Hint = "Rango";
            this.txtRango.Location = new System.Drawing.Point(423, 77);
            this.txtRango.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRango.Name = "txtRango";
            this.txtRango.PasswordChar = '\0';
            this.txtRango.SelectedText = "";
            this.txtRango.SelectionLength = 0;
            this.txtRango.SelectionStart = 0;
            this.txtRango.Size = new System.Drawing.Size(213, 23);
            this.txtRango.TabIndex = 29;
            this.txtRango.UseSystemPasswordChar = false;
            this.txtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(77, 136);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(213, 23);
            this.txtUsuario.TabIndex = 29;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // iconButton3
            // 
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(29, 136);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(44, 19);
            this.iconButton3.TabIndex = 30;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Enabled = false;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(29, 194);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(44, 19);
            this.iconButton4.TabIndex = 32;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // txtContra
            // 
            this.txtContra.Depth = 0;
            this.txtContra.Hint = "Contraseña";
            this.txtContra.Location = new System.Drawing.Point(77, 194);
            this.txtContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '\0';
            this.txtContra.SelectedText = "";
            this.txtContra.SelectionLength = 0;
            this.txtContra.SelectionStart = 0;
            this.txtContra.Size = new System.Drawing.Size(213, 23);
            this.txtContra.TabIndex = 31;
            this.txtContra.UseSystemPasswordChar = false;
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // iconButton5
            // 
            this.iconButton5.Enabled = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(375, 132);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(44, 19);
            this.iconButton5.TabIndex = 34;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // txtDUI
            // 
            this.txtDUI.Depth = 0;
            this.txtDUI.Hint = "DUI";
            this.txtDUI.Location = new System.Drawing.Point(423, 132);
            this.txtDUI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.PasswordChar = '\0';
            this.txtDUI.SelectedText = "";
            this.txtDUI.SelectionLength = 0;
            this.txtDUI.SelectionStart = 0;
            this.txtDUI.Size = new System.Drawing.Size(213, 23);
            this.txtDUI.TabIndex = 33;
            this.txtDUI.UseSystemPasswordChar = false;
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.Location = new System.Drawing.Point(423, 194);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(213, 23);
            this.txtTelefono.TabIndex = 35;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // iconButton7
            // 
            this.iconButton7.Enabled = false;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconSize = 25;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(743, 73);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(44, 19);
            this.iconButton7.TabIndex = 38;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(791, 73);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(213, 23);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // iconButton8
            // 
            this.iconButton8.Enabled = false;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.PhoneSquareAlt;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconSize = 25;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(375, 194);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Rotation = 0D;
            this.iconButton8.Size = new System.Drawing.Size(32, 19);
            this.iconButton8.TabIndex = 39;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(77, 77);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 518);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdmin";
            this.Text = "formAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRango;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContra;
        private FontAwesome.Sharp.IconButton iconButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDUI;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private FontAwesome.Sharp.IconButton iconButton7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private FontAwesome.Sharp.IconButton iconButton8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}