using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap
{
    public partial class MyGmap : UserControl
    {
        private GMapOverlay OverlayMarkers = new("OverlayMarkers");
        private GMapOverlay OverlayPolygons = new("OverlayPolygons");
        private GMapPolygon? polygon;
        private bool addNewPolygon = false;
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
            Gmap.Overlays.Add(OverlayPolygons);
        }

        private void CMBMapProviders_SelectedValueChanged(object sender, EventArgs e)
        => Gmap.MapProvider = CMBMapProviders.SelectedItem as GMapProvider;

        private void BTNZoomPlus_Click(object sender, EventArgs e)
        => Gmap.Zoom++;

        private void BTNZoomMinus_Click(object sender, EventArgs e)
        => Gmap.Zoom--;

        private void Gmap_OnMapZoomChanged()
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom}";

        private void Gmap_OnPositionChanged(PointLatLng point)
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom}";

        private void BTNAddMarker_Click(object sender, EventArgs e)
        => OverlayMarkers.Markers.Add(new GmapMarkerDot(Gmap.Position));

        private void BTNPolygon_Click(object sender, EventArgs e)
        {
            addNewPolygon = !addNewPolygon;
            if (!addNewPolygon) return;
            polygon = new(new List<PointLatLng>(), $"Polygon {OverlayPolygons.Polygons.Count}");
            OverlayPolygons.Polygons.Add(polygon);
            
        }

        private void Gmap_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        { 
            
            if (e.Button == MouseButtons.Right)
                            addNewPolygon= false;

            if (addNewPolygon) 
            {
                if (polygon == null) return;
                var point=polygon.Points.FirstOrDefault(x=>Math.Abs(x.Lat-pointClick.Lat)< pointClick.Lat*0.001/Gmap.Zoom 
                && Math.Abs(x.Lng-pointClick.Lng)< pointClick.Lat*0.001/ Gmap.Zoom); 
                if  (point!=null && point!=PointLatLng.Empty)
                {
                    polygon.Points.Remove(point);
                    OverlayPolygons.Control.UpdatePolygonLocalPosition(polygon);
                    return;
                }
                polygon.Points.Add(pointClick);
                OverlayPolygons.Control.UpdatePolygonLocalPosition(polygon);
            }


        }
    }
}
