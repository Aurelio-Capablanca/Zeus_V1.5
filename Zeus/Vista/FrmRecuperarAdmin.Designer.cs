namespace Zeus.Vista
{
    partial class FrmRecuperarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarAdmin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnusuario = new System.Windows.Forms.Button();
            this.lineausuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpcredenial = new System.Windows.Forms.GroupBox();
            this.txtEncrip = new System.Windows.Forms.TextBox();
            this.btncredencial = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroot = new System.Windows.Forms.TextBox();
            this.grpnew = new System.Windows.Forms.GroupBox();
            this.txtEncriptados = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontraenvio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtingresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.grpcredenial.SuspendLayout();
            this.grpnew.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1155, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(225, 24);
            this.toolStripLabel1.Text = "Recuperacion por Administrador";
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnusuario);
            this.grpUser.Controls.Add(this.lineausuario);
            this.grpUser.Controls.Add(this.lblUsuario);
            this.grpUser.Controls.Add(this.txtUsuario);
            this.grpUser.Location = new System.Drawing.Point(106, 124);
            this.grpUser.Margin = new System.Windows.Forms.Padding(4);
            this.grpUser.Name = "grpUser";
            this.grpUser.Padding = new System.Windows.Forms.Padding(4);
            this.grpUser.Size = new System.Drawing.Size(452, 138);
            this.grpUser.TabIndex = 1;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Verificar su Usuario ";
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.Azure;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnusuario.Location = new System.Drawing.Point(308, 39);
            this.btnusuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(119, 49);
            this.btnusuario.TabIndex = 73;
            this.btnusuario.Text = "Verificar";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // lineausuario
            // 
            this.lineausuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineausuario.Location = new System.Drawing.Point(31, 87);
            this.lineausuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineausuario.Name = "lineausuario";
            this.lineausuario.Size = new System.Drawing.Size(219, 1);
            this.lineausuario.TabIndex = 72;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(27, 38);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(134, 20);
            this.lblUsuario.TabIndex = 70;
            this.lblUsuario.Text = "Ingrese su usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(31, 69);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(219, 19);
            this.txtUsuario.TabIndex = 71;
            // 
            // grpcredenial
            // 
            this.grpcredenial.Controls.Add(this.txtEncrip);
            this.grpcredenial.Controls.Add(this.btncredencial);
            this.grpcredenial.Controls.Add(this.panel3);
            this.grpcredenial.Controls.Add(this.label3);
            this.grpcredenial.Controls.Add(this.txtclave);
            this.grpcredenial.Controls.Add(this.panel1);
            this.grpcredenial.Controls.Add(this.label1);
            this.grpcredenial.Controls.Add(this.txtroot);
            this.grpcredenial.Location = new System.Drawing.Point(566, 124);
            this.grpcredenial.Margin = new System.Windows.Forms.Padding(4);
            this.grpcredenial.Name = "grpcredenial";
            this.grpcredenial.Padding = new System.Windows.Forms.Padding(4);
            this.grpcredenial.Size = new System.Drawing.Size(580, 137);
            this.grpcredenial.TabIndex = 2;
            this.grpcredenial.TabStop = false;
            this.grpcredenial.Text = "Ingrese sus Credenciales";
            this.grpcredenial.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtEncrip
            // 
            this.txtEncrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEncrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrip.Location = new System.Drawing.Point(506, 9);
            this.txtEncrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncrip.MaxLength = 25;
            this.txtEncrip.Multiline = true;
            this.txtEncrip.Name = "txtEncrip";
            this.txtEncrip.Size = new System.Drawing.Size(48, 12);
            this.txtEncrip.TabIndex = 79;
            this.txtEncrip.Visible = false;
            // 
            // btncredencial
            // 
            this.btncredencial.BackColor = System.Drawing.Color.Azure;
            this.btncredencial.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredencial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncredencial.Location = new System.Drawing.Point(452, 45);
            this.btncredencial.Margin = new System.Windows.Forms.Padding(4);
            this.btncredencial.Name = "btncredencial";
            this.btncredencial.Size = new System.Drawing.Size(111, 43);
            this.btncredencial.TabIndex = 74;
            this.btncredencial.Text = "Verificar";
            this.btncredencial.UseVisualStyleBackColor = false;
            this.btncredencial.Click += new System.EventHandler(this.btncredencial_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(253, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 1);
            this.panel3.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Contraseña:";
            // 
            // txtclave
            // 
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(253, 73);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.MaxLength = 25;
            this.txtclave.Multiline = true;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(179, 27);
            this.txtclave.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(31, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 1);
            this.panel1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre Root:";
            // 
            // txtroot
            // 
            this.txtroot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroot.Location = new System.Drawing.Point(31, 73);
            this.txtroot.Margin = new System.Windows.Forms.Padding(4);
            this.txtroot.MaxLength = 25;
            this.txtroot.Multiline = true;
            this.txtroot.Name = "txtroot";
            this.txtroot.Size = new System.Drawing.Size(179, 27);
            this.txtroot.TabIndex = 74;
            // 
            // grpnew
            // 
            this.grpnew.Controls.Add(this.txtEncriptados);
            this.grpnew.Controls.Add(this.btnnew);
            this.grpnew.Controls.Add(this.panel4);
            this.grpnew.Controls.Add(this.label4);
            this.grpnew.Controls.Add(this.txtcontraenvio);
            this.grpnew.Controls.Add(this.panel2);
            this.grpnew.Controls.Add(this.label2);
            this.grpnew.Controls.Add(this.txtingresa);
            this.grpnew.Location = new System.Drawing.Point(106, 269);
            this.grpnew.Margin = new System.Windows.Forms.Padding(4);
            this.grpnew.Name = "grpnew";
            this.grpnew.Padding = new System.Windows.Forms.Padding(4);
            this.grpnew.Size = new System.Drawing.Size(1040, 194);
            this.grpnew.TabIndex = 3;
            this.grpnew.TabStop = false;
            this.grpnew.Text = "Ingrese y verifique su nueva contraseña";
            // 
            // txtEncriptados
            // 
            this.txtEncriptados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEncriptados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncriptados.Location = new System.Drawing.Point(863, 55);
            this.txtEncriptados.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncriptados.MaxLength = 25;
            this.txtEncriptados.Multiline = true;
            this.txtEncriptados.Name = "txtEncriptados";
            this.txtEncriptados.Size = new System.Drawing.Size(179, 27);
            this.txtEncriptados.TabIndex = 86;
            this.txtEncriptados.Visible = false;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Azure;
            this.btnnew.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnnew.Location = new System.Drawing.Point(801, 90);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(111, 43);
            this.btnnew.TabIndex = 85;
            this.btnnew.Text = "Enviar";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(363, 134);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 1);
            this.panel4.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(357, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Verifique su Contraseña:";
            // 
            // txtcontraenvio
            // 
            this.txtcontraenvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraenvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraenvio.Location = new System.Drawing.Point(361, 106);
            this.txtcontraenvio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraenvio.MaxLength = 25;
            this.txtcontraenvio.Multiline = true;
            this.txtcontraenvio.Name = "txtcontraenvio";
            this.txtcontraenvio.Size = new System.Drawing.Size(179, 27);
            this.txtcontraenvio.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(137, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 1);
            this.panel2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nueva Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtingresa
            // 
            this.txtingresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtingresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingresa.Location = new System.Drawing.Point(137, 106);
            this.txtingresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtingresa.MaxLength = 25;
            this.txtingresa.Multiline = true;
            this.txtingresa.Name = "txtingresa";
            this.txtingresa.Size = new System.Drawing.Size(179, 27);
            this.txtingresa.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(100, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(626, 36);
            this.label5.TabIndex = 140;
            this.label5.Text = "Por favor ingresa los datos correspondientes";
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(93, 462);
            this.bunifuGradientPanel1.TabIndex = 139;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Zeus.Properties.Resources.exit_11;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 24);
            this.toolStripLabel2.Text = "Regresar";
            // 
            // FrmRecuperarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.grpnew);
            this.Controls.Add(this.grpcredenial);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecuperarAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperarAdmin";
            this.Load += new System.EventHandler(this.FrmRecuperarAdmin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpcredenial.ResumeLayout(false);
            this.grpcredenial.PerformLayout();
            this.grpnew.ResumeLayout(false);
            this.grpnew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox grpcredenial;
        private System.Windows.Forms.GroupBox grpnew;
        private System.Windows.Forms.Panel lineausuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtroot;
        private System.Windows.Forms.Button btncredencial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontraenvio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtingresa;
        private System.Windows.Forms.TextBox txtEncrip;
        private System.Windows.Forms.TextBox txtEncriptados;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}