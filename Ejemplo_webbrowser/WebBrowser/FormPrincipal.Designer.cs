namespace WebBrowser
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnVerHTML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(704, 15);
            this.btnGenerarListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(80, 84);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(16, 15);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(680, 277);
            this.dgvPersonas.TabIndex = 1;
            // 
            // btnVerHTML
            // 
            this.btnVerHTML.Location = new System.Drawing.Point(704, 199);
            this.btnVerHTML.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerHTML.Name = "btnVerHTML";
            this.btnVerHTML.Size = new System.Drawing.Size(80, 93);
            this.btnVerHTML.TabIndex = 2;
            this.btnVerHTML.Text = "Actualizar y Ver  listado web";
            this.btnVerHTML.UseVisualStyleBackColor = true;
            this.btnVerHTML.Click += new System.EventHandler(this.btnVerHTML_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 300);
            this.Controls.Add(this.btnVerHTML);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnGenerarListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo Informe Web - WebBrowser";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnVerHTML;
    }
}

