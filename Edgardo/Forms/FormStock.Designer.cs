namespace Edgardo.Forms
{
    partial class FormStock
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
            this.panelDGV = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.textboxNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.textboxId = new RJCodeAdvance.RJControls.RJTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textboxPrecio = new RJCodeAdvance.RJControls.RJTextBox();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDGV
            // 
            this.panelDGV.BackColor = System.Drawing.Color.GhostWhite;
            this.panelDGV.Controls.Add(this.dgvProducts);
            this.panelDGV.Location = new System.Drawing.Point(7, 31);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(535, 418);
            this.panelDGV.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(535, 418);
            this.dgvProducts.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.GhostWhite;
            this.panelButtons.Controls.Add(this.textboxPrecio);
            this.panelButtons.Controls.Add(this.btnRemove);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.textboxNombre);
            this.panelButtons.Controls.Add(this.textboxId);
            this.panelButtons.Location = new System.Drawing.Point(553, 31);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(219, 418);
            this.panelButtons.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemove.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 32;
            this.btnRemove.Location = new System.Drawing.Point(111, 120);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(4, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(4, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir Producto";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textboxNombre
            // 
            this.textboxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textboxNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxNombre.BorderRadius = 0;
            this.textboxNombre.BorderSize = 2;
            this.textboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxNombre.Location = new System.Drawing.Point(4, 43);
            this.textboxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNombre.Multiline = false;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxNombre.PasswordChar = false;
            this.textboxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxNombre.PlaceholderText = "";
            this.textboxNombre.Size = new System.Drawing.Size(211, 31);
            this.textboxNombre.TabIndex = 2;
            this.textboxNombre.Texts = "Nombre";
            this.textboxNombre.UnderlinedStyle = false;
            // 
            // textboxId
            // 
            this.textboxId.BackColor = System.Drawing.SystemColors.Window;
            this.textboxId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxId.BorderRadius = 0;
            this.textboxId.BorderSize = 2;
            this.textboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxId.Location = new System.Drawing.Point(4, 4);
            this.textboxId.Margin = new System.Windows.Forms.Padding(4);
            this.textboxId.Multiline = false;
            this.textboxId.Name = "textboxId";
            this.textboxId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxId.PasswordChar = false;
            this.textboxId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxId.PlaceholderText = "";
            this.textboxId.Size = new System.Drawing.Size(211, 31);
            this.textboxId.TabIndex = 1;
            this.textboxId.Texts = "Id";
            this.textboxId.UnderlinedStyle = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(103, 16);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Panel de Stock";
            // 
            // textboxPrecio
            // 
            this.textboxPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPrecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxPrecio.BorderRadius = 0;
            this.textboxPrecio.BorderSize = 2;
            this.textboxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPrecio.Location = new System.Drawing.Point(4, 82);
            this.textboxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPrecio.Multiline = false;
            this.textboxPrecio.Name = "textboxPrecio";
            this.textboxPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxPrecio.PasswordChar = false;
            this.textboxPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxPrecio.PlaceholderText = "";
            this.textboxPrecio.Size = new System.Drawing.Size(211, 31);
            this.textboxPrecio.TabIndex = 6;
            this.textboxPrecio.Texts = "Precio";
            this.textboxPrecio.UnderlinedStyle = false;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridView dgvProducts;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnEdit;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private RJCodeAdvance.RJControls.RJTextBox textboxNombre;
        private RJCodeAdvance.RJControls.RJTextBox textboxId;
        private System.Windows.Forms.Label labelTitle;
        private RJCodeAdvance.RJControls.RJTextBox textboxPrecio;
    }
}