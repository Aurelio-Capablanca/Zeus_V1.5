namespace Zeus.Vista
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LinkRecuperarClave = new System.Windows.Forms.LinkLabel();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtEncrip = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lineausuario = new System.Windows.Forms.Panel();
            this.lineacontra = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrimerUso = new Bunifu.Framework.UI.BunifuTileButton();
            this.toolStrip1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkRecuperarClave
            // 
            this.LinkRecuperarClave.AutoSize = true;
            this.LinkRecuperarClave.BackColor = System.Drawing.Color.Transparent;
            this.LinkRecuperarClave.LinkColor = System.Drawing.Color.Black;
            this.LinkRecuperarClave.Location = new System.Drawing.Point(585, 416);
            this.LinkRecuperarClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkRecuperarClave.Name = "LinkRecuperarClave";
            this.LinkRecuperarClave.Size = new System.Drawing.Size(158, 17);
            this.LinkRecuperarClave.TabIndex = 11;
            this.LinkRecuperarClave.TabStop = true;
            this.LinkRecuperarClave.Text = "¿Olvido su contraseña?";
            this.LinkRecuperarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRecuperarClave_LinkClicked);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Azure;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnIniciar.Location = new System.Drawing.Point(572, 359);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(180, 49);
            this.BtnIniciar.TabIndex = 10;
            this.BtnIniciar.Text = "Inicia";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.Black;
            this.lblClave.Location = new System.Drawing.Point(489, 257);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(88, 20);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(468, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bienvenido a Zeus";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(489, 192);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(134, 20);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Ingrese su usuario:";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(493, 281);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.MaxLength = 59;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(351, 19);
            this.txtClave.TabIndex = 9;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(493, 215);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(351, 19);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Zeus.Properties.Resources.error;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Cerrar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel1.Text = "Inicia Secion";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 24);
            this.toolStripLabel2.Text = "Cerrar";
            // 
            // txtEncrip
            // 
            this.txtEncrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrip.Location = new System.Drawing.Point(447, 34);
            this.txtEncrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncrip.Name = "txtEncrip";
            this.txtEncrip.Size = new System.Drawing.Size(347, 26);
            this.txtEncrip.TabIndex = 14;
            this.txtEncrip.Visible = false;
            this.txtEncrip.TextChanged += new System.EventHandler(this.txtEncrip_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(333, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 26);
            this.txtID.TabIndex = 15;
            this.txtID.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(455, 186);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(365, 189);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.Text = "Hola y Bienvenido :) \r\nHemos notado que es la primera \r\nvez que usas nuestro sist" +
    "ema. \r\n¿Por que no Ingresas tu empresa y/o\r\ncreas tu primer usuario?\r\n\"Preciona " +
    "al boton de primer uso\" :)\r\n\r\n";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // lineausuario
            // 
            this.lineausuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineausuario.Location = new System.Drawing.Point(493, 240);
            this.lineausuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineausuario.Name = "lineausuario";
            this.lineausuario.Size = new System.Drawing.Size(351, 1);
            this.lineausuario.TabIndex = 69;
            // 
            // lineacontra
            // 
            this.lineacontra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineacontra.Location = new System.Drawing.Point(493, 305);
            this.lineacontra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineacontra.Name = "lineacontra";
            this.lineacontra.Size = new System.Drawing.Size(351, 1);
            this.lineacontra.TabIndex = 70;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnPrimerUso);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(305, 494);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Zeus.Properties.Resources.Sistema_de_Votos_del_TSE_png_BLANCO1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrimerUso
            // 
            this.btnPrimerUso.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPrimerUso.color = System.Drawing.Color.SlateBlue;
            this.btnPrimerUso.colorActive = System.Drawing.Color.SkyBlue;
            this.btnPrimerUso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnPrimerUso.ForeColor = System.Drawing.Color.White;
            this.btnPrimerUso.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimerUso.Image")));
            this.btnPrimerUso.ImagePosition = 20;
            this.btnPrimerUso.ImageZoom = 50;
            this.btnPrimerUso.LabelPosition = 41;
            this.btnPrimerUso.LabelText = "Primer Uso";
            this.btnPrimerUso.Location = new System.Drawing.Point(71, 170);
            this.btnPrimerUso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrimerUso.Name = "btnPrimerUso";
            this.btnPrimerUso.Size = new System.Drawing.Size(171, 169);
            this.btnPrimerUso.TabIndex = 18;
            this.btnPrimerUso.Click += new System.EventHandler(this.btnPrimerUso_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lineacontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineausuario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEncrip);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.LinkRecuperarClave);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LinkRecuperarClave;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEncrip;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Bunifu.Framework.UI.BunifuTileButton btnPrimerUso;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel lineausuario;
        private System.Windows.Forms.Panel lineacontra;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}