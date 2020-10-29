namespace SICOVI
{
    partial class formPacientes
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
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtNomPaciente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtNomPadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtISSS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.txtDUI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.txtNomRespon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(26, 260);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(977, 264);
            this.dgvPacientes.TabIndex = 1;
            // 
            // txtNomPaciente
            // 
            this.txtNomPaciente.Depth = 0;
            this.txtNomPaciente.Hint = "Nombre de paciente";
            this.txtNomPaciente.Location = new System.Drawing.Point(73, 94);
            this.txtNomPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomPaciente.Name = "txtNomPaciente";
            this.txtNomPaciente.PasswordChar = '\0';
            this.txtNomPaciente.SelectedText = "";
            this.txtNomPaciente.SelectionLength = 0;
            this.txtNomPaciente.SelectionStart = 0;
            this.txtNomPaciente.Size = new System.Drawing.Size(213, 23);
            this.txtNomPaciente.TabIndex = 7;
            this.txtNomPaciente.UseSystemPasswordChar = false;
            this.txtNomPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNombre_KeyPress);
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
            this.iconButton1.Location = new System.Drawing.Point(25, 94);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(44, 19);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(25, 150);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(44, 19);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // txtNomPadre
            // 
            this.txtNomPadre.Depth = 0;
            this.txtNomPadre.Hint = "Nombre del padre";
            this.txtNomPadre.Location = new System.Drawing.Point(73, 150);
            this.txtNomPadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomPadre.Name = "txtNomPadre";
            this.txtNomPadre.PasswordChar = '\0';
            this.txtNomPadre.SelectedText = "";
            this.txtNomPadre.SelectionLength = 0;
            this.txtNomPadre.SelectionStart = 0;
            this.txtNomPadre.Size = new System.Drawing.Size(213, 23);
            this.txtNomPadre.TabIndex = 10;
            this.txtNomPadre.UseSystemPasswordChar = false;
            this.txtNomPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPadre_KeyPress);
            // 
            // txtNomMadre
            // 
            this.txtNomMadre.Depth = 0;
            this.txtNomMadre.Hint = "Nombre de la madre";
            this.txtNomMadre.Location = new System.Drawing.Point(73, 207);
            this.txtNomMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomMadre.Name = "txtNomMadre";
            this.txtNomMadre.PasswordChar = '\0';
            this.txtNomMadre.SelectedText = "";
            this.txtNomMadre.SelectionLength = 0;
            this.txtNomMadre.SelectionStart = 0;
            this.txtNomMadre.Size = new System.Drawing.Size(213, 23);
            this.txtNomMadre.TabIndex = 12;
            this.txtNomMadre.UseSystemPasswordChar = false;
            this.txtNomMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomMadre_KeyPress);
            // 
            // iconButton3
            // 
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Female;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(25, 207);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(44, 19);
            this.iconButton3.TabIndex = 13;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Enabled = false;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(381, 150);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(32, 19);
            this.iconButton4.TabIndex = 15;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // txtISSS
            // 
            this.txtISSS.Depth = 0;
            this.txtISSS.Hint = "N° ISSS del responsable";
            this.txtISSS.Location = new System.Drawing.Point(431, 150);
            this.txtISSS.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.PasswordChar = '\0';
            this.txtISSS.SelectedText = "";
            this.txtISSS.SelectionLength = 0;
            this.txtISSS.SelectionStart = 0;
            this.txtISSS.Size = new System.Drawing.Size(213, 23);
            this.txtISSS.TabIndex = 14;
            this.txtISSS.UseSystemPasswordChar = false;
            this.txtISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
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
            this.iconButton5.Location = new System.Drawing.Point(381, 206);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(32, 19);
            this.iconButton5.TabIndex = 17;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // txtDUI
            // 
            this.txtDUI.Depth = 0;
            this.txtDUI.Hint = "DUI del responsable";
            this.txtDUI.Location = new System.Drawing.Point(431, 206);
            this.txtDUI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.PasswordChar = '\0';
            this.txtDUI.SelectedText = "";
            this.txtDUI.SelectionLength = 0;
            this.txtDUI.SelectionStart = 0;
            this.txtDUI.Size = new System.Drawing.Size(213, 23);
            this.txtDUI.TabIndex = 16;
            this.txtDUI.UseSystemPasswordChar = false;
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
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
            this.btnAgregar.Location = new System.Drawing.Point(854, 207);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(40, 35);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(910, 207);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Rotation = 0D;
            this.btnModificar.Size = new System.Drawing.Size(40, 35);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "PACIENTES";
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
            this.btnLimpiar.Location = new System.Drawing.Point(798, 207);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Rotation = 0D;
            this.btnLimpiar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton6.BackColor = System.Drawing.Color.Orange;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconSize = 25;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(963, 207);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(40, 35);
            this.iconButton6.TabIndex = 23;
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // iconButton7
            // 
            this.iconButton7.Enabled = false;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconSize = 25;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(383, 90);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(44, 19);
            this.iconButton7.TabIndex = 25;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // txtNomRespon
            // 
            this.txtNomRespon.Depth = 0;
            this.txtNomRespon.Hint = "Nombre del responsable";
            this.txtNomRespon.Location = new System.Drawing.Point(431, 90);
            this.txtNomRespon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomRespon.Name = "txtNomRespon";
            this.txtNomRespon.PasswordChar = '\0';
            this.txtNomRespon.SelectedText = "";
            this.txtNomRespon.SelectionLength = 0;
            this.txtNomRespon.SelectionStart = 0;
            this.txtNomRespon.Size = new System.Drawing.Size(213, 23);
            this.txtNomRespon.TabIndex = 24;
            this.txtNomRespon.UseSystemPasswordChar = false;
            this.txtNomRespon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomRespon_KeyPress);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(790, 87);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaNac.TabIndex = 26;
            // 
            // iconButton8
            // 
            this.iconButton8.Enabled = false;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconSize = 25;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(740, 87);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Rotation = 0D;
            this.iconButton8.Size = new System.Drawing.Size(44, 19);
            this.iconButton8.TabIndex = 27;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // formPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 556);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.txtNomRespon);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.txtNomMadre);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtNomPadre);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtNomPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPacientes";
            this.Text = "formPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomPaciente;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomPadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomMadre;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtISSS;
        private FontAwesome.Sharp.IconButton iconButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDUI;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomRespon;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
    }
}