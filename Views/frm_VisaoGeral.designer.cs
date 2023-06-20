
namespace AppCaldeirasV2
{
    partial class frm_VisaoGeral
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAtualizacao = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_HoraAtual = new System.Windows.Forms.Timer(this.components);
            this.timer_Atualizao = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.caldeira01 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.caldeira02 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.caldeira03 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.caldeira04 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caldeira01)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caldeira02)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caldeira03)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caldeira04)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAtualizacao);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 70);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Última atualização";
            // 
            // lblAtualizacao
            // 
            this.lblAtualizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAtualizacao.AutoSize = true;
            this.lblAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualizacao.Location = new System.Drawing.Point(8, 28);
            this.lblAtualizacao.Name = "lblAtualizacao";
            this.lblAtualizacao.Size = new System.Drawing.Size(150, 22);
            this.lblAtualizacao.TabIndex = 2;
            this.lblAtualizacao.Text = "00/00/0000 00:00";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(847, 28);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(150, 22);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00/00/0000 00:00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard de Monitoramento de Caldeiras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer_HoraAtual
            // 
            this.timer_HoraAtual.Interval = 1000;
            this.timer_HoraAtual.Tick += new System.EventHandler(this.timer_HoraAtual_Tick);
            // 
            // timer_Atualizao
            // 
            this.timer_Atualizao.Interval = 15000;
            this.timer_Atualizao.Tick += new System.EventHandler(this.timer_Atualizao_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.caldeira01);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 239);
            this.panel4.TabIndex = 2;
            // 
            // caldeira01
            // 
            this.caldeira01.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.caldeira01.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.IndianRed;
            chartArea5.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.IndianRed;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.Brown;
            chartArea5.Name = "ChartArea1";
            this.caldeira01.ChartAreas.Add(chartArea5);
            this.caldeira01.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.caldeira01.Legends.Add(legend5);
            this.caldeira01.Location = new System.Drawing.Point(0, 0);
            this.caldeira01.Name = "caldeira01";
            series5.ChartArea = "ChartArea1";
            series5.LabelForeColor = System.Drawing.Color.Transparent;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.IndianRed;
            series5.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.caldeira01.Series.Add(series5);
            this.caldeira01.Size = new System.Drawing.Size(480, 239);
            this.caldeira01.TabIndex = 4;
            this.caldeira01.Text = "Chart_Pressao";
            this.caldeira01.Click += new System.EventHandler(this.caldeira01_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.caldeira02);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(500, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 239);
            this.panel5.TabIndex = 3;
            // 
            // caldeira02
            // 
            chartArea6.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.IndianRed;
            chartArea6.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.IndianRed;
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.Brown;
            chartArea6.Name = "ChartArea1";
            this.caldeira02.ChartAreas.Add(chartArea6);
            this.caldeira02.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.caldeira02.Legends.Add(legend6);
            this.caldeira02.Location = new System.Drawing.Point(0, 0);
            this.caldeira02.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.caldeira02.Name = "caldeira02";
            series6.ChartArea = "ChartArea1";
            series6.LabelForeColor = System.Drawing.Color.Transparent;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.IndianRed;
            series6.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.caldeira02.Series.Add(series6);
            this.caldeira02.Size = new System.Drawing.Size(480, 239);
            this.caldeira02.TabIndex = 6;
            this.caldeira02.Text = "Chart_Pressao";
            this.caldeira02.Click += new System.EventHandler(this.caldeira02_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.caldeira03);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 249);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 251);
            this.panel8.TabIndex = 6;
            // 
            // caldeira03
            // 
            chartArea7.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.IndianRed;
            chartArea7.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.IndianRed;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.Brown;
            chartArea7.Name = "ChartArea1";
            this.caldeira03.ChartAreas.Add(chartArea7);
            this.caldeira03.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.caldeira03.Legends.Add(legend7);
            this.caldeira03.Location = new System.Drawing.Point(0, 0);
            this.caldeira03.Margin = new System.Windows.Forms.Padding(5);
            this.caldeira03.Name = "caldeira03";
            series7.ChartArea = "ChartArea1";
            series7.LabelForeColor = System.Drawing.Color.Transparent;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.IndianRed;
            series7.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.caldeira03.Series.Add(series7);
            this.caldeira03.Size = new System.Drawing.Size(480, 251);
            this.caldeira03.TabIndex = 5;
            this.caldeira03.Text = "Chart_Pressao";
            this.caldeira03.Click += new System.EventHandler(this.caldeira03_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.caldeira04);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(500, 249);
            this.panel9.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(480, 251);
            this.panel9.TabIndex = 7;
            // 
            // caldeira04
            // 
            chartArea8.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.IndianRed;
            chartArea8.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.IndianRed;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.Brown;
            chartArea8.Name = "ChartArea1";
            this.caldeira04.ChartAreas.Add(chartArea8);
            this.caldeira04.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.caldeira04.Legends.Add(legend8);
            this.caldeira04.Location = new System.Drawing.Point(0, 0);
            this.caldeira04.Name = "caldeira04";
            series8.ChartArea = "ChartArea1";
            series8.LabelForeColor = System.Drawing.Color.Transparent;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.IndianRed;
            series8.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.caldeira04.Series.Add(series8);
            this.caldeira04.Size = new System.Drawing.Size(480, 251);
            this.caldeira04.TabIndex = 6;
            this.caldeira04.Text = "Chart_Pressao";
            this.caldeira04.Click += new System.EventHandler(this.caldeira04_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.88713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.11287F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 500);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // frm_VisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VisaoGeral";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos de Acompanhamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Metricas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caldeira01)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caldeira02)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caldeira03)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caldeira04)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAtualizacao;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer_HoraAtual;
        private System.Windows.Forms.Timer timer_Atualizao;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart caldeira01;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart caldeira02;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart caldeira03;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart caldeira04;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

