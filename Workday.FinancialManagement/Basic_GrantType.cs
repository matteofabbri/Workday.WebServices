using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Basic_GrantType : INotifyPropertyChanged
	{
		private GrantObjectType basic_Grant_ReferenceField;

		private Basic_Grant_DataType basic_Grant_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GrantObjectType Basic_Grant_Reference
		{
			get
			{
				return this.basic_Grant_ReferenceField;
			}
			set
			{
				this.basic_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Basic_Grant_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Basic_Grant_DataType Basic_Grant_Data
		{
			get
			{
				return this.basic_Grant_DataField;
			}
			set
			{
				this.basic_Grant_DataField = value;
				this.RaisePropertyChanged("Basic_Grant_Data");
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
