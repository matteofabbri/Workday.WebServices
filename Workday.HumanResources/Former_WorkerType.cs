using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Former_WorkerType : INotifyPropertyChanged
	{
		private Former_WorkerObjectType former_Worker_ReferenceField;

		private Former_Worker_DataType former_Worker_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Former_WorkerObjectType Former_Worker_Reference
		{
			get
			{
				return this.former_Worker_ReferenceField;
			}
			set
			{
				this.former_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Former_Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Former_Worker_DataType Former_Worker_Data
		{
			get
			{
				return this.former_Worker_DataField;
			}
			set
			{
				this.former_Worker_DataField = value;
				this.RaisePropertyChanged("Former_Worker_Data");
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
