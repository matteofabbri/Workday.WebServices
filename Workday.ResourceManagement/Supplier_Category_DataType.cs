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
	public class Supplier_Category_DataType : INotifyPropertyChanged
	{
		private string supplier_Category_IDField;

		private string supplier_Category_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Category_ID
		{
			get
			{
				return this.supplier_Category_IDField;
			}
			set
			{
				this.supplier_Category_IDField = value;
				this.RaisePropertyChanged("Supplier_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Supplier_Category_Name
		{
			get
			{
				return this.supplier_Category_NameField;
			}
			set
			{
				this.supplier_Category_NameField = value;
				this.RaisePropertyChanged("Supplier_Category_Name");
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
