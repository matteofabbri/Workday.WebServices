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
	public class Effort_Certification_TypeType : INotifyPropertyChanged
	{
		private Effort_Certification_TypeObjectType effort_Certification_Type_ReferenceField;

		private Effort_Certification_Type_DataType[] effort_Certification_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Effort_Certification_TypeObjectType Effort_Certification_Type_Reference
		{
			get
			{
				return this.effort_Certification_Type_ReferenceField;
			}
			set
			{
				this.effort_Certification_Type_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certification_Type_Reference");
			}
		}

		[XmlElement("Effort_Certification_Type_Data", Order = 1)]
		public Effort_Certification_Type_DataType[] Effort_Certification_Type_Data
		{
			get
			{
				return this.effort_Certification_Type_DataField;
			}
			set
			{
				this.effort_Certification_Type_DataField = value;
				this.RaisePropertyChanged("Effort_Certification_Type_Data");
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
