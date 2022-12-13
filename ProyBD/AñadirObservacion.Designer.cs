
namespace ProyBD
{
    partial class AñadirObservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirObservacion));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstadoBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtIDAuto = new System.Windows.Forms.TextBox();
            this.lbliDauto = new System.Windows.Forms.Label();
            this.gbxModificarA = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbxModificarA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstadoBusqueda);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtIDAuto);
            this.groupBox2.Controls.Add(this.lbliDauto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Auto";
            // 
            // lblEstadoBusqueda
            // 
            this.lblEstadoBusqueda.AutoSize = true;
            this.lblEstadoBusqueda.Location = new System.Drawing.Point(166, 74);
            this.lblEstadoBusqueda.Name = "lblEstadoBusqueda";
            this.lblEstadoBusqueda.Size = new System.Drawing.Size(57, 16);
            this.lblEstadoBusqueda.TabIndex = 5;
            this.lblEstadoBusqueda.Text = "Estado";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(43, 71);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // txtIDAuto
            // 
            this.txtIDAuto.Location = new System.Drawing.Point(101, 31);
            this.txtIDAuto.Name = "txtIDAuto";
            this.txtIDAuto.Size = new System.Drawing.Size(271, 22);
            this.txtIDAuto.TabIndex = 1;
            // 
            // lbliDauto
            // 
            this.lbliDauto.AutoSize = true;
            this.lbliDauto.Location = new System.Drawing.Point(19, 34);
            this.lbliDauto.Name = "lbliDauto";
            this.lbliDauto.Size = new System.Drawing.Size(58, 16);
            this.lbliDauto.TabIndex = 0;
            this.lbliDauto.Text = "ID Auto";
            // 
            // gbxModificarA
            // 
            this.gbxModificarA.Controls.Add(this.txtObservacion);
            this.gbxModificarA.Controls.Add(this.btnAñadir);
            this.gbxModificarA.Controls.Add(this.lblObservacion);
            this.gbxModificarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxModificarA.Location = new System.Drawing.Point(13, 129);
            this.gbxModificarA.Name = "gbxModificarA";
            this.gbxModificarA.Size = new System.Drawing.Size(410, 219);
            this.gbxModificarA.TabIndex = 6;
            this.gbxModificarA.TabStop = false;
            this.gbxModificarA.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(26, 65);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(362, 94);
            this.txtObservacion.TabIndex = 10;
            this.txtObservacion.Text = "";
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(142, 174);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(114, 30);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click_1);
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(24, 37);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(183, 16);
            this.lblObservacion.TabIndex = 0;
            this.lblObservacion.Text = "Introducir nueva observacion:";
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(155, 363);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(114, 30);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // AñadirObservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 405);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gbxModificarA);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AñadirObservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirObservacion";
            this.Load += new System.EventHandler(this.AñadirObservacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxModificarA.ResumeLayout(false);
            this.gbxModificarA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEstadoBusqueda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtIDAuto;
        private System.Windows.Forms.Label lbliDauto;
        private System.Windows.Forms.GroupBox gbxModificarA;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnAtras;
    }
}