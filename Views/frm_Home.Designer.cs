namespace AppCaldeirasV2
{
    partial class frm_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btCaldeira03 = new MetroFramework.Controls.MetroTile();
            this.btCaldeira04 = new MetroFramework.Controls.MetroTile();
            this.btMonitoramento = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btCaldeira01 = new MetroFramework.Controls.MetroTile();
            this.btCaldeira02 = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sistema integrado de gerenciamento e acompanhamento de caldeiras industriais.";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1269, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "© 2023 Unisales - Todos os direitos reservados.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desenvolvido por: Ravel, Marcos, Wasny, Jose, Glayton e Jefferson";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.9855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Controls.Add(this.metroTile2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroTile1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btMonitoramento, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 127);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1195, 406);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // metroTile2
            // 
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile2.ForeColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(768, 0);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(131, 406);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Usuarios";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = global::AppCaldeirasV2.Properties.Resources.adicionar_usuario;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseMnemonic = false;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(422, 0);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(339, 406);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Cadastrar Caldeira";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = global::AppCaldeirasV2.Properties.Resources.adicionar;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseMnemonic = false;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btCaldeira03, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btCaldeira04, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1037, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(158, 406);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btCaldeira03
            // 
            this.btCaldeira03.CustomForeColor = true;
            this.btCaldeira03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCaldeira03.ForeColor = System.Drawing.Color.White;
            this.btCaldeira03.Location = new System.Drawing.Point(7, 0);
            this.btCaldeira03.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btCaldeira03.Name = "btCaldeira03";
            this.btCaldeira03.Size = new System.Drawing.Size(151, 162);
            this.btCaldeira03.Style = MetroFramework.MetroColorStyle.Teal;
            this.btCaldeira03.TabIndex = 5;
            this.btCaldeira03.Text = "Caldeira 03";
            this.btCaldeira03.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCaldeira03.TileImage = global::AppCaldeirasV2.Properties.Resources.caldeira__5_;
            this.btCaldeira03.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCaldeira03.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btCaldeira03.UseMnemonic = false;
            this.btCaldeira03.UseTileImage = true;
            this.btCaldeira03.Click += new System.EventHandler(this.btCaldeira03_Click_1);
            // 
            // btCaldeira04
            // 
            this.btCaldeira04.CustomForeColor = true;
            this.btCaldeira04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCaldeira04.ForeColor = System.Drawing.Color.White;
            this.btCaldeira04.Location = new System.Drawing.Point(7, 169);
            this.btCaldeira04.Margin = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.btCaldeira04.Name = "btCaldeira04";
            this.btCaldeira04.Size = new System.Drawing.Size(151, 237);
            this.btCaldeira04.Style = MetroFramework.MetroColorStyle.Silver;
            this.btCaldeira04.TabIndex = 6;
            this.btCaldeira04.Text = "Caldeira 04";
            this.btCaldeira04.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCaldeira04.TileImage = global::AppCaldeirasV2.Properties.Resources.caldeira__5_;
            this.btCaldeira04.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCaldeira04.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btCaldeira04.UseMnemonic = false;
            this.btCaldeira04.UseTileImage = true;
            this.btCaldeira04.Click += new System.EventHandler(this.btCaldeira04_Click_1);
            // 
            // btMonitoramento
            // 
            this.btMonitoramento.CustomForeColor = true;
            this.btMonitoramento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMonitoramento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btMonitoramento.Location = new System.Drawing.Point(0, 0);
            this.btMonitoramento.Margin = new System.Windows.Forms.Padding(0);
            this.btMonitoramento.Name = "btMonitoramento";
            this.btMonitoramento.Size = new System.Drawing.Size(415, 406);
            this.btMonitoramento.Style = MetroFramework.MetroColorStyle.Teal;
            this.btMonitoramento.TabIndex = 0;
            this.btMonitoramento.Text = "Monitoramento Geral";
            this.btMonitoramento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btMonitoramento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btMonitoramento.TileImage = global::AppCaldeirasV2.Properties.Resources.monitoramento;
            this.btMonitoramento.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btMonitoramento.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btMonitoramento.UseTileImage = true;
            this.btMonitoramento.Click += new System.EventHandler(this.btMonitoramento_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btCaldeira01, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btCaldeira02, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(899, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(138, 406);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btCaldeira01
            // 
            this.btCaldeira01.CustomForeColor = true;
            this.btCaldeira01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCaldeira01.ForeColor = System.Drawing.Color.White;
            this.btCaldeira01.Location = new System.Drawing.Point(7, 0);
            this.btCaldeira01.Margin = new System.Windows.Forms.Padding(7, 0, 0, 7);
            this.btCaldeira01.Name = "btCaldeira01";
            this.btCaldeira01.Size = new System.Drawing.Size(131, 236);
            this.btCaldeira01.Style = MetroFramework.MetroColorStyle.Silver;
            this.btCaldeira01.TabIndex = 3;
            this.btCaldeira01.Text = "Caldeira 01";
            this.btCaldeira01.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCaldeira01.TileImage = global::AppCaldeirasV2.Properties.Resources.caldeira__5_;
            this.btCaldeira01.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCaldeira01.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btCaldeira01.UseMnemonic = false;
            this.btCaldeira01.UseTileImage = true;
            this.btCaldeira01.Click += new System.EventHandler(this.btCaldeira01_Click);
            // 
            // btCaldeira02
            // 
            this.btCaldeira02.CustomForeColor = true;
            this.btCaldeira02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCaldeira02.ForeColor = System.Drawing.Color.White;
            this.btCaldeira02.Location = new System.Drawing.Point(7, 243);
            this.btCaldeira02.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btCaldeira02.Name = "btCaldeira02";
            this.btCaldeira02.Size = new System.Drawing.Size(131, 163);
            this.btCaldeira02.Style = MetroFramework.MetroColorStyle.Teal;
            this.btCaldeira02.TabIndex = 4;
            this.btCaldeira02.Text = "Caldeira 02";
            this.btCaldeira02.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCaldeira02.TileImage = global::AppCaldeirasV2.Properties.Resources.caldeira__5_;
            this.btCaldeira02.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCaldeira02.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btCaldeira02.UseMnemonic = false;
            this.btCaldeira02.UseTileImage = true;
            this.btCaldeira02.Click += new System.EventHandler(this.btCaldeira02_Click_1);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Home";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Sistema integrado de Gestão de Caldeiras";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btMonitoramento;
        private MetroFramework.Controls.MetroTile btCaldeira01;
        private MetroFramework.Controls.MetroTile btCaldeira02;
        private MetroFramework.Controls.MetroTile btCaldeira03;
        private MetroFramework.Controls.MetroTile btCaldeira04;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

