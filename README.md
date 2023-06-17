https://www.linkedin.com/in/andrey-tzarkov/  
https://github.com/andreytzar/GMap_WpfAndWinForm

Детальний опис:  
 - [Вступ](https://www.linkedin.com/pulse/%D0%BC%D0%B0%D0%BF%D0%B0-gmapnet-%D1%83-%D0%B7%D0%B0%D1%81%D1%82%D0%BE%D1%81%D1%83%D0%BD%D0%BA%D0%B0%D1%85-c-wpfnet-part1-%D0%B0%D0%BD%D0%B4%D1%80%D1%96%D0%B9-%D1%86%D0%B0%D1%80%D0%BA%D0%BE%D0%B2)  
 - [Шари та створення маркерів](https://www.linkedin.com/pulse/%D0%BC%D0%B0%D0%BF%D0%B0-gmapnet-%D1%83-%D0%B7%D0%B0%D1%81%D1%82%D0%BE%D1%81%D1%83%D0%BD%D0%BA%D0%B0%D1%85-c-wpfnet-%D1%88%D0%B0%D1%80%D0%B8-%D0%BC%D0%B0%D0%BF%D0%B8-%D1%81%D1%82%D0%B2%D0%BE%D1%80%D0%B5%D0%BD%D0%BD%D1%8F-%D0%B0%D0%BD%D0%B4%D1%80%D1%96%D0%B9-%D1%86%D0%B0%D1%80%D0%BA%D0%BE%D0%B2)

# GMap_WpfAndWinForm
Цей проект демонструє застосунок з використанням мапи GMap.NET (https://github.com/judero01col/GMap.NET).  
Також проект демонструє використання компонентів WinForms в проектах застосунків WPF.NET.  
Цей опис побудований, як покрокова інструкція. Та складається з декілька частин.

## Частина 1. Структура рішення. Базові налаштування проектів. Встановлення пакетів. Розмітка простору імен.
---
###	Структура рішення:
---
 - Створіть пусте рішення з назвою «GMap_WpfAndWinForm»
 - До рішення додайте новий проект «GMap_WpfAndWinForm» за шаблоном «Застосунок WPF (Майкрософт WPF.NET)».  
Назва проекту може бути, будь яка. Це буде основний проект, до якого будуть додані посилання до інших проектів.  
 - До рішення додайте новий проект «GMap_WpfAndWinForm.ControlLibrary» за шаблоном «Бібліотека користувача елементів управління до застосунків WPF.NET (Майкрософт)».  
Проект бібліотеки буде містити візуальні компоненти, які буде використовувати основний проект. В цій бібліотеці будуть міститись WPF та WinForms візуальні компоненти.
###	Базові налаштування проектів:
---
Проекти створенні за шаблоном використання WPF.NET. Але GMap.NET містить більше можливостей саме в пакеті GMap.NET.WinForms, такі як полігони, маршрути, вимірювання відстані та інше. Щоб додати можливість використання WinForms в проектах WPF.NET, в описах проектів в секції «PropertyGroup», додайте: 
```
<UseWindowsForms>true</UseWindowsForms>
```
Або в властивостях проекту відзначте «Використовувати WinForms в цьому проекті».  
В проекті «GMap_WpfAndWinForm» додайте посилання на проект «GMap_WpfAndWinForm.ControlLibrary».  
```
  <ItemGroup>
    <ProjectReference Include="..\GMap_WpfAndWinForm.ControlLibrary\GMap_WpfAndWinForm.ControlLibrary.csproj" />
  </ItemGroup>
```
### Встановлення пакетів NuGet.  
---
В проекті «GMap_WpfAndWinForm.ControlLibrary», встановіть пакет NuGet «GMap.NET.WinForms», автор Jurgen De Leon Rodriguez (https://github.com/judero01col/GMap.NET).  
Проект «GMap_WpfAndWinForm.ControlLibrary» буде містити мапу GMap.Net, вся логіки використання візуального компонента мапи буде розміщено саме в цьому проекті.
###	Розмітка простору імен.
---
В проекті «GMap_WpfAndWinForm.ControlLibrary» додайте простори імен (таці):
 - WinFormsComponents.  
Простір буде містити всі компоненти WinFoms. Мапа GMap.NET.WinForms, буде розміщена в цьому просторі.
 - WinFormsComponents.MyGmap. До простору WinFomsComponents додайте MyGmap. В цьому просторі буде міститись візуальний компонент користувача- мапа «GMap.NET.WinForms».  
 - WinFormsComponents.MyGmap.MarkersPolygonsRoutes. До MyGmap додайте простір MarkersPolygonsRoutes. В цьому просторі будуть створені маркери, маршрути, полігони.  
## Частина 2. Розмітка елемента управління користувача «MyGmap»
---
В проекті «GMap_WpfAndWinForm.ControlLibrary», в просторі «WinFomsComponents.MyGmap», додайте новий елемент управління користувача Windows Forms, з назвою «MyGmap». Це буде шаблон візуального компонента мапи.
 - В конструкторі елемента користувача «MyGmap», додайте візуальні компоненти:
	- GMap.NET.WindowsForms.GMapControl, назва Gmap, властивості: Dock = DockStyle.Fill, DisableFocusOnMouseEnter = true;
	- Додайте 4 панелі з назвами PanelLeft, PanelTop, PanelRight, PanelBottom. ВластивістІ BackColor = Color.FromArgb(0, 0, 0, 0), Parent = Gmap, та встановіть властивість Dock, відповідно в Left, Right, Bottom та Top. Ширину або висоту також встановіть відповідно в 23.
 - Додайте публічний статичний клас MyGmapHelper.cs, цей клас буду містити допоміжні компоненти мапи.
  
Створений компонент вже можливо  використовувати в головному проекті «GMap_WpfAndWinForm». Для цього в Проекті «GMap_WpfAndWinForm», в XAML розмітці головного вікна «MainWindow.xaml», додайте простір імен:
```
xmlns:map="clr-namespace:GMap_WpfAndWinForm.ControlLibrary.WinFormsComponents.MyGmap;assembly=GMap_WpfAndWinForm.ControlLibrary"
```
Та додайте сам компонент мапи, огорнутий в WindowsFormsHost
```
    <Grid>
        <WindowsFormsHost>
            <map:MyGmap/>
        </WindowsFormsHost>
    </Grid>
```
Підготовка завершена, можна спробувати скомпілювати та запустити рішення.
## Частина 3. Основні властивості «Gmap»
Попередні налаштування:
 - Gmap.MarkersEnabled = true – дозволити маркери. Дозволяє наносити, мітки, маркери, малювати різні об’єкти на мапі.
 - Gmap.PolygonsEnabled = true – Дозволяє полігони, та лінії, підсвічувати зони, та інше.
 - Gmap.RoutesEnabled = true – Дозволяє буду вати маршрути, вираховувати відстані.
 - Gmap.MaxZoom = 18, Gmap.MinZoom = 2 максимальне та мінімальне збільшення мапи.
 - Gmap.MouseWheelZoomEnabled = true – Дозволяє збільшити або зменшити мапу колесом прокрутки миші.
 - Gmap.MouseWheelZoomType = MousePositionWithoutCenter – спосіб центрування мапи, при прокрутки мишкою.
 - Gmap.DragButton = MouseButtons.Left – кнопка мишки при натисканні якої буде змінюватись положення мапи.   
---
Основні налаштування та властивості:
 - Gmap.MapProvider - провайдер (тип) мапи, яка буде використовуватись в компоненті (Google, Bing, OpenStreetMap та інше).
 - Gmap.Zoom – поточне збільшення (зум) мапи.
 - Gmap.Position – поточні координати центру мапи.
## Частина 4. Базові інтерфейси для взаємодії з «Gmap»
Створимо інтерфейс для вибори провайдера мапи. Для цього:
 - До класу «MyGmapHelper.cs» додайте статичний масив провайдерів
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
 - В візуальному конструкторі компоненту «MyGmap» додайте до PanelTop новий ComboBox (Name=”CMBMapProviders”), 2 кнопки (Name=” BTNZoomPlus”, Name=” BTNZoomMinus”). Додайте метод CMBMapProviders CMBMapProviders_SelectedValueChanged, та методи OnClick кнопок зуму:
```
        private void CMBMapProviders_SelectedValueChanged(object sender, EventArgs e)
        =>Gmap.MapProvider = CMBMapProviders.SelectedItem as GMapProvider;

        private void BTNZoomPlus_Click(object sender, EventArgs e)
        => Gmap.Zoom++;

        private void BTNZoomMinus_Click(object sender, EventArgs e)
        => Gmap.Zoom--;
```
 - В конструкторі класу «MyGmap» додайте
```
CMBMapProviders.Items.AddRange(MyGmapHelper.GMapProviders);
CMBMapProviders.SelectedIndex = 0;
Gmap.Zoom = 8;
```
 - Додомо інтерфейс для відображення поточних координат та зуму мапи:
	 - В візуальному конструкторі компоненту «MyGmap» додайте до PanelBottom новий TextBox (Name=”TXTGmapStatus”), та додайте обробники подій Gmap OnMapZoomChanged та OnPositionChanged:
```
        private void Gmap_OnMapZoomChanged()
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat}, {Gmap.Position.Lng} x{Gmap.Zoom}";

        private void Gmap_OnPositionChanged(GMap.NET.PointLatLng point)
        => TXTGmapStatus.Text = $"{Gmap.Position.Lat}, {Gmap.Position.Lng} x{Gmap.Zoom}";
```





