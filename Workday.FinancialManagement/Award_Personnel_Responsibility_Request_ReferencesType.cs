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
	public class Award_Personnel_Responsibility_Request_ReferencesType : INotifyPropertyChanged
	{
		private Award_Personnel_ResponsibilityObjectType[] award_Personnel_Responsibility_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Award_Personnel_Responsibility_Reference", Order = 0)]
		public Award_Personnel_ResponsibilityObjectType[] Award_Personnel_Responsibility_Reference
		{
			get
			{
				return this.award_Personnel_Responsibility_ReferenceField;
			}
			set
			{
				this.award_Personnel_Responsibility_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_Reference");
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
