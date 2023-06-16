

using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Media;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap.MarkersPolygonsRoutes
{
    [Serializable]
    public class GmapMarkerDot : GMapMarker, ISerializable
    {
        public SolidBrush Brush { get; set; }
        public GmapMarkerDot(PointLatLng pos) : base(pos)
        {
            Size = new Size(15, 15);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
            Random random = new Random();
            Brush = new SolidBrush(System.Drawing.Color.FromArgb(255, (byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
            ToolTipMode = MarkerTooltipMode.Always;
            ToolTipText = $"{Position.Lat}\n{Position.Lng}";
        }
        public override void OnRender(Graphics g)
        {
            Rectangle rect = new Rectangle(LocalPosition, Size);
            g.FillEllipse(Brush, rect);
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        =>GetObjectData(info, context);
        
    }
}
