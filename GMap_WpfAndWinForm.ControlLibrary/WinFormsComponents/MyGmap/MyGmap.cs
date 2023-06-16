using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes;
using System;
using System.Windows.Forms;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap
{
    public partial class MyGmap : UserControl
    {
        GMapOverlay OverlayMarkers = new("OverlayMarkers");
        public MyGmap()
        {
            InitializeComponent();
            Gmap.DragButton = MouseButtons.Left;
            CMBMapProviders.Items.AddRange(MyGmapHelper.GMapProviders);
            CMBMapProviders.SelectedIndex = 10;
            Gmap.DragButton = MouseButtons.Left;
            Gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            Gmap.Zoom = 8;
            PanelBottom.Parent = PanelLeft.Parent = PanelTop.Parent = PanelRight.Parent = Gmap;
            Gmap.Overlays.Add(OverlayMarkers);
        }

        private void CMBMapProviders_SelectedValueChanged(object sender, EventArgs e)
        => Gmap.MapProvider = CMBMapProviders.SelectedItem as GMapProvider;

        private void BTNZoomPlus_Click(object sender, EventArgs e)
        => Gmap.Zoom++;

        private void BTNZoomMinus_Click(object sender, EventArgs e)
        => Gmap.Zoom--;

        private void Gmap_OnMapZoomChanged()
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom}";

        private void Gmap_OnPositionChanged(GMap.NET.PointLatLng point)
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom}";

        private void Gmap_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            var marker = new GmapMarkerDot(Gmap.Position);
            OverlayMarkers.Markers.Add(marker);
        }
    }
}
