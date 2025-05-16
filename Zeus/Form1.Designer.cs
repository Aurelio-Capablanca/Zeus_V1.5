namespace Zeus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnExpandir = new System.Windows.Forms.ToolStripButton();
            this.btnNormal = new System.Windows.Forms.ToolStripButton();
            this.btnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LblUsuarioConectado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPadron = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstadisticas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPartidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripLabel1,
            this.btnCerrar,
            this.btnExpandir,
            this.btnNormal,
            this.btnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Zeus.Properties.Resources.menu_2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(187, 24);
            this.toolStripLabel1.Text = "Zeus | Sistema de Votacion del TSE";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExpandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
            this.btnExpandir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(24, 24);
            this.btnExpandir.Text = "Agrandar";
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(24, 24);
            this.btnNormal.Text = "Normal";
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.Text = "Minimizar";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.toolStrip2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(234, 27);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(699, 487);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel2,
            this.LblUsuarioConectado,
            this.toolStripLabel3,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripLabel4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 460);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(699, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 24);
            this.toolStripLabel2.Text = "Usuario: -";
            // 
            // LblUsuarioConectado
            // 
            this.LblUsuarioConectado.Name = "LblUsuarioConectado";
            this.LblUsuarioConectado.Size = new System.Drawing.Size(10, 24);
            this.LblUsuarioConectado.Text = ".";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 24);
            this.toolStripLabel3.Text = ".";
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
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(76, 24);
            this.toolStripLabel4.Text = "Cerrar Sesion";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnPadron);
            this.bunifuGradientPanel1.Controls.Add(this.btnEstadisticas);
            this.bunifuGradientPanel1.Controls.Add(this.btnPartidos);
            this.bunifuGradientPanel1.Controls.Add(this.btnUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 27);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(234, 487);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "               Reportes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 363);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.LightCyan;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(227, 48);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "               Reportes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnPadron
            // 
            this.btnPadron.Activecolor = System.Drawing.Color.Transparent;
            this.btnPadron.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPadron.BackColor = System.Drawing.Color.Transparent;
            this.btnPadron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPadron.BorderRadius = 0;
            this.btnPadron.ButtonText = "               Padron";
            this.btnPadron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPadron.DisabledColor = System.Drawing.Color.Gray;
            this.btnPadron.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPadron.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPadron.Iconimage")));
            this.btnPadron.Iconimage_right = null;
            this.btnPadron.Iconimage_right_Selected = null;
            this.btnPadron.Iconimage_Selected = null;
            this.btnPadron.IconMarginLeft = 0;
            this.btnPadron.IconMarginRight = 0;
            this.btnPadron.IconRightVisible = true;
            this.btnPadron.IconRightZoom = 0D;
            this.btnPadron.IconVisible = true;
            this.btnPadron.IconZoom = 90D;
            this.btnPadron.IsTab = false;
            this.btnPadron.Location = new System.Drawing.Point(3, 251);
            this.btnPadron.Margin = new System.Windows.Forms.Padding(4);
            this.btnPadron.Name = "btnPadron";
            this.btnPadron.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPadron.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnPadron.OnHoverTextColor = System.Drawing.Color.LightCyan;
            this.btnPadron.selected = false;
            this.btnPadron.Size = new System.Drawing.Size(227, 48);
            this.btnPadron.TabIndex = 5;
            this.btnPadron.Text = "               Padron";
            this.btnPadron.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPadron.Textcolor = System.Drawing.Color.White;
            this.btnPadron.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadron.Click += new System.EventHandler(this.btnPadron_Click_2);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Activecolor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.BorderRadius = 0;
            this.btnEstadisticas.ButtonText = "              Estadisticas";
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstadisticas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Iconimage")));
            this.btnEstadisticas.Iconimage_right = null;
            this.btnEstadisticas.Iconimage_right_Selected = null;
            this.btnEstadisticas.Iconimage_Selected = null;
            this.btnEstadisticas.IconMarginLeft = 0;
            this.btnEstadisticas.IconMarginRight = 0;
            this.btnEstadisticas.IconRightVisible = true;
            this.btnEstadisticas.IconRightZoom = 0D;
            this.btnEstadisticas.IconVisible = true;
            this.btnEstadisticas.IconZoom = 90D;
            this.btnEstadisticas.IsTab = false;
            this.btnEstadisticas.Location = new System.Drawing.Point(1, 307);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnEstadisticas.OnHoverTextColor = System.Drawing.Color.LightCyan;
            this.btnEstadisticas.selected = false;
            this.btnEstadisticas.Size = new System.Drawing.Size(227, 48);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "              Estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Textcolor = System.Drawing.Color.White;
            this.btnEstadisticas.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Activecolor = System.Drawing.Color.Transparent;
            this.btnPartidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartidos.BorderRadius = 0;
            this.btnPartidos.ButtonText = "               Partidos";
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPartidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPartidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPartidos.Iconimage")));
            this.btnPartidos.Iconimage_right = null;
            this.btnPartidos.Iconimage_right_Selected = null;
            this.btnPartidos.Iconimage_Selected = null;
            this.btnPartidos.IconMarginLeft = 0;
            this.btnPartidos.IconMarginRight = 0;
            this.btnPartidos.IconRightVisible = true;
            this.btnPartidos.IconRightZoom = 0D;
            this.btnPartidos.IconVisible = true;
            this.btnPartidos.IconZoom = 90D;
            this.btnPartidos.IsTab = false;
            this.btnPartidos.Location = new System.Drawing.Point(3, 195);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPartidos.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnPartidos.OnHoverTextColor = System.Drawing.Color.LightCyan;
            this.btnPartidos.selected = false;
            this.btnPartidos.Size = new System.Drawing.Size(227, 48);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "               Partidos";
            this.btnPartidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidos.Textcolor = System.Drawing.Color.White;
            this.btnPartidos.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.Click += new System.EventHandler(this.btnPadron_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Activecolor = System.Drawing.Color.Transparent;
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.BorderRadius = 0;
            this.btnUsuario.ButtonText = "               Usuarios";
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Iconimage")));
            this.btnUsuario.Iconimage_right = null;
            this.btnUsuario.Iconimage_right_Selected = null;
            this.btnUsuario.Iconimage_Selected = null;
            this.btnUsuario.IconMarginLeft = 0;
            this.btnUsuario.IconMarginRight = 0;
            this.btnUsuario.IconRightVisible = true;
            this.btnUsuario.IconRightZoom = 0D;
            this.btnUsuario.IconVisible = true;
            this.btnUsuario.IconZoom = 90D;
            this.btnUsuario.IsTab = false;
            this.btnUsuario.Location = new System.Drawing.Point(3, 139);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuario.OnHoverTextColor = System.Drawing.Color.LightCyan;
            this.btnUsuario.selected = false;
            this.btnUsuario.Size = new System.Drawing.Size(227, 48);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "               Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Textcolor = System.Drawing.Color.White;
            this.btnUsuario.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Zeus.Properties.Resources.Sistema_de_Votos_del_TSE_png_BLANCO;
            this.pictureBox1.Location = new System.Drawing.Point(58, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPadron;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstadisticas;
        private Bunifu.Framework.UI.BunifuFlatButton btnPartidos;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuario;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnExpandir;
        private System.Windows.Forms.ToolStripButton btnNormal;
        private System.Windows.Forms.ToolStripButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel LblUsuarioConectado;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

