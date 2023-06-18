using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap
{
    public partial class MyGmap : UserControl
    {
        private GMapOverlay OverlayMarkers = new("OverlayMarkers");
        private GMapOverlay OverlayPolygons = new("OverlayPolygons");
        private GMapOverlay OverlayRoutes = new("OverlayRoutes");
        private GMapPolygon? polygon;
        private GMapRoute? route;
        private bool addNewPolygon = false;
        private bool addNewRoute = false;
        private Color activecolor = Color.Gainsboro;
        private Color pushedcolor = Color.Blue;

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
            Gmap.Overlays.Add(OverlayRoutes);
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
            ChangeBTN(sender, addNewPolygon);
            if (!addNewPolygon) return;
            polygon = new(new List<PointLatLng>(), $"Polygon {OverlayPolygons.Polygons.Count}");
            OverlayPolygons.Polygons.Add(polygon);
        }

        private void Gmap_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (addNewPolygon)
            {
                if (polygon == null) return;
                var point = polygon.Points.FirstOrDefault(x => Math.Abs(x.Lat - pointClick.Lat) < pointClick.Lat * 0.001 / Gmap.Zoom
                && Math.Abs(x.Lng - pointClick.Lng) < pointClick.Lat * 0.001 / Gmap.Zoom);
                if (point != null && point != PointLatLng.Empty)
                {
                    polygon.Points.Remove(point);
                    OverlayPolygons.Control.UpdatePolygonLocalPosition(polygon);
                    return;
                }
                polygon.Points.Add(pointClick);
                OverlayPolygons.Control.UpdatePolygonLocalPosition(polygon);
            }
            if (addNewRoute)
            {
                if (route == null) return;
                var point = route.Points.FirstOrDefault(x => Math.Abs(x.Lat - pointClick.Lat) < pointClick.Lat * 0.05 / Gmap.Zoom
                && Math.Abs(x.Lng - pointClick.Lng) < pointClick.Lat * 0.05 / Gmap.Zoom);
                if (point != null && point != PointLatLng.Empty)
                {
                    route.Points.Remove(point);
                    OverlayRoutes.Control.UpdateRouteLocalPosition(route);
                    return;
                }
                route.Points.Add(pointClick);
                OverlayRoutes.Control.UpdateRouteLocalPosition(route);
            }
        }

        private void BTNRoute_Click(object sender, EventArgs e)
        {
            addNewRoute = !addNewRoute;
            ChangeBTN(sender, addNewRoute);
            if (!addNewRoute) return;
            route = new(new List<PointLatLng>(), $"Route {OverlayRoutes.Routes.Count}");
            OverlayRoutes.Routes.Add(route);
        }

        private void ChangeBTN(object sender, bool flag)
        {
            var btn = sender as Button;
            if (btn == null) return;
            if (flag) btn.BackColor = pushedcolor;
            else btn.BackColor = activecolor;
        }
    }
}
