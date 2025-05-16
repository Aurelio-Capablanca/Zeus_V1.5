namespace Zeus.Vista
{
    partial class FrmRecuperacionRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperacionRes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnusuario = new System.Windows.Forms.Button();
            this.lineausuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grppregntas = new System.Windows.Forms.GroupBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtencript2 = new System.Windows.Forms.TextBox();
            this.txtencript1 = new System.Windows.Forms.TextBox();
            this.txtEncriptados = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblpreg1 = new System.Windows.Forms.Label();
            this.txtres2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpreg2 = new System.Windows.Forms.Label();
            this.txtres1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.grppregntas.SuspendLayout();
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
            this.toolStripLabel1.Size = new System.Drawing.Size(282, 24);
            this.toolStripLabel1.Text = "Recuperador por preguntas de seguridad";
            // 
            // grpUser
            // 
            this.grpUser.BackColor = System.Drawing.Color.White;
            this.grpUser.Controls.Add(this.btnusuario);
            this.grpUser.Controls.Add(this.lineausuario);
            this.grpUser.Controls.Add(this.lblUsuario);
            this.grpUser.Controls.Add(this.txtUsuario);
            this.grpUser.Location = new System.Drawing.Point(155, 96);
            this.grpUser.Margin = new System.Windows.Forms.Padding(4);
            this.grpUser.Name = "grpUser";
            this.grpUser.Padding = new System.Windows.Forms.Padding(4);
            this.grpUser.Size = new System.Drawing.Size(941, 138);
            this.grpUser.TabIndex = 2;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Verificar su Usuario ";
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.Azure;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnusuario.Location = new System.Drawing.Point(746, 56);
            this.btnusuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(139, 49);
            this.btnusuario.TabIndex = 73;
            this.btnusuario.Text = "Verificar";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // lineausuario
            // 
            this.lineausuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineausuario.Location = new System.Drawing.Point(309, 88);
            this.lineausuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineausuario.Name = "lineausuario";
            this.lineausuario.Size = new System.Drawing.Size(360, 1);
            this.lineausuario.TabIndex = 72;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(76, 72);
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
            this.txtUsuario.Location = new System.Drawing.Point(309, 69);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(360, 19);
            this.txtUsuario.TabIndex = 71;
            // 
            // grppregntas
            // 
            this.grppregntas.Controls.Add(this.txtclave);
            this.grppregntas.Controls.Add(this.txtencript2);
            this.grppregntas.Controls.Add(this.txtencript1);
            this.grppregntas.Controls.Add(this.txtEncriptados);
            this.grppregntas.Controls.Add(this.btnnew);
            this.grppregntas.Controls.Add(this.panel4);
            this.grppregntas.Controls.Add(this.lblpreg1);
            this.grppregntas.Controls.Add(this.txtres2);
            this.grppregntas.Controls.Add(this.panel2);
            this.grppregntas.Controls.Add(this.lblpreg2);
            this.grppregntas.Controls.Add(this.txtres1);
            this.grppregntas.Location = new System.Drawing.Point(155, 241);
            this.grppregntas.Margin = new System.Windows.Forms.Padding(4);
            this.grppregntas.Name = "grppregntas";
            this.grppregntas.Padding = new System.Windows.Forms.Padding(4);
            this.grppregntas.Size = new System.Drawing.Size(941, 234);
            this.grppregntas.TabIndex = 4;
            this.grppregntas.TabStop = false;
            this.grppregntas.Text = "Responda las preguntas";
            this.grppregntas.Enter += new System.EventHandler(this.grpnew_Enter);
            // 
            // txtclave
            // 
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(863, 21);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.MaxLength = 25;
            this.txtclave.Multiline = true;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(179, 27);
            this.txtclave.TabIndex = 89;
            this.txtclave.Visible = false;
            // 
            // txtencript2
            // 
            this.txtencript2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtencript2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencript2.Location = new System.Drawing.Point(-65, 46);
            this.txtencript2.Margin = new System.Windows.Forms.Padding(4);
            this.txtencript2.MaxLength = 25;
            this.txtencript2.Multiline = true;
            this.txtencript2.Name = "txtencript2";
            this.txtencript2.Size = new System.Drawing.Size(647, 27);
            this.txtencript2.TabIndex = 88;
            this.txtencript2.Visible = false;
            // 
            // txtencript1
            // 
            this.txtencript1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtencript1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencript1.Location = new System.Drawing.Point(37, 45);
            this.txtencript1.Margin = new System.Windows.Forms.Padding(4);
            this.txtencript1.MaxLength = 25;
            this.txtencript1.Multiline = true;
            this.txtencript1.Name = "txtencript1";
            this.txtencript1.Size = new System.Drawing.Size(647, 27);
            this.txtencript1.TabIndex = 87;
            this.txtencript1.Visible = false;
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
            this.btnnew.Location = new System.Drawing.Point(755, 98);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(139, 56);
            this.btnnew.TabIndex = 85;
            this.btnnew.Text = "Enviar";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(319, 159);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 1);
            this.panel4.TabIndex = 84;
            // 
            // lblpreg1
            // 
            this.lblpreg1.AutoSize = true;
            this.lblpreg1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreg1.ForeColor = System.Drawing.Color.Black;
            this.lblpreg1.Location = new System.Drawing.Point(71, 82);
            this.lblpreg1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpreg1.Name = "lblpreg1";
            this.lblpreg1.Size = new System.Drawing.Size(45, 20);
            this.lblpreg1.TabIndex = 82;
            this.lblpreg1.Text = "------";
            // 
            // txtres2
            // 
            this.txtres2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtres2.Location = new System.Drawing.Point(318, 131);
            this.txtres2.Margin = new System.Windows.Forms.Padding(4);
            this.txtres2.MaxLength = 25;
            this.txtres2.Multiline = true;
            this.txtres2.Name = "txtres2";
            this.txtres2.Size = new System.Drawing.Size(387, 27);
            this.txtres2.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(319, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 1);
            this.panel2.TabIndex = 81;
            // 
            // lblpreg2
            // 
            this.lblpreg2.AutoSize = true;
            this.lblpreg2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreg2.ForeColor = System.Drawing.Color.Black;
            this.lblpreg2.Location = new System.Drawing.Point(71, 134);
            this.lblpreg2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpreg2.Name = "lblpreg2";
            this.lblpreg2.Size = new System.Drawing.Size(45, 20);
            this.lblpreg2.TabIndex = 79;
            this.lblpreg2.Text = "------";
            // 
            // txtres1
            // 
            this.txtres1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtres1.Location = new System.Drawing.Point(319, 80);
            this.txtres1.Margin = new System.Windows.Forms.Padding(4);
            this.txtres1.MaxLength = 25;
            this.txtres1.Multiline = true;
            this.txtres1.Name = "txtres1";
            this.txtres1.Size = new System.Drawing.Size(387, 27);
            this.txtres1.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 36);
            this.label3.TabIndex = 140;
            this.label3.Text = "Por favor ingresa los datos correspondientes";
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(126, 462);
            this.bunifuGradientPanel1.TabIndex = 139;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Zeus.Properties.Resources.exit_1;
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
            // FrmRecuperacionRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.grppregntas);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecuperacionRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperacionRes";
            this.Load += new System.EventHandler(this.FrmRecuperacionRes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grppregntas.ResumeLayout(false);
            this.grppregntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Panel lineausuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox grppregntas;
        private System.Windows.Forms.TextBox txtEncriptados;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblpreg1;
        private System.Windows.Forms.TextBox txtres2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblpreg2;
        private System.Windows.Forms.TextBox txtres1;
        private System.Windows.Forms.TextBox txtencript2;
        private System.Windows.Forms.TextBox txtencript1;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}