
namespace ProyBD
{
    partial class EliminarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCliente));
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.lblEstadoBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreC2 = new System.Windows.Forms.TextBox();
            this.lblnombreCliEL = new System.Windows.Forms.Label();
            this.txtIDcliente2 = new System.Windows.Forms.TextBox();
            this.lblNombreCEli = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.lblEstadoBusqueda);
            this.gbxBuscar.Controls.Add(this.btnBuscarCliente);
            this.gbxBuscar.Controls.Add(this.txtNombreC2);
            this.gbxBuscar.Controls.Add(this.lblnombreCliEL);
            this.gbxBuscar.Controls.Add(this.txtIDcliente2);
            this.gbxBuscar.Controls.Add(this.lblNombreCEli);
            this.gbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(409, 152);
            this.gbxBuscar.TabIndex = 3;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar Cliente";
            // 
            // lblEstadoBusqueda
            // 
            this.lblEstadoBusqueda.AutoSize = true;
            this.lblEstadoBusqueda.Location = new System.Drawing.Point(166, 114);
            this.lblEstadoBusqueda.Name = "lblEstadoBusqueda";
            this.lblEstadoBusqueda.Size = new System.Drawing.Size(0, 16);
            this.lblEstadoBusqueda.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(43, 111);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreC2
            // 
            this.txtNombreC2.Location = new System.Drawing.Point(101, 66);
            this.txtNombreC2.Name = "txtNombreC2";
            this.txtNombreC2.Size = new System.Drawing.Size(271, 22);
            this.txtNombreC2.TabIndex = 3;
            this.txtNombreC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreC2_KeyPress);
            // 
            // lblnombreCliEL
            // 
            this.lblnombreCliEL.AutoSize = true;
            this.lblnombreCliEL.Location = new System.Drawing.Point(19, 69);
            this.lblnombreCliEL.Name = "lblnombreCliEL";
            this.lblnombreCliEL.Size = new System.Drawing.Size(63, 16);
            this.lblnombreCliEL.TabIndex = 2;
            this.lblnombreCliEL.Text = "Nombre";
            // 
            // txtIDcliente2
            // 
            this.txtIDcliente2.Location = new System.Drawing.Point(101, 31);
            this.txtIDcliente2.Name = "txtIDcliente2";
            this.txtIDcliente2.Size = new System.Drawing.Size(271, 22);
            this.txtIDcliente2.TabIndex = 1;
            this.txtIDcliente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDcliente2_KeyPress);
            // 
            // lblNombreCEli
            // 
            this.lblNombreCEli.AutoSize = true;
            this.lblNombreCEli.Location = new System.Drawing.Point(19, 34);
            this.lblNombreCEli.Name = "lblNombreCEli";
            this.lblNombreCEli.Size = new System.Drawing.Size(75, 16);
            this.lblNombreCEli.TabIndex = 0;
            this.lblNombreCEli.Text = "ID Cliente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(93, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(243, 187);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 33);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 232);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbxBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Cliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.Label lblEstadoBusqueda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreC2;
        private System.Windows.Forms.Label lblnombreCliEL;
        private System.Windows.Forms.TextBox txtIDcliente2;
        private System.Windows.Forms.Label lblNombreCEli;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}