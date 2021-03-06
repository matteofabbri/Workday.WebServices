using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ISIR_Person_DataType : INotifyPropertyChanged
	{
		private Legal_Name_DataType[] legal_Name_DataField;

		private Contact_Information_DataType[] contact_Information_DataField;

		private Student_Personal_Profile_DataType[] personal_Profile_DataField;

		private Person_Identification_DataType[] person_Identification_DataField;

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

		[XmlElement("Personal_Profile_Data", Order = 2)]
		public Student_Personal_Profile_DataType[] Personal_Profile_Data
		{
			get
			{
				return this.personal_Profile_DataField;
			}
			set
			{
				this.personal_Profile_DataField = value;
				this.RaisePropertyChanged("Personal_Profile_Data");
			}
		}

		[XmlElement("Person_Identification_Data", Order = 3)]
		public Person_Identification_DataType[] Person_Identification_Data
		{
			get
			{
				return this.person_Identification_DataField;
			}
			set
			{
				this.person_Identification_DataField = value;
				this.RaisePropertyChanged("Person_Identification_Data");
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
