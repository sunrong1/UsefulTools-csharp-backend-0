## I. 前言
WPF适合做富桌面的应用，这和现在的移动互联网的趋势不符，故Microsoft早在2013年就停止了Silverlight的更新。故WPF现在已经成为了一种小众的应用。

公司留下一些WPF的软件需要维护，故自己又不得不学习下WPF，同时WPF又非常适合做单机的桌面应用，公司的单机的桌面应用也不少，故选择WPF再开发一个小工具。

学习的目标：可以维护现有的WPF程序；可以使用WPF写简单的桌面应用。

## II.WPF的学习的基础知识。

- 一种的编程语言：C#，VB.Net……
- 标记语言：XAML
- 关联视图和数据：数据绑定（Data binding），数据模版（DataTemplates）……
- 设计模式和实现：MVVM，INotifyPropertyChanged, INotifyCollectionChanged, ICommand……

本人已经开发C#一年，对C#已熟悉，但是对于其他的基础知识还不太熟悉。

>参考文章 [WPF的未来](https://my.oschina.net/powertoolsteam/blog/356596)

## III. WPF的辅助套件

Microsoft 官方的 [WPF ToolKit](https://wpf.codeplex.com/),早在2010年就停止更新了。

XCEED公司提供的更丰富的第三方扩展WPF工具 [Extended WPF Toolkit™](https://wpftoolkit.codeplex.com/)

## III. Binding 数据绑定

WPF 中的数据绑定，必须要有绑定目标和要绑定的数据源。绑定目标可以是继承自 DependencyProperty的任何可访问的属性或控件。
