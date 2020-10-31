namespace SICOVI
{
    partial class formRangos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBitacora = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkPacientes = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkUsuarios = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkVacunas = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkRangos = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "GESTIÓN DE RANGOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 470);
            this.dataGridView1.TabIndex = 6;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(92, 160);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(257, 23);
            this.materialSingleLineTextField1.TabIndex = 7;
            this.materialSingleLineTextField1.Text = "Nombre de rango";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            this.iconButton1.Location = new System.Drawing.Point(42, 160);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(44, 19);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(60, 229);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(250, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Seleccione formularios disponibles:";
            // 
            // checkBitacora
            // 
            this.checkBitacora.AutoSize = true;
            this.checkBitacora.Depth = 0;
            this.checkBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBitacora.Location = new System.Drawing.Point(64, 271);
            this.checkBitacora.Margin = new System.Windows.Forms.Padding(0);
            this.checkBitacora.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBitacora.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBitacora.Name = "checkBitacora";
            this.checkBitacora.Ripple = true;
            this.checkBitacora.Size = new System.Drawing.Size(161, 30);
            this.checkBitacora.TabIndex = 14;
            this.checkBitacora.Text = "Bitácora de controles";
            this.checkBitacora.UseVisualStyleBackColor = true;
            // 
            // checkPacientes
            // 
            this.checkPacientes.AutoSize = true;
            this.checkPacientes.Depth = 0;
            this.checkPacientes.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkPacientes.Location = new System.Drawing.Point(64, 310);
            this.checkPacientes.Margin = new System.Windows.Forms.Padding(0);
            this.checkPacientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPacientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPacientes.Name = "checkPacientes";
            this.checkPacientes.Ripple = true;
            this.checkPacientes.Size = new System.Drawing.Size(91, 30);
            this.checkPacientes.TabIndex = 15;
            this.checkPacientes.Text = "Pacientes";
            this.checkPacientes.UseVisualStyleBackColor = true;
            // 
            // checkUsuarios
            // 
            this.checkUsuarios.AutoSize = true;
            this.checkUsuarios.Depth = 0;
            this.checkUsuarios.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkUsuarios.Location = new System.Drawing.Point(64, 349);
            this.checkUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.checkUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkUsuarios.Name = "checkUsuarios";
            this.checkUsuarios.Ripple = true;
            this.checkUsuarios.Size = new System.Drawing.Size(84, 30);
            this.checkUsuarios.TabIndex = 16;
            this.checkUsuarios.Text = "Usuarios";
            this.checkUsuarios.UseVisualStyleBackColor = true;
            // 
            // checkVacunas
            // 
            this.checkVacunas.AutoSize = true;
            this.checkVacunas.Depth = 0;
            this.checkVacunas.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkVacunas.Location = new System.Drawing.Point(64, 390);
            this.checkVacunas.Margin = new System.Windows.Forms.Padding(0);
            this.checkVacunas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkVacunas.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkVacunas.Name = "checkVacunas";
            this.checkVacunas.Ripple = true;
            this.checkVacunas.Size = new System.Drawing.Size(83, 30);
            this.checkVacunas.TabIndex = 17;
            this.checkVacunas.Text = "Vacunas";
            this.checkVacunas.UseVisualStyleBackColor = true;
            // 
            // checkRangos
            // 
            this.checkRangos.AutoSize = true;
            this.checkRangos.Depth = 0;
            this.checkRangos.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkRangos.Location = new System.Drawing.Point(64, 429);
            this.checkRangos.Margin = new System.Windows.Forms.Padding(0);
            this.checkRangos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRangos.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRangos.Name = "checkRangos";
            this.checkRangos.Ripple = true;
            this.checkRangos.Size = new System.Drawing.Size(76, 30);
            this.checkRangos.TabIndex = 18;
            this.checkRangos.Text = "Rangos";
            this.checkRangos.UseVisualStyleBackColor = true;
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
            this.btnLimpiar.Location = new System.Drawing.Point(59, 490);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Rotation = 0D;
            this.btnLimpiar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconSize = 25;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(171, 490);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Rotation = 0D;
            this.btnModificar.Size = new System.Drawing.Size(40, 35);
            this.btnModificar.TabIndex = 31;
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
            this.btnAgregar.Location = new System.Drawing.Point(115, 490);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(40, 35);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // formRangos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 556);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.checkRangos);
            this.Controls.Add(this.checkVacunas);
            this.Controls.Add(this.checkUsuarios);
            this.Controls.Add(this.checkPacientes);
            this.Controls.Add(this.checkBitacora);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRangos";
            this.Text = "formRangos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkBitacora;
        private MaterialSkin.Controls.MaterialCheckBox checkPacientes;
        private MaterialSkin.Controls.MaterialCheckBox checkUsuarios;
        private MaterialSkin.Controls.MaterialCheckBox checkVacunas;
        private MaterialSkin.Controls.MaterialCheckBox checkRangos;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}