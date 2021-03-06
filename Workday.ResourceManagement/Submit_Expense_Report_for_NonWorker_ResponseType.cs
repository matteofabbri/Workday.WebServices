using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Submit_Expense_Report_for_Non-Worker_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Expense_Report_for_NonWorker_ResponseType : INotifyPropertyChanged
	{
		private Expense_ReportObjectType expense_Report_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Expense_ReportObjectType Expense_Report_Reference
		{
			get
			{
				return this.expense_Report_ReferenceField;
			}
			set
			{
				this.expense_Report_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Report_Reference");
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
