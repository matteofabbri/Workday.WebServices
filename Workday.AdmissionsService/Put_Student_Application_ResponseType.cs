using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Student_Application_ResponseType : INotifyPropertyChanged
	{
		private Student_ApplicationObjectType student_Application_ReferenceField;

		private StudentObjectType student_Prospect_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ApplicationObjectType Student_Application_Reference
		{
			get
			{
				return this.student_Application_ReferenceField;
			}
			set
			{
				this.student_Application_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public StudentObjectType Student_Prospect_Reference
		{
			get
			{
				return this.student_Prospect_ReferenceField;
			}
			set
			{
				this.student_Prospect_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Reference");
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
