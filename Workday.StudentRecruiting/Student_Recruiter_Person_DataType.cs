using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiter_Person_DataType : INotifyPropertyChanged
	{
		private Legal_Name_DataType[] legal_Name_DataField;

		private Contact_Information_DataType[] contact_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Legal_Name_Data", Order = 0)]
		public Legal_Name_DataType[] Legal_Name_Data
		{
			get
			{
				return this.legal_Name_DataField;
			}
			set
			{
				this.legal_Name_DataField = value;
				this.RaisePropertyChanged("Legal_Name_Data");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 1)]
		public Contact_Information_DataType[] Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
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
