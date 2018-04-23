# How to enable delayed loading of images in XPO


When an application displays a lot of large images in a List View, it may consume a lot of memory. It is most actual for ASP.NET applications with many simultaneously connected clients.<br />To enable delayed (or <em>lazy</em>) loading of images and reduce the memory usage, do the following:<br /><br />- Apply the <a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoDelayedAttributetopic">Delayed</a> attribute to the persistent class' property that is used as an image storage.<br />- Use the <strong>GetDelayedPropertyValue / SetDelayedPropertyValue</strong> methods in the property getter / setter.<br /><br /><br /><strong>See Also: </strong><a href="https://www.devexpress.com/Support/Center/p/T161987">How to enable delayed loading of images in Entity Framework</a> <br /><br />

<br/>


