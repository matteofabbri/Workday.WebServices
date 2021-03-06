using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Applicant_RequestType : INotifyPropertyChanged
	{
		private ApplicantObjectType applicant_ReferenceField;

		private Applicant_Data_WWSType applicant_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ApplicantObjectType Applicant_Reference
		{
			get
			{
				return this.applicant_ReferenceField;
			}
			set
			{
				this.applicant_ReferenceField = value;
				this.RaisePropertyChanged("Applicant_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Applicant_Data_WWSType Applicant_Data
		{
			get
			{
				return this.applicant_DataField;
			}
			set
			{
				this.applicant_DataField = value;
				this.RaisePropertyChanged("Applicant_Data");
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
