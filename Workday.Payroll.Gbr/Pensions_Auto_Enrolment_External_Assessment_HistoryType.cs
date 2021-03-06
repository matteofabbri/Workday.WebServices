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
	public class Pensions_Auto_Enrolment_External_Assessment_HistoryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType pensions_Auto_Enrolment_External_Assessment_History_ReferenceField;

		private Pensions_Auto_Enrolment_External_Assessment_History_DataType[] pensions_Auto_Enrolment_External_Assessment_History_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Pensions_Auto_Enrolment_External_Assessment_History_Reference
		{
			get
			{
				return this.pensions_Auto_Enrolment_External_Assessment_History_ReferenceField;
			}
			set
			{
				this.pensions_Auto_Enrolment_External_Assessment_History_ReferenceField = value;
				this.RaisePropertyChanged("Pensions_Auto_Enrolment_External_Assessment_History_Reference");
			}
		}

		[XmlElement("Pensions_Auto_Enrolment_External_Assessment_History_Data", Order = 1)]
		public Pensions_Auto_Enrolment_External_Assessment_History_DataType[] Pensions_Auto_Enrolment_External_Assessment_History_Data
		{
			get
			{
				return this.pensions_Auto_Enrolment_External_Assessment_History_DataField;
			}
			set
			{
				this.pensions_Auto_Enrolment_External_Assessment_History_DataField = value;
				this.RaisePropertyChanged("Pensions_Auto_Enrolment_External_Assessment_History_Data");
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
