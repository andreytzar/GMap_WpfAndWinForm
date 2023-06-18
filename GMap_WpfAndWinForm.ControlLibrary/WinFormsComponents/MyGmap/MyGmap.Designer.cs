using System.Drawing;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap
{
    partial class MyGmap
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            PanelRight = new System.Windows.Forms.Panel();
            PanelLeft = new System.Windows.Forms.Panel();
            BTNPolygon = new System.Windows.Forms.Button();
            BTNAddMarker = new System.Windows.Forms.Button();
            PanelBottom = new System.Windows.Forms.Panel();
            TXTGmapStatus = new System.Windows.Forms.TextBox();
            PanelTop = new System.Windows.Forms.FlowLayoutPanel();
            CMBMapProviders = new System.Windows.Forms.ComboBox();
            BTNZoomPlus = new System.Windows.Forms.Button();
            BTNZoomMinus = new System.Windows.Forms.Button();
            Gmap = new GMap.NET.WindowsForms.GMapControl();
            panel1.SuspendLayout();
            PanelLeft.SuspendLayout();
            PanelBottom.SuspendLayout();
            PanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelRight);
            panel1.Controls.Add(PanelLeft);
            panel1.Controls.Add(PanelBottom);
            panel1.Controls.Add(PanelTop);
            panel1.Controls.Add(Gmap);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 289);
            panel1.TabIndex = 0;
            // 
            // PanelRight
            // 
            PanelRight.BackColor = Color.FromArgb(0, 0, 0, 0);
            PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            PanelRight.Location = new Point(619, 23);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(23, 243);
            PanelRight.TabIndex = 4;
            // 
            // PanelLeft
            // 
            PanelLeft.BackColor = Color.FromArgb(0, 0, 0, 0);
            PanelLeft.Controls.Add(BTNPolygon);
            PanelLeft.Controls.Add(BTNAddMarker);
            PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            PanelLeft.Location = new Point(0, 23);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(23, 243);
            PanelLeft.TabIndex = 2;
            // 
            // BTNPolygon
            // 
            BTNPolygon.BackColor = SystemColors.Control;
            BTNPolygon.Location = new Point(0, 23);
            BTNPolygon.Margin = new System.Windows.Forms.Padding(0);
            BTNPolygon.Name = "BTNPolygon";
            BTNPolygon.Size = new Size(23, 23);
            BTNPolygon.TabIndex = 1;
            BTNPolygon.Text = "P";
            BTNPolygon.UseVisualStyleBackColor = false;
            BTNPolygon.Click += BTNPolygon_Click;
            // 
            // BTNAddMarker
            // 
            BTNAddMarker.BackColor = SystemColors.Control;
            BTNAddMarker.Location = new Point(0, 0);
            BTNAddMarker.Margin = new System.Windows.Forms.Padding(0);
            BTNAddMarker.Name = "BTNAddMarker";
            BTNAddMarker.Size = new Size(23, 23);
            BTNAddMarker.TabIndex = 0;
            BTNAddMarker.Text = "M";
            BTNAddMarker.UseVisualStyleBackColor = false;
            BTNAddMarker.Click += BTNAddMarker_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.BackColor = Color.FromArgb(0, 0, 0, 0);
            PanelBottom.Controls.Add(TXTGmapStatus);
            PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 266);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(642, 23);
            PanelBottom.TabIndex = 3;
            // 
            // TXTGmapStatus
            // 
            TXTGmapStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            TXTGmapStatus.Location = new Point(0, 0);
            TXTGmapStatus.Margin = new System.Windows.Forms.Padding(0);
            TXTGmapStatus.Name = "TXTGmapStatus";
            TXTGmapStatus.Size = new Size(642, 23);
            TXTGmapStatus.TabIndex = 0;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(0, 0, 0, 0);
            PanelTop.Controls.Add(CMBMapProviders);
            PanelTop.Controls.Add(BTNZoomPlus);
            PanelTop.Controls.Add(BTNZoomMinus);
            PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(642, 23);
            PanelTop.TabIndex = 1;
            // 
            // CMBMapProviders
            // 
            CMBMapProviders.Dock = System.Windows.Forms.DockStyle.Left;
            CMBMapProviders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CMBMapProviders.FormattingEnabled = true;
            CMBMapProviders.Location = new Point(0, 0);
            CMBMapProviders.Margin = new System.Windows.Forms.Padding(0);
            CMBMapProviders.Name = "CMBMapProviders";
            CMBMapProviders.Size = new Size(121, 23);
            CMBMapProviders.TabIndex = 0;
            CMBMapProviders.SelectedValueChanged += CMBMapProviders_SelectedValueChanged;
            // 
            // BTNZoomPlus
            // 
            BTNZoomPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            BTNZoomPlus.Location = new Point(124, 0);
            BTNZoomPlus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            BTNZoomPlus.Name = "BTNZoomPlus";
            BTNZoomPlus.Size = new Size(23, 23);
            BTNZoomPlus.TabIndex = 1;
            BTNZoomPlus.Text = "+";
            BTNZoomPlus.UseVisualStyleBackColor = true;
            BTNZoomPlus.Click += BTNZoomPlus_Click;
            // 
            // BTNZoomMinus
            // 
            BTNZoomMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            BTNZoomMinus.Location = new Point(150, 0);
            BTNZoomMinus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            BTNZoomMinus.Name = "BTNZoomMinus";
            BTNZoomMinus.Size = new Size(23, 23);
            BTNZoomMinus.TabIndex = 2;
            BTNZoomMinus.Text = "-";
            BTNZoomMinus.UseVisualStyleBackColor = true;
            BTNZoomMinus.Click += BTNZoomMinus_Click;
            // 
            // Gmap
            // 
            Gmap.Bearing = 0F;
            Gmap.CanDragMap = true;
            Gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            Gmap.EmptyTileColor = Color.Navy;
            Gmap.GrayScaleMode = false;
            Gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            Gmap.LevelsKeepInMemory = 5;
            Gmap.Location = new Point(0, 0);
            Gmap.MarkersEnabled = true;
            Gmap.MaxZoom = 25;
            Gmap.MinZoom = 2;
            Gmap.MouseWheelZoomEnabled = true;
            Gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Gmap.Name = "Gmap";
            Gmap.NegativeMode = false;
            Gmap.PolygonsEnabled = true;
            Gmap.RetryLoadTile = 0;
            Gmap.RoutesEnabled = true;
            Gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            Gmap.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            Gmap.ShowTileGridLines = false;
            Gmap.Size = new Size(642, 289);
            Gmap.TabIndex = 0;
            Gmap.Zoom = 0D;
            Gmap.OnMapClick += Gmap_OnMapClick;
            Gmap.OnPositionChanged += Gmap_OnPositionChanged;
            Gmap.OnMapZoomChanged += Gmap_OnMapZoomChanged;
            // 
            // MyGmap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MyGmap";
            Size = new Size(642, 289);
            panel1.ResumeLayout(false);
            PanelLeft.ResumeLayout(false);
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            PanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PanelTop;
        private GMap.NET.WindowsForms.GMapControl Gmap;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.ComboBox CMBMapProviders;
        private System.Windows.Forms.Button BTNZoomPlus;
        private System.Windows.Forms.Button BTNZoomMinus;
        private System.Windows.Forms.TextBox TXTGmapStatus;
        private System.Windows.Forms.Button BTNAddMarker;
        private System.Windows.Forms.Button BTNPolygon;
    }
}
