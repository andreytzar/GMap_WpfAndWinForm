using GMap.NET;
using GMap.NET.WindowsForms;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes
{
    public class GmapRulerRoute : GMapRoute
    {
        public GmapRulerRoute(string name, GMapOverlay overlay, PointLatLng start, PointLatLng end) : base(name)
        {
            GmapRulerRouteMarker MarkerStart = new(start, this, overlay);
            GmapRulerRouteMarker MarkerEnd = new(end, this, overlay);
            Points.Add(MarkerStart.Position);
            Points.Add(MarkerEnd.Position);
            overlay.Routes.Add(this);
        }

    }
}
