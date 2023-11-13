
namespace EjemploAyuda
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImportarCSV = new System.Windows.Forms.Button();
            this.btnMostrarRegistro = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoToolStripMenuItem
            // 
            this.comoToolStripMenuItem.Name = "comoToolStripMenuItem";
            this.comoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.comoToolStripMenuItem.Text = "Como";
            this.comoToolStripMenuItem.Click += new System.EventHandler(this.comoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Imagen});
            this.dgvPersonas.Location = new System.Drawing.Point(12, 27);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(328, 285);
            this.dgvPersonas.TabIndex = 2;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Apellido, Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Imagen
            // 
            this.Imagen.FillWeight = 50F;
            this.Imagen.HeaderText = "Foto";
            this.Imagen.MinimumWidth = 50;
            this.Imagen.Name = "Imagen";
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 50;
            // 
            // btnImportarCSV
            // 
            this.btnImportarCSV.Location = new System.Drawing.Point(346, 27);
            this.btnImportarCSV.Name = "btnImportarCSV";
            this.btnImportarCSV.Size = new System.Drawing.Size(88, 49);
            this.btnImportarCSV.TabIndex = 3;
            this.btnImportarCSV.Text = "Importar Archivo CSV";
            this.btnImportarCSV.UseVisualStyleBackColor = true;
            this.btnImportarCSV.Click += new System.EventHandler(this.btnImportarCSV_Click);
            // 
            // btnMostrarRegistro
            // 
            this.btnMostrarRegistro.Location = new System.Drawing.Point(346, 82);
            this.btnMostrarRegistro.Name = "btnMostrarRegistro";
            this.btnMostrarRegistro.Size = new System.Drawing.Size(88, 45);
            this.btnMostrarRegistro.TabIndex = 4;
            this.btnMostrarRegistro.Text = "Mostrar Selección";
            this.btnMostrarRegistro.UseVisualStyleBackColor = true;
            this.btnMostrarRegistro.Click += new System.EventHandler(this.btnMostrarRegistro_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 317);
            this.Controls.Add(this.btnMostrarRegistro);
            this.Controls.Add(this.btnImportarCSV);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnImportarCSV;
        private System.Windows.Forms.Button btnMostrarRegistro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}

