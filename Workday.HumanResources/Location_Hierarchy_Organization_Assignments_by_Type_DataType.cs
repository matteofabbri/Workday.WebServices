using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_Hierarchy_Organization_Assignments_by_Type_DataType : INotifyPropertyChanged
	{
		private Organization_TypeObjectType organization_Type_ReferenceField;

		private StaffObjectType[] allowed_Organization_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Organization_TypeObjectType Organization_Type_Reference
		{
			get
			{
				return this.organization_Type_ReferenceField;
			}
			set
			{
				this.organization_Type_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Type_Reference");
			}
		}

		[XmlElement("Allowed_Organization_Reference", Order = 1)]
		public StaffObjectType[] Allowed_Organization_Reference
		{
			get
			{
				return this.allowed_Organization_ReferenceField;
			}
			set
			{
				this.allowed_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Allowed_Organization_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
