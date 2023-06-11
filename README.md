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
 - WinFomsComponents.  
������ ���� ������ �� ���������� WinFoms. ���� GMap.NET.WinForms, ���� �������� � ����� �������.
 - WinFomsComponents.MyGmap. �� �������� WinFomsComponents ������� MyGmap. � ����� ������� ���� �������� ��������� ��������� �����������- ���� �GMap.NET.WinForms�.  
## ������� 2. ������� �������� ��������� ����������� �MyGmap�
---
� ������ �GMap_WpfAndWinForm.ControlLibrary�, � ������� �WinFomsComponents.MyGmap�, ������� ����� ������� ��������� ����������� Windows Forms, � ������ �MyGmap�. �� ���� ������ ���������� ���������� ����.
 - � ����������� �������� ����������� �MyGmap�, ������� ������� ����������:
	- GMap.NET.WindowsForms.GMapControl, ����� Gmap, ����������: Dock = DockStyle.Fill, DisableFocusOnMouseEnter = true;
	- ������� 4 ����� � ������� PanelLeft, PanelTop, PanelRight, PanelBottom. ���������� BackColor=Transparent, �� ��������� ���������� Dock, �������� � Left, Right, Bottom �� Top. ������ ��� ������ ����� ��������� �������� � 23.
  
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
