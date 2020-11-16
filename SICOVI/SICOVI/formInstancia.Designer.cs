namespace SICOVI
{
    partial class formInstancia
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
            this.lblInstancia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblInstancia
            // 
            this.lblInstancia.Depth = 0;
            this.lblInstancia.Hint = "Nombre de su instancia SQL Server";
            this.lblInstancia.Location = new System.Drawing.Point(34, 35);
            this.lblInstancia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.PasswordChar = '\0';
            this.lblInstancia.SelectedText = "";
            this.lblInstancia.SelectionLength = 0;
            this.lblInstancia.SelectionStart = 0;
            this.lblInstancia.Size = new System.Drawing.Size(271, 23);
            this.lblInstancia.TabIndex = 0;
            this.lblInstancia.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(89, 96);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(150, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // formInstancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 148);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblInstancia);
            this.Name = "formInstancia";
            this.Text = "formInstancia";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lblInstancia;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
    }
}