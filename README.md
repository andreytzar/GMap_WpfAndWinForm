# GMap_WpfAndWinForm
Цей проект демонструє застосунок з використанням мапи GMap.NET, автор Jurgen De Leon Rodriguez (https://github.com/judero01col/GMap.NET).  
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
 - WinFomsComponents.  
Простір буде містити всі компоненти WinFoms. Мапа GMap.NET.WinForms, буде розміщена в цьому просторі.
 - WinFomsComponents.MyGmap. До простору WinFomsComponents додайте MyGmap. В цьому просторі буде міститись візуальний компонент користувача- мапа «GMap.NET.WinForms».  
## Частина 2. Розмітка елемента управління користувача «MyGmap»
---
В проекті «GMap_WpfAndWinForm.ControlLibrary», в просторі «WinFomsComponents.MyGmap», додайте новий елемент управління користувача Windows Forms, з назвою «MyGmap». Це буде шаблон візуального компонента мапи.
 - В конструкторі елемента користувача «MyGmap», додайте візуальні компоненти:
	- GMap.NET.WindowsForms.GMapControl, назва Gmap, властивості: Dock = DockStyle.Fill, DisableFocusOnMouseEnter = true;
	- Додайте 4 панелі з назвами PanelLeft, PanelTop, PanelRight, PanelBottom. Властивість BackColor=Transparent, та встановіть властивість Dock, відповідно в Left, Right, Bottom та Top. Ширину або висоту також встановіть відповідно в 23.
  
Створений компонент вже можливо  використовувати в головному проекті «GMap_WpfAndWinForm». Для цього в Проекті «GMap_WpfAndWinForm», в XAML розмітці головного вікна «MainWindow.xaml», додайте простір імен:
```
        xmlns:map="clr-namespace:GMap_WpfAndWinForm.ControlLibrary.WinFomsComponents.MyGmap;assembly=GMap_WpfAndWinForm.ControlLibrary"
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
