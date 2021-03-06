using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Student_LoanType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Payee_Student_Loan_ReferenceField;

		private Payroll_Payee_Student_Loan_DataType[] payroll_Payee_Student_Loans_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_Payee_Student_Loan_Reference
		{
			get
			{
				return this.payroll_Payee_Student_Loan_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Student_Loan_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Student_Loan_Reference");
			}
		}

		[XmlElement("Payroll_Payee_Student_Loans_Data", Order = 1)]
		public Payroll_Payee_Student_Loan_DataType[] Payroll_Payee_Student_Loans_Data
		{
			get
			{
				return this.payroll_Payee_Student_Loans_DataField;
			}
			set
			{
				this.payroll_Payee_Student_Loans_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_Student_Loans_Data");
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
