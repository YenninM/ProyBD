
namespace ProyBD
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAñadirclientes = new System.Windows.Forms.Button();
            this.btnEliminarcliente = new System.Windows.Forms.Button();
            this.btnModificarcliente = new System.Windows.Forms.Button();
            this.gpbxClientes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbxClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.Location = new System.Drawing.Point(22, 50);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(87, 27);
            this.btnVerClientes.TabIndex = 0;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.Location = new System.Drawing.Point(91, 228);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(133, 29);
            this.btnSalirClientes.TabIndex = 1;
            this.btnSalirClientes.Text = "Atras";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyBD.Properties.Resources.Clientes;
            this.pictureBox1.Location = new System.Drawing.Point(144, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAñadirclientes
            // 
            this.btnAñadirclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirclientes.Location = new System.Drawing.Point(22, 95);
            this.btnAñadirclientes.Name = "btnAñadirclientes";
            this.btnAñadirclientes.Size = new System.Drawing.Size(87, 27);
            this.btnAñadirclientes.TabIndex = 10;
            this.btnAñadirclientes.Text = "Añadir";
            this.btnAñadirclientes.UseVisualStyleBackColor = true;
            this.btnAñadirclientes.Click += new System.EventHandler(this.btnAñadirclientes_Click);
            // 
            // btnEliminarcliente
            // 
            this.btnEliminarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarcliente.Location = new System.Drawing.Point(22, 185);
            this.btnEliminarcliente.Name = "btnEliminarcliente";
            this.btnEliminarcliente.Size = new System.Drawing.Size(87, 25);
            this.btnEliminarcliente.TabIndex = 9;
            this.btnEliminarcliente.Text = "Eliminar";
            this.btnEliminarcliente.UseVisualStyleBackColor = true;
            this.btnEliminarcliente.Click += new System.EventHandler(this.btnEliminarcliente_Click);
            // 
            // btnModificarcliente
            // 
            this.btnModificarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarcliente.Location = new System.Drawing.Point(22, 138);
            this.btnModificarcliente.Name = "btnModificarcliente";
            this.btnModificarcliente.Size = new System.Drawing.Size(87, 27);
            this.btnModificarcliente.TabIndex = 8;
            this.btnModificarcliente.Text = "Modificar";
            this.btnModificarcliente.UseVisualStyleBackColor = true;
            this.btnModificarcliente.Click += new System.EventHandler(this.btnModificarcliente_Click);
            // 
            // gpbxClientes
            // 
            this.gpbxClientes.Controls.Add(this.lblUsuario);
            this.gpbxClientes.Controls.Add(this.label1);
            this.gpbxClientes.Controls.Add(this.pictureBox1);
            this.gpbxClientes.Controls.Add(this.btnVerClientes);
            this.gpbxClientes.Controls.Add(this.btnAñadirclientes);
            this.gpbxClientes.Controls.Add(this.btnSalirClientes);
            this.gpbxClientes.Controls.Add(this.btnEliminarcliente);
            this.gpbxClientes.Controls.Add(this.btnModificarcliente);
            this.gpbxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxClientes.Location = new System.Drawing.Point(12, 12);
            this.gpbxClientes.Name = "gpbxClientes";
            this.gpbxClientes.Size = new System.Drawing.Size(313, 272);
            this.gpbxClientes.TabIndex = 12;
            this.gpbxClientes.TabStop = false;
            this.gpbxClientes.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(166, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(38, 16);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "user";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(341, 296);
            this.Controls.Add(this.gpbxClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.TextChanged += new System.EventHandler(this.Clientes_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbxClientes.ResumeLayout(false);
            this.gpbxClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAñadirclientes;
        private System.Windows.Forms.Button btnEliminarcliente;
        private System.Windows.Forms.Button btnModificarcliente;
        private System.Windows.Forms.GroupBox gpbxClientes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
    }
}