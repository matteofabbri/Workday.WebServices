using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Rate_Table_Request_ReferencesType : INotifyPropertyChanged
	{
		private Expense_Rate_TableObjectType[] expense_Rate_Table_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Expense_Rate_Table_Reference", Order = 0)]
		public Expense_Rate_TableObjectType[] Expense_Rate_Table_Reference
		{
			get
			{
				return this.expense_Rate_Table_ReferenceField;
			}
			set
			{
				this.expense_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Reference");
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