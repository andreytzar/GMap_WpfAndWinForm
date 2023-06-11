# GMap_WpfAndWinForm
��� ������ ��������� ���������� � ������������� ���� GMap.NET, ����� Jurgen De Leon Rodriguez (https://github.com/judero01col/GMap.NET).  
����� ������ ��������� ������������ ���������� WinForms � �������� ���������� WPF.NET.  
��� ���� �����������, �� ��������� ����������. �� ���������� � ������� ������.

## ������� 1. ��������� ������. ����� ������������ �������. ������������ ������. ������� �������� ����.
---
###	��������� ������:
---
 - ������� ����� ������ � ������ �GMap_WpfAndWinForm�
 - �� ������ ������� ����� ������ �GMap_WpfAndWinForm� �� �������� ����������� WPF (���������� WPF.NET)�.  
����� ������� ���� ����, ���� ���. �� ���� �������� ������, �� ����� ������ ������ ��������� �� ����� �������.  
 - �� ������ ������� ����� ������ �GMap_WpfAndWinForm.ControlLibrary� �� �������� ���������� ����������� �������� ��������� �� ���������� WPF.NET (����������)�.  
������ �������� ���� ������ �������� ����������, �� ���� ��������������� �������� ������. � ��� �������� ������ �������� WPF �� WinForms �������� ����������.
###	����� ������������ �������:
---
������� ��������� �� �������� ������������ WPF.NET. ��� GMap.NET ������ ����� ����������� ���� � ����� GMap.NET.WinForms, ��� �� �������, ��������, ���������� ������� �� ����. ��� ������ ��������� ������������ WinForms � �������� WPF.NET, � ������ ������� � ������ �PropertyGroup�, �������: 
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
 - WinFomsComponents.  
������ ���� ������ �� ���������� WinFoms. ���� GMap.NET.WinForms, ���� �������� � ����� �������.
 - WinFomsComponents.MyGmap. �� �������� WinFomsComponents ������� MyGmap. � ����� ������� ���� �������� ��������� ��������� �����������- ���� �GMap.NET.WinForms�.  
## ������� 2. ������� �������� ��������� ����������� �MyGmap�
---
� ������ �GMap_WpfAndWinForm.ControlLibrary�, � ������� �WinFomsComponents.MyGmap�, ������� ����� ������� ��������� ����������� Windows Forms, � ������ �MyGmap�. �� ���� ������ ���������� ���������� ����.
 - � ����������� �������� ����������� �MyGmap�, ������� �������� ����������:
	- GMap.NET.WindowsForms.GMapControl, ����� Gmap, ����������: Dock = DockStyle.Fill, DisableFocusOnMouseEnter = true;
	- ������� 4 ����� � ������� PanelLeft, PanelTop, PanelRight, PanelBottom. ��������� BackColor = Color.FromArgb(0, 0, 0, 0), Parent = Gmap, �� ��������� ���������� Dock, �������� � Left, Right, Bottom �� Top. ������ ��� ������ ����� ��������� �������� � 23.
 - ������� �������� ��������� ���� MyGmapHelper.cs, ��� ���� ���� ������ �������� ���������� ����.
  
��������� ��������� ��� �������  ��������������� � ��������� ������ �GMap_WpfAndWinForm�. ��� ����� � ������ �GMap_WpfAndWinForm�, � XAML ������� ��������� ���� �MainWindow.xaml�, ������� ������ ����:
```
xmlns:map="clr-namespace:GMap_WpfAndWinForm.ControlLibrary.WinFomsComponents.MyGmap;assembly=GMap_WpfAndWinForm.ControlLibrary"
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
## ������� 3. ������� ���������� �Gmap�
��������� ������������:
 - Gmap.MarkersEnabled = true � ��������� �������. �������� ��������, ����, �������, �������� ���� �ᒺ��� �� ���.
 - Gmap.PolygonsEnabled = true � �������� �������, �� ����, ���������� ����, �� ����.
 - Gmap.RoutesEnabled = true � �������� ���� ���� ��������, ������������ �������.
 - Gmap.MaxZoom = 18, Gmap.MinZoom = 2 ����������� �� ��������� ��������� ����.
 - Gmap.MouseWheelZoomEnabled = true � �������� �������� ��� �������� ���� ������� ��������� ����.
 - Gmap.MouseWheelZoomType = MousePositionWithoutCenter � ����� ����������� ����, ��� ��������� ������.
 - Gmap.DragButton = MouseButtons.Left � ������ ����� ��� ���������� ��� ���� ���������� ��������� ����.   
---
������� ������������ �� ����������:
 - Gmap.MapProvider - ��������� (���) ����, ��� ���� ����������������� � ��������� (Google, Bing, OpenStreetMap �� ����).
 - Gmap.Zoom � ������� ��������� (���) ����.
 - Gmap.Position � ������� ���������� ������ ����.
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





