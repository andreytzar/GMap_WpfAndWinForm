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
    [Serializable]
    public class GmapRulerRouteMarker:GMapMarker, IMovable, ISerializable
    {
        public GMapRoute GMapRoute { get; init; }
        public GmapRulerRouteMarker(PointLatLng pos, GMapRoute gMapRoute, GMapOverlay overlay) : base(pos)
        {
            Size = new(6, 6);
            Offset=new Point(-3, -3);
            GMapRoute = gMapRoute;
            overlay.Markers.Add(this);
               ToolTipMode = MarkerTooltipMode.Always;
        }
        public override void OnRender(Graphics g)
        {
            Rectangle rect = new Rectangle(LocalPosition, Size);
            g.DrawEllipse(GMapRoute.DefaultStroke, rect);
            ToolTipText = $"Distance:\n{GMapRoute.Distance}";
        }

        public void SetNewPosition(Point newPoint)
        {
            if (this.Overlay?.Control == null) return;
            var newpos= Overlay.Control.FromLocalToLatLng(newPoint.X, newPoint.Y);
            var index = GMapRoute.Points.IndexOf(Position);
            if (index>-1) GMapRoute.Points[index]=newpos;
            Position = newpos;
            Overlay.Control.UpdateMarkerLocalPosition(this);
            Overlay.Control.UpdateRouteLocalPosition(GMapRoute);
        }


        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        => GetObjectData(info, context);
    }
}
