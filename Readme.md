<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128589933/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T162404)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[SampleObject.cs](./CS/DelayedImagesXPO.Module/BusinessObjects/SampleObject.cs) (VB: [SampleObject.vb](./VB/DelayedImagesXPO.Module/BusinessObjects/SampleObject.vb))**
<!-- default file list end -->
# How to enable delayed loading of images in XPO


When an application displays a lot of large images in a List View, it may consume a lot of memory. It is most actual for ASP.NET applications with many simultaneously connected clients.<br />To enable delayed (or <em>lazy</em>) loading of images and reduce the memory usage, do the following:<br /><br />- Apply the <a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoDelayedAttributetopic">Delayed</a> attribute to the persistent class' property that is used as an image storage.<br />- Use the <strong>GetDelayedPropertyValue / SetDelayedPropertyValue</strong> methods in the property getter / setter.<br /><br /><br /><strong>See Also: </strong><a href="https://www.devexpress.com/Support/Center/p/T161987">How to enable delayed loading of images in Entity Framework</a> <br /><br />

<br/>


