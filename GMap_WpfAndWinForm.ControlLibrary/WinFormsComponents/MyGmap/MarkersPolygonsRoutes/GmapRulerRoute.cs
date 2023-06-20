using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes
{
    public class GmapRulerRoute : GMapRoute
    {
        //public GmapRulerRouteMarker MarkerStart { get; init; }
        //public GmapRulerRouteMarker MarkerEnd { get; init; }
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
