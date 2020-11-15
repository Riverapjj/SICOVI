namespace SICOVI
{
    partial class formPacienteVacuna
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVacunas = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
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
            this.iconButton1.Location = new System.Drawing.Point(131, 86);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(44, 19);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Hint = "Nombre de paciente";
            this.txtNombre.Location = new System.Drawing.Point(181, 86);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "VACUNAS";
            // 
            // cmbVacunas
            // 
            this.cmbVacunas.FormattingEnabled = true;
            this.cmbVacunas.Location = new System.Drawing.Point(181, 144);
            this.cmbVacunas.Name = "cmbVacunas";
            this.cmbVacunas.Size = new System.Drawing.Size(213, 21);
            this.cmbVacunas.TabIndex = 24;
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(131, 146);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(44, 19);
            this.iconButton2.TabIndex = 25;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(25, 306);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(162, 29);
            this.iconButton3.TabIndex = 26;
            this.iconButton3.Text = "ACEPTAR";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Gray;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.iconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(379, 306);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(162, 29);
            this.iconButton4.TabIndex = 27;
            this.iconButton4.Text = "CANCELAR";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Enabled = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(25, 213);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(44, 19);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.Hint = "Observaciones";
            this.txtObservaciones.Location = new System.Drawing.Point(79, 213);
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.Size = new System.Drawing.Size(440, 23);
            this.txtObservaciones.TabIndex = 30;
            this.txtObservaciones.UseSystemPasswordChar = false;
            // 
            // formPacienteVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(564, 344);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.cmbVacunas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPacienteVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPacienteVacuna";
            this.Load += new System.EventHandler(this.formPacienteVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVacunas;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservaciones;
    }
}