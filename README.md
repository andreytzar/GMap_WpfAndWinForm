https://www.linkedin.com/in/andrey-tzarkov/  
https://github.com/andreytzar/GMap_WpfAndWinForm

��������� ����:  
 - [�����](https://www.linkedin.com/pulse/%D0%BC%D0%B0%D0%BF%D0%B0-gmapnet-%D1%83-%D0%B7%D0%B0%D1%81%D1%82%D0%BE%D1%81%D1%83%D0%BD%D0%BA%D0%B0%D1%85-c-wpfnet-part1-%D0%B0%D0%BD%D0%B4%D1%80%D1%96%D0%B9-%D1%86%D0%B0%D1%80%D0%BA%D0%BE%D0%B2)  
 - [���� �� ��������� �������](https://www.linkedin.com/pulse/%D0%BC%D0%B0%D0%BF%D0%B0-gmapnet-%D1%83-%D0%B7%D0%B0%D1%81%D1%82%D0%BE%D1%81%D1%83%D0%BD%D0%BA%D0%B0%D1%85-c-wpfnet-%D1%88%D0%B0%D1%80%D0%B8-%D0%BC%D0%B0%D0%BF%D0%B8-%D1%81%D1%82%D0%B2%D0%BE%D1%80%D0%B5%D0%BD%D0%BD%D1%8F-%D0%B0%D0%BD%D0%B4%D1%80%D1%96%D0%B9-%D1%86%D0%B0%D1%80%D0%BA%D0%BE%D0%B2)

# GMap_WpfAndWinForm
��� ������ ��������� ���������� � ������������� ���� GMap.NET (https://github.com/judero01col/GMap.NET).  
����� ������ ��������� ������������ ���������� WinForms � �������� ���������� WPF.NET.  
��� ���� �����������, �� ��������� ����������. �� ���������� � ������� ������.

## ������� 1. ��������� ������. ����� ������������ �������. ������������ ������. ������� �������� ����.
---
###	��������� ������:
---
 - ������� ����� ������ � ������ �GMap_WpfAndWinForm�
 - �� ������ ������� ����� ������ �GMap_WpfAndWinForm� �� �������� ����������� WPF (���������� WPF.NET)�.  
����� ������� ���� ����, ���� ���. �� ���� �������� ������, �� ����� ������ ����� ��������� �� ����� �������.  
 - �� ������ ������� ����� ������ �GMap_WpfAndWinForm.ControlLibrary� �� �������� ���������� ����������� �������� ��������� �� ���������� WPF.NET (����������)�.  
������ �������� ���� ������ ������� ����������, �� ���� ��������������� �������� ������. � ��� �������� ������ �������� WPF �� WinForms ������� ����������.
###	����� ������������ �������:
---
������� �������� �� �������� ������������ WPF.NET. ��� GMap.NET ������ ����� ����������� ���� � ����� GMap.NET.WinForms, ��� �� �������, ��������, ���������� ������ �� ����. ��� ������ ��������� ������������ WinForms � �������� WPF.NET, � ������ ������� � ������ �PropertyGroup�, �������: 
```
<UseWindowsForms>true</UseWindowsForms>
```
��� � ������������ ������� �������� ���������������� WinForms � ����� ������.  
� ������ �GMap_WpfAndWinForm� ������� ��������� �� ������ �GMap_WpfAndWinForm.ControlLibrary�.  
```
  <ItemGroup>
    <ProjectReference Include="..\GMap_WpfAndWinForm.ControlLibrary\GMap_WpfAndWinForm.ControlLibrary.csproj" />
  </ItemGroup>
```
### ������������ ������ NuGet.  
---
� ������ �GMap_WpfAndWinForm.ControlLibrary�, ��������� ����� NuGet �GMap.NET.WinForms�, ����� Jurgen De Leon Rodriguez (https://github.com/judero01col/GMap.NET).  
������ �GMap_WpfAndWinForm.ControlLibrary� ���� ������ ���� GMap.Net, ��� ����� ������������ ���������� ���������� ���� ���� �������� ���� � ����� ������.
###	������� �������� ����.
---
� ������ �GMap_WpfAndWinForm.ControlLibrary� ������� �������� ���� (����):
 - WinFormsComponents.  
������ ���� ������ �� ���������� WinFoms. ���� GMap.NET.WinForms, ���� �������� � ����� �������.
 - WinFormsComponents.MyGmap. �� �������� WinFomsComponents ������� MyGmap. � ����� ������� ���� �������� ��������� ��������� �����������- ���� �GMap.NET.WinForms�.  
 - WinFormsComponents.MyGmap.MarkersPolygonsRoutes. �� MyGmap ������� ������ MarkersPolygonsRoutes. � ����� ������� ������ ������� �������, ��������, �������.  
## ������� 2. ������� �������� ��������� ����������� �MyGmap�
---
� ������ �GMap_WpfAndWinForm.ControlLibrary�, � ������� �WinFomsComponents.MyGmap�, ������� ����� ������� ��������� ����������� Windows Forms, � ������ �MyGmap�. �� ���� ������ ���������� ���������� ����.
 - � ����������� �������� ����������� �MyGmap�, ������� ������� ����������:
	- GMap.NET.WindowsForms.GMapControl, ����� Gmap, ����������: Dock = DockStyle.Fill, DisableFocusOnMouseEnter = true;
	- ������� 4 ����� � ������� PanelLeft, PanelTop, PanelRight, PanelBottom. ��������� BackColor = Color.FromArgb(0, 0, 0, 0), Parent = Gmap, �� ��������� ���������� Dock, �������� � Left, Right, Bottom �� Top. ������ ��� ������ ����� ��������� �������� � 23.
 - ������� �������� ��������� ���� MyGmapHelper.cs, ��� ���� ���� ������ ������� ���������� ����.
  
��������� ��������� ��� �������  ��������������� � ��������� ������ �GMap_WpfAndWinForm�. ��� ����� � ������ �GMap_WpfAndWinForm�, � XAML ������� ��������� ���� �MainWindow.xaml�, ������� ������ ����:
```
xmlns:map="clr-namespace:GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap;assembly=GMap_WpfAndWinForm.ControlLibrary"
```
�� ������� ��� ��������� ����, ��������� � WindowsFormsHost
```
    <Grid>
        <WindowsFormsHost>
            <map:MyGmap/>
        </WindowsFormsHost>
    </Grid>
```
ϳ�������� ���������, ����� ���������� ����������� �� ��������� ������.
## ������� 3. ������ ���������� �Gmap�
�������� ������������:
 - Gmap.MarkersEnabled = true � ��������� �������. �������� ��������, ����, �������, �������� ��� �ᒺ��� �� ���.
 - Gmap.PolygonsEnabled = true � �������� �������, �� ��, ���������� ����, �� ����.
 - Gmap.RoutesEnabled = true � �������� ���� ���� ��������, ������������ ������.
 - Gmap.MaxZoom = 18, Gmap.MinZoom = 2 ����������� �� �������� ��������� ����.
 - Gmap.MouseWheelZoomEnabled = true � �������� �������� ��� �������� ���� ������� ��������� ����.
 - Gmap.MouseWheelZoomType = MousePositionWithoutCenter � ����� ����������� ����, ��� ��������� ������.
 - Gmap.DragButton = MouseButtons.Left � ������ ����� ��� ��������� ��� ���� ���������� ��������� ����.   
---
������ ������������ �� ����������:
 - Gmap.MapProvider - ��������� (���) ����, ��� ���� ����������������� � ��������� (Google, Bing, OpenStreetMap �� ����).
 - Gmap.Zoom � ������� ��������� (���) ����.
 - Gmap.Position � ������ ���������� ������ ����.
## ������� 4. ����� ���������� ��� �����䳿 � �Gmap�
�������� ��������� ��� ������ ���������� ����. ��� �����:
 - �� ����� �MyGmapHelper.cs� ������� ��������� ����� ����������
```
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
```
 - � ���������� ����������� ���������� �MyGmap� ������� �� PanelTop ����� ComboBox (Name=�CMBMapProviders�), 2 ������ (Name=� BTNZoomPlus�, Name=� BTNZoomMinus�). ������� ����� CMBMapProviders CMBMapProviders_SelectedValueChanged, �� ������ OnClick ������ ����:
```
        private void CMBMapProviders_SelectedValueChanged(object sender, EventArgs e)
        =>Gmap.MapProvider = CMBMapProviders.SelectedItem as GMapProvider;

        private void BTNZoomPlus_Click(object sender, EventArgs e)
        => Gmap.Zoom++;

        private void BTNZoomMinus_Click(object sender, EventArgs e)
        => Gmap.Zoom--;
```
 - � ����������� ����� �MyGmap� �������
```
CMBMapProviders.Items.AddRange(MyGmapHelper.GMapProviders);
CMBMapProviders.SelectedIndex = 0;
Gmap.Zoom = 8;
```
 - ������ ��������� ��� ����������� �������� ��������� �� ���� ����:
	 - � ���������� ����������� ���������� �MyGmap� ������� �� PanelBottom ����� TextBox (Name=�TXTGmapStatus�), �� ������� ��������� ���� Gmap OnMapZoomChanged �� OnPositionChanged:
```
        private void Gmap_OnMapZoomChanged()
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat}, {Gmap.Position.Lng} x{Gmap.Zoom}";

        private void Gmap_OnPositionChanged(GMap.NET.PointLatLng point)
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat}, {Gmap.Position.Lng} x{Gmap.Zoom}";
```





