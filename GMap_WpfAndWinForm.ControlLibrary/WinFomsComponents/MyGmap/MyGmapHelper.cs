using GMap.NET.MapProviders;


namespace GMap_WpfAndWinForm.ControlLibrary.WinFomsComponents.MyGmap
{
    public static class MyGmapHelper
    {
        public static GMapProvider[] GMapProviders = new GMapProvider[]
        {
        ArcGIS_World_Physical_MapProvider.Instance,
        ArcGIS_World_Shaded_Relief_MapProvider.Instance,ArcGIS_World_Street_MapProvider.Instance, ArcGIS_World_Terrain_Base_MapProvider.Instance,
        ArcGIS_World_Topo_MapProvider.Instance,BingHybridMapProvider.Instance,BingMapProvider.Instance,BingOSMapProvider.Instance,
        BingSatelliteMapProvider.Instance,GoogleHybridMapProvider.Instance,GoogleMapProvider.Instance,GoogleSatelliteMapProvider.Instance,
        GoogleTerrainMapProvider.Instance,OpenCycleMapProvider.Instance,
        OpenCycleTransportMapProvider.Instance, OpenSeaMapHybridProvider.Instance, OpenStreet4UMapProvider.Instance,
        OpenStreetMapProvider.Instance,UMPMapProvider.Instance,WikiMapiaMapProvider.Instance
        };

    }
}
