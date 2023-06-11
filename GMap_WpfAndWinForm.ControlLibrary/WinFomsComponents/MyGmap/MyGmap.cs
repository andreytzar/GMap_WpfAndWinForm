using GMap.NET.MapProviders;
using System;
using System.Windows.Forms;

namespace GMap_WpfAndWinForm.ControlLibrary.WinFomsComponents.MyGmap
{
    public partial class MyGmap : UserControl
    {
        public MyGmap()
        {
            InitializeComponent();
            CMBMapProviders.Items.AddRange(MyGmapHelper.GMapProviders);
            CMBMapProviders.SelectedIndex = 0;
            Gmap.Zoom = 8;
        }

        private void CMBMapProviders_SelectedValueChanged(object sender, EventArgs e)
        => Gmap.MapProvider = CMBMapProviders.SelectedItem as GMapProvider;

        private void BTNZoomPlus_Click(object sender, EventArgs e)
        => Gmap.Zoom++;

        private void BTNZoomMinus_Click(object sender, EventArgs e)
        => Gmap.Zoom--;
    }
}
