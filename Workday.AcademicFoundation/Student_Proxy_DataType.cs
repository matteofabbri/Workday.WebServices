using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Proxy_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Proxy_RelationshipObjectType relationship_ReferenceField;

		private Student_Proxy_TypeObjectType[] relationship_Types_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private Legal_Name_DataType legal_Name_DataField;

		private Contact_Information_DataType[] contact_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Proxy_RelationshipObjectType Relationship_Reference
		{
			get
			{
				return this.relationship_ReferenceField;
			}
			set
			{
				this.relationship_ReferenceField = value;
				this.RaisePropertyChanged("Relationship_Reference");
			}
		}

		[XmlElement("Relationship_Types_Reference", Order = 2)]
		public Student_Proxy_TypeObjectType[] Relationship_Types_Reference
		{
			get
			{
				return this.relationship_Types_ReferenceField;
			}
			set
			{
				this.relationship_Types_ReferenceField = value;
				this.RaisePropertyChanged("Relationship_Types_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Legal_Name_DataType Legal_Name_Data
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

		[XmlElement("Contact_Information_Data", Order = 5)]
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
