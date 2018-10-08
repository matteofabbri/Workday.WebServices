using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Workday_AccountType : INotifyPropertyChanged
	{
		private RoleObjectType workday_Account_ReferenceField;

		private Workday_Account_for_Worker_DataType[] workday_Account_for_Worker_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Workday_Account_Reference
		{
			get
			{
				return this.workday_Account_ReferenceField;
			}
			set
			{
				this.workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Workday_Account_Reference");
			}
		}

		[XmlElement("Workday_Account_for_Worker_Data", Order = 1)]
		public Workday_Account_for_Worker_DataType[] Workday_Account_for_Worker_Data
		{
			get
			{
				return this.workday_Account_for_Worker_DataField;
			}
			set
			{
				this.workday_Account_for_Worker_DataField = value;
				this.RaisePropertyChanged("Workday_Account_for_Worker_Data");
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