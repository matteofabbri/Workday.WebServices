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
	public class Loan_Investor_Type_Request_ReferencesType : INotifyPropertyChanged
	{
		private Loan_Investor_TypeObjectType[] loan_Investor_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Loan_Investor_Type_Reference", Order = 0)]
		public Loan_Investor_TypeObjectType[] Loan_Investor_Type_Reference
		{
			get
			{
				return this.loan_Investor_Type_ReferenceField;
			}
			set
			{
				this.loan_Investor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Investor_Type_Reference");
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
