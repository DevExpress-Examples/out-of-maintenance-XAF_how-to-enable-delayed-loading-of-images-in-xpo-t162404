using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DelayedImagesXPO.Module.BusinessObjects {
    [DefaultClassOptions]
    public class SampleObject : BaseObject {
        public SampleObject(Session session)
            : base(session) {
        }
        private string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }
        [Delayed, ImageEditor, VisibleInListView(true)]
        public byte[] Image {
            get { return GetDelayedPropertyValue<byte[]>("Image"); }
            set { SetDelayedPropertyValue<byte[]>("Image", value); }
        }
    }
}
