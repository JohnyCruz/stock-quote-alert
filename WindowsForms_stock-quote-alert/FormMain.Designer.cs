namespace WindowsForms_stock_quote_alert
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.monitor = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAtivo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRefVenda = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRefCompra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTileParar = new MetroFramework.Controls.MetroTile();
            this.metroTileIniciar = new MetroFramework.Controls.MetroTile();
            this.configuracao = new MetroFramework.Controls.MetroTabPage();
            this.metroTileSalvar = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxAPIKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSMTPPort = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSMTPHost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxEmailPara = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmailDe = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxCredencialSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCredencialEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.monitor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.configuracao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.monitor);
            this.metroTabControl1.Controls.Add(this.configuracao);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(522, 434);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // monitor
            // 
            this.monitor.Controls.Add(this.metroLabel10);
            this.monitor.Controls.Add(this.groupBox4);
            this.monitor.Controls.Add(this.metroTileParar);
            this.monitor.Controls.Add(this.metroTileIniciar);
            this.monitor.HorizontalScrollbarBarColor = true;
            this.monitor.HorizontalScrollbarHighlightOnWheel = false;
            this.monitor.HorizontalScrollbarSize = 10;
            this.monitor.Location = new System.Drawing.Point(4, 38);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(514, 392);
            this.monitor.TabIndex = 0;
            this.monitor.Text = "Monitor";
            this.monitor.VerticalScrollbarBarColor = true;
            this.monitor.VerticalScrollbarHighlightOnWheel = false;
            this.monitor.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(198, 187);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(0, 0);
            this.metroLabel10.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroTextBoxAtivo);
            this.groupBox4.Controls.Add(this.metroTextBoxRefVenda);
            this.groupBox4.Controls.Add(this.metroTextBoxRefCompra);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Location = new System.Drawing.Point(14, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 169);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados do ativo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Referência Compra";
            // 
            // metroTextBoxAtivo
            // 
            // 
            // 
            // 
            this.metroTextBoxAtivo.CustomButton.Image = null;
            this.metroTextBoxAtivo.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBoxAtivo.CustomButton.Name = "";
            this.metroTextBoxAtivo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAtivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAtivo.CustomButton.TabIndex = 1;
            this.metroTextBoxAtivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAtivo.CustomButton.UseSelectable = true;
            this.metroTextBoxAtivo.CustomButton.Visible = false;
            this.metroTextBoxAtivo.Lines = new string[0];
            this.metroTextBoxAtivo.Location = new System.Drawing.Point(220, 36);
            this.metroTextBoxAtivo.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.metroTextBoxAtivo.MaxLength = 32767;
            this.metroTextBoxAtivo.Multiline = true;
            this.metroTextBoxAtivo.Name = "metroTextBoxAtivo";
            this.metroTextBoxAtivo.PasswordChar = '\0';
            this.metroTextBoxAtivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAtivo.SelectedText = "";
            this.metroTextBoxAtivo.SelectionLength = 0;
            this.metroTextBoxAtivo.SelectionStart = 0;
            this.metroTextBoxAtivo.ShortcutsEnabled = true;
            this.metroTextBoxAtivo.Size = new System.Drawing.Size(119, 23);
            this.metroTextBoxAtivo.TabIndex = 2;
            this.metroTextBoxAtivo.UseSelectable = true;
            this.metroTextBoxAtivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAtivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxRefVenda
            // 
            // 
            // 
            // 
            this.metroTextBoxRefVenda.CustomButton.Image = null;
            this.metroTextBoxRefVenda.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBoxRefVenda.CustomButton.Name = "";
            this.metroTextBoxRefVenda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRefVenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRefVenda.CustomButton.TabIndex = 1;
            this.metroTextBoxRefVenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRefVenda.CustomButton.UseSelectable = true;
            this.metroTextBoxRefVenda.CustomButton.Visible = false;
            this.metroTextBoxRefVenda.Lines = new string[0];
            this.metroTextBoxRefVenda.Location = new System.Drawing.Point(220, 77);
            this.metroTextBoxRefVenda.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.metroTextBoxRefVenda.MaxLength = 32767;
            this.metroTextBoxRefVenda.Multiline = true;
            this.metroTextBoxRefVenda.Name = "metroTextBoxRefVenda";
            this.metroTextBoxRefVenda.PasswordChar = '\0';
            this.metroTextBoxRefVenda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRefVenda.SelectedText = "";
            this.metroTextBoxRefVenda.SelectionLength = 0;
            this.metroTextBoxRefVenda.SelectionStart = 0;
            this.metroTextBoxRefVenda.ShortcutsEnabled = true;
            this.metroTextBoxRefVenda.Size = new System.Drawing.Size(119, 23);
            this.metroTextBoxRefVenda.TabIndex = 3;
            this.metroTextBoxRefVenda.UseSelectable = true;
            this.metroTextBoxRefVenda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRefVenda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxRefCompra
            // 
            // 
            // 
            // 
            this.metroTextBoxRefCompra.CustomButton.Image = null;
            this.metroTextBoxRefCompra.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBoxRefCompra.CustomButton.Name = "";
            this.metroTextBoxRefCompra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRefCompra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRefCompra.CustomButton.TabIndex = 1;
            this.metroTextBoxRefCompra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRefCompra.CustomButton.UseSelectable = true;
            this.metroTextBoxRefCompra.CustomButton.Visible = false;
            this.metroTextBoxRefCompra.Lines = new string[0];
            this.metroTextBoxRefCompra.Location = new System.Drawing.Point(220, 118);
            this.metroTextBoxRefCompra.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.metroTextBoxRefCompra.MaxLength = 32767;
            this.metroTextBoxRefCompra.Multiline = true;
            this.metroTextBoxRefCompra.Name = "metroTextBoxRefCompra";
            this.metroTextBoxRefCompra.PasswordChar = '\0';
            this.metroTextBoxRefCompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRefCompra.SelectedText = "";
            this.metroTextBoxRefCompra.SelectionLength = 0;
            this.metroTextBoxRefCompra.SelectionStart = 0;
            this.metroTextBoxRefCompra.ShortcutsEnabled = true;
            this.metroTextBoxRefCompra.Size = new System.Drawing.Size(119, 23);
            this.metroTextBoxRefCompra.TabIndex = 4;
            this.metroTextBoxRefCompra.UseSelectable = true;
            this.metroTextBoxRefCompra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRefCompra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Ativo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Referência Venda";
            // 
            // metroTileParar
            // 
            this.metroTileParar.ActiveControl = null;
            this.metroTileParar.Location = new System.Drawing.Point(106, 187);
            this.metroTileParar.Name = "metroTileParar";
            this.metroTileParar.Size = new System.Drawing.Size(86, 44);
            this.metroTileParar.TabIndex = 9;
            this.metroTileParar.Text = "Parar";
            this.metroTileParar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileParar.UseSelectable = true;
            // 
            // metroTileIniciar
            // 
            this.metroTileIniciar.ActiveControl = null;
            this.metroTileIniciar.Location = new System.Drawing.Point(14, 187);
            this.metroTileIniciar.Name = "metroTileIniciar";
            this.metroTileIniciar.Size = new System.Drawing.Size(86, 44);
            this.metroTileIniciar.TabIndex = 8;
            this.metroTileIniciar.Text = "Iniciar";
            this.metroTileIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileIniciar.UseSelectable = true;
            // 
            // configuracao
            // 
            this.configuracao.Controls.Add(this.metroTileSalvar);
            this.configuracao.Controls.Add(this.groupBox3);
            this.configuracao.Controls.Add(this.groupBox1);
            this.configuracao.HorizontalScrollbarBarColor = true;
            this.configuracao.HorizontalScrollbarHighlightOnWheel = false;
            this.configuracao.HorizontalScrollbarSize = 10;
            this.configuracao.Location = new System.Drawing.Point(4, 38);
            this.configuracao.Name = "configuracao";
            this.configuracao.Size = new System.Drawing.Size(514, 392);
            this.configuracao.Style = MetroFramework.MetroColorStyle.Green;
            this.configuracao.TabIndex = 1;
            this.configuracao.Text = "Configurações";
            this.configuracao.VerticalScrollbarBarColor = true;
            this.configuracao.VerticalScrollbarHighlightOnWheel = false;
            this.configuracao.VerticalScrollbarSize = 10;
            // 
            // metroTileSalvar
            // 
            this.metroTileSalvar.ActiveControl = null;
            this.metroTileSalvar.Location = new System.Drawing.Point(3, 326);
            this.metroTileSalvar.Name = "metroTileSalvar";
            this.metroTileSalvar.Size = new System.Drawing.Size(86, 44);
            this.metroTileSalvar.TabIndex = 10;
            this.metroTileSalvar.Text = "Salvar";
            this.metroTileSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSalvar.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.metroTextBoxAPIKey);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.metroTextBoxSMTPPort);
            this.groupBox3.Controls.Add(this.metroTextBoxSMTPHost);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Location = new System.Drawing.Point(3, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Avançado";
            // 
            // metroTextBoxAPIKey
            // 
            // 
            // 
            // 
            this.metroTextBoxAPIKey.CustomButton.Image = null;
            this.metroTextBoxAPIKey.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.metroTextBoxAPIKey.CustomButton.Name = "";
            this.metroTextBoxAPIKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAPIKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAPIKey.CustomButton.TabIndex = 1;
            this.metroTextBoxAPIKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAPIKey.CustomButton.UseSelectable = true;
            this.metroTextBoxAPIKey.CustomButton.Visible = false;
            this.metroTextBoxAPIKey.Lines = new string[0];
            this.metroTextBoxAPIKey.Location = new System.Drawing.Point(388, 29);
            this.metroTextBoxAPIKey.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.metroTextBoxAPIKey.MaxLength = 32767;
            this.metroTextBoxAPIKey.Multiline = true;
            this.metroTextBoxAPIKey.Name = "metroTextBoxAPIKey";
            this.metroTextBoxAPIKey.PasswordChar = '\0';
            this.metroTextBoxAPIKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAPIKey.SelectedText = "";
            this.metroTextBoxAPIKey.SelectionLength = 0;
            this.metroTextBoxAPIKey.SelectionStart = 0;
            this.metroTextBoxAPIKey.ShortcutsEnabled = true;
            this.metroTextBoxAPIKey.Size = new System.Drawing.Size(114, 23);
            this.metroTextBoxAPIKey.TabIndex = 13;
            this.metroTextBoxAPIKey.UseSelectable = true;
            this.metroTextBoxAPIKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAPIKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(304, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(52, 20);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "APIKey";
            // 
            // metroTextBoxSMTPPort
            // 
            // 
            // 
            // 
            this.metroTextBoxSMTPPort.CustomButton.Image = null;
            this.metroTextBoxSMTPPort.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.metroTextBoxSMTPPort.CustomButton.Name = "";
            this.metroTextBoxSMTPPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSMTPPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSMTPPort.CustomButton.TabIndex = 1;
            this.metroTextBoxSMTPPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSMTPPort.CustomButton.UseSelectable = true;
            this.metroTextBoxSMTPPort.CustomButton.Visible = false;
            this.metroTextBoxSMTPPort.Lines = new string[0];
            this.metroTextBoxSMTPPort.Location = new System.Drawing.Point(105, 62);
            this.metroTextBoxSMTPPort.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxSMTPPort.MaxLength = 32767;
            this.metroTextBoxSMTPPort.Multiline = true;
            this.metroTextBoxSMTPPort.Name = "metroTextBoxSMTPPort";
            this.metroTextBoxSMTPPort.PasswordChar = '\0';
            this.metroTextBoxSMTPPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSMTPPort.SelectedText = "";
            this.metroTextBoxSMTPPort.SelectionLength = 0;
            this.metroTextBoxSMTPPort.SelectionStart = 0;
            this.metroTextBoxSMTPPort.ShortcutsEnabled = true;
            this.metroTextBoxSMTPPort.Size = new System.Drawing.Size(184, 23);
            this.metroTextBoxSMTPPort.TabIndex = 10;
            this.metroTextBoxSMTPPort.UseSelectable = true;
            this.metroTextBoxSMTPPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSMTPPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxSMTPHost
            // 
            // 
            // 
            // 
            this.metroTextBoxSMTPHost.CustomButton.Image = null;
            this.metroTextBoxSMTPHost.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.metroTextBoxSMTPHost.CustomButton.Name = "";
            this.metroTextBoxSMTPHost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSMTPHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSMTPHost.CustomButton.TabIndex = 1;
            this.metroTextBoxSMTPHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSMTPHost.CustomButton.UseSelectable = true;
            this.metroTextBoxSMTPHost.CustomButton.Visible = false;
            this.metroTextBoxSMTPHost.Lines = new string[0];
            this.metroTextBoxSMTPHost.Location = new System.Drawing.Point(104, 29);
            this.metroTextBoxSMTPHost.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxSMTPHost.MaxLength = 32767;
            this.metroTextBoxSMTPHost.Multiline = true;
            this.metroTextBoxSMTPHost.Name = "metroTextBoxSMTPHost";
            this.metroTextBoxSMTPHost.PasswordChar = '\0';
            this.metroTextBoxSMTPHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSMTPHost.SelectedText = "";
            this.metroTextBoxSMTPHost.SelectionLength = 0;
            this.metroTextBoxSMTPHost.SelectionStart = 0;
            this.metroTextBoxSMTPHost.ShortcutsEnabled = true;
            this.metroTextBoxSMTPHost.Size = new System.Drawing.Size(185, 23);
            this.metroTextBoxSMTPHost.TabIndex = 9;
            this.metroTextBoxSMTPHost.UseSelectable = true;
            this.metroTextBoxSMTPHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSMTPHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 65);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 20);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "SMTPPort";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 29);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "SMTPHost";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroTextBoxEmailPara);
            this.groupBox1.Controls.Add(this.metroTextBoxEmailDe);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar E-mail";
            // 
            // metroTextBoxEmailPara
            // 
            // 
            // 
            // 
            this.metroTextBoxEmailPara.CustomButton.Image = null;
            this.metroTextBoxEmailPara.CustomButton.Location = new System.Drawing.Point(335, 1);
            this.metroTextBoxEmailPara.CustomButton.Name = "";
            this.metroTextBoxEmailPara.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmailPara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmailPara.CustomButton.TabIndex = 1;
            this.metroTextBoxEmailPara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmailPara.CustomButton.UseSelectable = true;
            this.metroTextBoxEmailPara.CustomButton.Visible = false;
            this.metroTextBoxEmailPara.Lines = new string[0];
            this.metroTextBoxEmailPara.Location = new System.Drawing.Point(64, 50);
            this.metroTextBoxEmailPara.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxEmailPara.MaxLength = 32767;
            this.metroTextBoxEmailPara.Multiline = true;
            this.metroTextBoxEmailPara.Name = "metroTextBoxEmailPara";
            this.metroTextBoxEmailPara.PasswordChar = '\0';
            this.metroTextBoxEmailPara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmailPara.SelectedText = "";
            this.metroTextBoxEmailPara.SelectionLength = 0;
            this.metroTextBoxEmailPara.SelectionStart = 0;
            this.metroTextBoxEmailPara.ShortcutsEnabled = true;
            this.metroTextBoxEmailPara.Size = new System.Drawing.Size(357, 23);
            this.metroTextBoxEmailPara.TabIndex = 6;
            this.metroTextBoxEmailPara.UseSelectable = true;
            this.metroTextBoxEmailPara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmailPara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEmailDe
            // 
            // 
            // 
            // 
            this.metroTextBoxEmailDe.CustomButton.Image = null;
            this.metroTextBoxEmailDe.CustomButton.Location = new System.Drawing.Point(335, 1);
            this.metroTextBoxEmailDe.CustomButton.Name = "";
            this.metroTextBoxEmailDe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmailDe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmailDe.CustomButton.TabIndex = 1;
            this.metroTextBoxEmailDe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmailDe.CustomButton.UseSelectable = true;
            this.metroTextBoxEmailDe.CustomButton.Visible = false;
            this.metroTextBoxEmailDe.Lines = new string[0];
            this.metroTextBoxEmailDe.Location = new System.Drawing.Point(64, 21);
            this.metroTextBoxEmailDe.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxEmailDe.MaxLength = 32767;
            this.metroTextBoxEmailDe.Multiline = true;
            this.metroTextBoxEmailDe.Name = "metroTextBoxEmailDe";
            this.metroTextBoxEmailDe.PasswordChar = '\0';
            this.metroTextBoxEmailDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmailDe.SelectedText = "";
            this.metroTextBoxEmailDe.SelectionLength = 0;
            this.metroTextBoxEmailDe.SelectionStart = 0;
            this.metroTextBoxEmailDe.ShortcutsEnabled = true;
            this.metroTextBoxEmailDe.Size = new System.Drawing.Size(357, 23);
            this.metroTextBoxEmailDe.TabIndex = 5;
            this.metroTextBoxEmailDe.UseSelectable = true;
            this.metroTextBoxEmailDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmailDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBoxCredencialSenha);
            this.groupBox2.Controls.Add(this.metroTextBoxCredencialEmail);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciais de envio";
            // 
            // metroTextBoxCredencialSenha
            // 
            // 
            // 
            // 
            this.metroTextBoxCredencialSenha.CustomButton.Image = null;
            this.metroTextBoxCredencialSenha.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.metroTextBoxCredencialSenha.CustomButton.Name = "";
            this.metroTextBoxCredencialSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCredencialSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCredencialSenha.CustomButton.TabIndex = 1;
            this.metroTextBoxCredencialSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCredencialSenha.CustomButton.UseSelectable = true;
            this.metroTextBoxCredencialSenha.CustomButton.Visible = false;
            this.metroTextBoxCredencialSenha.Lines = new string[0];
            this.metroTextBoxCredencialSenha.Location = new System.Drawing.Point(79, 62);
            this.metroTextBoxCredencialSenha.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxCredencialSenha.MaxLength = 32767;
            this.metroTextBoxCredencialSenha.Multiline = true;
            this.metroTextBoxCredencialSenha.Name = "metroTextBoxCredencialSenha";
            this.metroTextBoxCredencialSenha.PasswordChar = '*';
            this.metroTextBoxCredencialSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCredencialSenha.SelectedText = "";
            this.metroTextBoxCredencialSenha.SelectionLength = 0;
            this.metroTextBoxCredencialSenha.SelectionStart = 0;
            this.metroTextBoxCredencialSenha.ShortcutsEnabled = true;
            this.metroTextBoxCredencialSenha.Size = new System.Drawing.Size(336, 23);
            this.metroTextBoxCredencialSenha.TabIndex = 8;
            this.metroTextBoxCredencialSenha.UseSelectable = true;
            this.metroTextBoxCredencialSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCredencialSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxCredencialEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxCredencialEmail.CustomButton.Image = null;
            this.metroTextBoxCredencialEmail.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.metroTextBoxCredencialEmail.CustomButton.Name = "";
            this.metroTextBoxCredencialEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCredencialEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCredencialEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxCredencialEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCredencialEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxCredencialEmail.CustomButton.Visible = false;
            this.metroTextBoxCredencialEmail.Lines = new string[0];
            this.metroTextBoxCredencialEmail.Location = new System.Drawing.Point(79, 28);
            this.metroTextBoxCredencialEmail.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.metroTextBoxCredencialEmail.MaxLength = 32767;
            this.metroTextBoxCredencialEmail.Multiline = true;
            this.metroTextBoxCredencialEmail.Name = "metroTextBoxCredencialEmail";
            this.metroTextBoxCredencialEmail.PasswordChar = '\0';
            this.metroTextBoxCredencialEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCredencialEmail.SelectedText = "";
            this.metroTextBoxCredencialEmail.SelectionLength = 0;
            this.metroTextBoxCredencialEmail.SelectionStart = 0;
            this.metroTextBoxCredencialEmail.ShortcutsEnabled = true;
            this.metroTextBoxCredencialEmail.Size = new System.Drawing.Size(336, 23);
            this.metroTextBoxCredencialEmail.TabIndex = 7;
            this.metroTextBoxCredencialEmail.UseSelectable = true;
            this.metroTextBoxCredencialEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCredencialEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 28);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 20);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "E-mail";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 65);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 20);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Senha";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "De";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 52);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 20);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Para";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 521);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Monitor de Ativos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.monitor.ResumeLayout(false);
            this.monitor.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.configuracao.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage monitor;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAtivo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRefVenda;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRefCompra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTileParar;
        private MetroFramework.Controls.MetroTile metroTileIniciar;
        private MetroFramework.Controls.MetroTabPage configuracao;
        private MetroFramework.Controls.MetroTile metroTileSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAPIKey;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSMTPPort;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSMTPHost;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmailPara;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmailDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCredencialSenha;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCredencialEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

