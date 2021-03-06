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
	public class Payroll_Payee_TD1_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Payee_T1ObjectType[] tD1_Election_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("TD1_Election_Reference", Order = 0)]
		public Payroll_Payee_T1ObjectType[] TD1_Election_Reference
		{
			get
			{
				return this.tD1_Election_ReferenceField;
			}
			set
			{
				this.tD1_Election_ReferenceField = value;
				this.RaisePropertyChanged("TD1_Election_Reference");
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
