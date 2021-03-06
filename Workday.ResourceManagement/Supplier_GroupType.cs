using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_GroupType : INotifyPropertyChanged
	{
		private Supplier_GroupObjectType supplier_Group_ReferenceField;

		private Supplier_Group_DataType[] supplier_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_GroupObjectType Supplier_Group_Reference
		{
			get
			{
				return this.supplier_Group_ReferenceField;
			}
			set
			{
				this.supplier_Group_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Group_Reference");
			}
		}

		[XmlElement("Supplier_Group_Data", Order = 1)]
		public Supplier_Group_DataType[] Supplier_Group_Data
		{
			get
			{
				return this.supplier_Group_DataField;
			}
			set
			{
				this.supplier_Group_DataField = value;
				this.RaisePropertyChanged("Supplier_Group_Data");
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
