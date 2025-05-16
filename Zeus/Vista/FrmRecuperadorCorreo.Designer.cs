namespace Zeus.Vista
{
    partial class FrmRecuperadorCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperadorCorreo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbVerificacion = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerCodigo = new System.Windows.Forms.Button();
            this.txtCodigoUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCorreo = new System.Windows.Forms.GroupBox();
            this.txtencriptado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtConClave = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNuClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbVerificacion.SuspendLayout();
            this.gbCorreo.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1090, 27);
            this.toolStrip1.TabIndex = 77;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(253, 24);
            this.toolStripLabel1.Text = "Recuperacion por Correo Electronico";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 24);
            this.toolStripLabel2.Text = "Regresar";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 36);
            this.label3.TabIndex = 80;
            this.label3.Text = "Por favor ingresa los datos correspondientes";
            // 
            // gbVerificacion
            // 
            this.gbVerificacion.Controls.Add(this.panel3);
            this.gbVerificacion.Controls.Add(this.btnVerCodigo);
            this.gbVerificacion.Controls.Add(this.txtCodigoUs);
            this.gbVerificacion.Controls.Add(this.label4);
            this.gbVerificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVerificacion.Location = new System.Drawing.Point(156, 249);
            this.gbVerificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerificacion.Name = "gbVerificacion";
            this.gbVerificacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerificacion.Size = new System.Drawing.Size(875, 102);
            this.gbVerificacion.TabIndex = 84;
            this.gbVerificacion.TabStop = false;
            this.gbVerificacion.Text = "Codigo de Verificacion";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(236, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 1);
            this.panel3.TabIndex = 3;
            // 
            // btnVerCodigo
            // 
            this.btnVerCodigo.BackColor = System.Drawing.Color.Azure;
            this.btnVerCodigo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVerCodigo.Location = new System.Drawing.Point(655, 21);
            this.btnVerCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerCodigo.Name = "btnVerCodigo";
            this.btnVerCodigo.Size = new System.Drawing.Size(173, 63);
            this.btnVerCodigo.TabIndex = 4;
            this.btnVerCodigo.Text = "Verificar";
            this.btnVerCodigo.UseVisualStyleBackColor = false;
            this.btnVerCodigo.Click += new System.EventHandler(this.btnVerCodigo_Click);
            // 
            // txtCodigoUs
            // 
            this.txtCodigoUs.BackColor = System.Drawing.Color.White;
            this.txtCodigoUs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoUs.Location = new System.Drawing.Point(236, 48);
            this.txtCodigoUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoUs.Name = "txtCodigoUs";
            this.txtCodigoUs.Size = new System.Drawing.Size(356, 17);
            this.txtCodigoUs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codigo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbCorreo
            // 
            this.gbCorreo.Controls.Add(this.txtencriptado);
            this.gbCorreo.Controls.Add(this.label6);
            this.gbCorreo.Controls.Add(this.panel4);
            this.gbCorreo.Controls.Add(this.txtConClave);
            this.gbCorreo.Controls.Add(this.panel1);
            this.gbCorreo.Controls.Add(this.label5);
            this.gbCorreo.Controls.Add(this.btnGuardar);
            this.gbCorreo.Controls.Add(this.txtNuClave);
            this.gbCorreo.Controls.Add(this.label2);
            this.gbCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCorreo.Location = new System.Drawing.Point(156, 369);
            this.gbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCorreo.Name = "gbCorreo";
            this.gbCorreo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCorreo.Size = new System.Drawing.Size(875, 142);
            this.gbCorreo.TabIndex = 83;
            this.gbCorreo.TabStop = false;
            this.gbCorreo.Text = "Envio de Correo";
            // 
            // txtencriptado
            // 
            this.txtencriptado.BackColor = System.Drawing.Color.White;
            this.txtencriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtencriptado.Location = new System.Drawing.Point(236, 32);
            this.txtencriptado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtencriptado.Name = "txtencriptado";
            this.txtencriptado.Size = new System.Drawing.Size(173, 17);
            this.txtencriptado.TabIndex = 8;
            this.txtencriptado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(405, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "las contraseñas no coinciden";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(420, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 1);
            this.panel4.TabIndex = 6;
            // 
            // txtConClave
            // 
            this.txtConClave.BackColor = System.Drawing.Color.White;
            this.txtConClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConClave.Location = new System.Drawing.Point(420, 71);
            this.txtConClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConClave.Name = "txtConClave";
            this.txtConClave.Size = new System.Drawing.Size(173, 17);
            this.txtConClave.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(131, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 1);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verificar:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Location = new System.Drawing.Point(655, 32);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 63);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNuClave
            // 
            this.txtNuClave.BackColor = System.Drawing.Color.White;
            this.txtNuClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuClave.Location = new System.Drawing.Point(131, 68);
            this.txtNuClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuClave.Name = "txtNuClave";
            this.txtNuClave.Size = new System.Drawing.Size(173, 17);
            this.txtNuClave.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cotraseña:";
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.btnVerificar);
            this.gbUsuario.Controls.Add(this.panel2);
            this.gbUsuario.Controls.Add(this.txtUs);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.Location = new System.Drawing.Point(156, 118);
            this.gbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsuario.Size = new System.Drawing.Size(875, 127);
            this.gbUsuario.TabIndex = 82;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Verifique el Usuario";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Azure;
            this.btnVerificar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVerificar.Location = new System.Drawing.Point(655, 43);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(173, 63);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(236, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 1);
            this.panel2.TabIndex = 4;
            // 
            // txtUs
            // 
            this.txtUs.BackColor = System.Drawing.Color.White;
            this.txtUs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUs.Location = new System.Drawing.Point(236, 43);
            this.txtUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(356, 17);
            this.txtUs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario a Recuperar:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 27);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(125, 505);
            this.bunifuGradientPanel1.TabIndex = 78;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmRecuperadorCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 532);
            this.Controls.Add(this.gbVerificacion);
            this.Controls.Add(this.gbCorreo);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecuperadorCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperadorCorreo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbVerificacion.ResumeLayout(false);
            this.gbVerificacion.PerformLayout();
            this.gbCorreo.ResumeLayout(false);
            this.gbCorreo.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbVerificacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerCodigo;
        private System.Windows.Forms.TextBox txtCodigoUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConClave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNuClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtencriptado;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}