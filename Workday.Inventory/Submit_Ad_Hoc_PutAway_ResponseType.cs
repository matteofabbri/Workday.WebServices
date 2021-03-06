using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Submit_Ad_Hoc_Put-Away_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Ad_Hoc_PutAway_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType inventory_PutAway_Event_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Put-Away_Event_Reference", Order = 0)]
		public Unique_IdentifierObjectType Inventory_PutAway_Event_Reference
		{
			get
			{
				return this.inventory_PutAway_Event_ReferenceField;
			}
			set
			{
				this.inventory_PutAway_Event_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_PutAway_Event_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
