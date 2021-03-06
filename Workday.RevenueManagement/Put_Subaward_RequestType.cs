using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Subaward_RequestType : INotifyPropertyChanged
	{
		private Subaward_AbstractObjectType subaward_ReferenceField;

		private Subaward_DataType subaward_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Subaward_AbstractObjectType Subaward_Reference
		{
			get
			{
				return this.subaward_ReferenceField;
			}
			set
			{
				this.subaward_ReferenceField = value;
				this.RaisePropertyChanged("Subaward_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Subaward_DataType Subaward_Data
		{
			get
			{
				return this.subaward_DataField;
			}
			set
			{
				this.subaward_DataField = value;
				this.RaisePropertyChanged("Subaward_Data");
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
