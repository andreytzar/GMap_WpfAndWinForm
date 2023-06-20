using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        private IMovable? _movable = null;
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
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom} Scale:{GetScale()}";

        private void Gmap_OnPositionChanged(PointLatLng point)
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat.ToString().Replace(',', '.')}, {Gmap.Position.Lng.ToString().Replace(',', '.')} x{Gmap.Zoom} Scale:{GetScale()}";

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

        private void BTNRoute_Click(object sender, EventArgs e)
        {
            addNewRoute = !addNewRoute;
            ChangeBTN(sender, addNewRoute);
            if (!addNewRoute) return;
            route = new(new List<PointLatLng>(), $"Route {OverlayRoutes.Routes.Count}");
            OverlayRoutes.Routes.Add(route);
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

        private void ChangeBTN(object sender, bool flag)
        {
            var btn = sender as Button;
            if (btn == null) return;
            if (flag) btn.BackColor = pushedcolor;
            else btn.BackColor = activecolor;
        }

        private void Gmap_MouseMove(object sender, MouseEventArgs e)
        {
            if (_movable != null && e.Button == MouseButtons.Left)
                _movable.SetNewPosition(new Point(e.X, e.Y));
        }

        private void BTNAddRulerRoute_Click(object sender, EventArgs e)
        {
            Point start = new Point((int)(Gmap.Width / 2 - Gmap.Width * 0.2), (int)(Gmap.Height / 2 - Gmap.Height * 0.2));
            Point end = new Point((int)(Gmap.Width / 2 + Gmap.Width * 0.2), (int)(Gmap.Height / 2 + Gmap.Height * 0.2));
            GmapRulerRoute route = new($"Ruler {OverlayRoutes.Routes.Count}",
                OverlayRoutes, Gmap.FromLocalToLatLng(start.X, start.Y),
                Gmap.FromLocalToLatLng(end.X, end.Y));
        }

        private void Gmap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) _movable = null;
        }

        private void Gmap_MouseDown(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
            {
                List<IMovable> list = new();
                foreach(var overlay in Gmap.Overlays)
                {
                    list.AddRange(overlay.Markers.Where(x => x is IMovable && x.IsMouseOver)
                        .Select(x => x as IMovable));
                }
                _movable = list.FirstOrDefault(x => x != null);
            }
        }

        public double GetScale()
        {
            return Gmap.MapProvider.Projection.GetGroundResolution((int)Gmap.Zoom, Gmap.Position.Lat);
        }
    }
}
