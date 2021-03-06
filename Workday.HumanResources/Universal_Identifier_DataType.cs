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
	public class Universal_Identifier_DataType : INotifyPropertyChanged
	{
		private RoleObjectType[] person_ReferenceField;

		private string universal_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Person_Reference", Order = 0)]
		public RoleObjectType[] Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
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
