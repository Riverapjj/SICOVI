namespace SICOVI
{
    partial class formControles
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
            this.dgvControles = new System.Windows.Forms.DataGridView();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvControles
            // 
            this.dgvControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControles.Location = new System.Drawing.Point(29, 277);
            this.dgvControles.Name = "dgvControles";
            this.dgvControles.Size = new System.Drawing.Size(994, 291);
            this.dgvControles.TabIndex = 0;
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPacientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(29, 161);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(436, 21);
            this.cmbPacientes.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(214, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Filtrar por nombre de paciente:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "BITÁCORA DE CONTROLES DE VACUNA";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Depth = 0;
            this.btnFiltrar.Location = new System.Drawing.Point(29, 201);
            this.btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Primary = true;
            this.btnFiltrar.Size = new System.Drawing.Size(133, 31);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // formControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 594);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbPacientes);
            this.Controls.Add(this.dgvControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formControles";
            this.Text = "formControles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControles;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnFiltrar;
    }
}