using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ReferenceField;

		private Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataType payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Reference
		{
			get
			{
				return this.payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataType Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Data
		{
			get
			{
				return this.payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataField;
			}
			set
			{
				this.payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Data");
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
