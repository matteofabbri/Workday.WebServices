using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Training_Profile_for_Job_DataType : INotifyPropertyChanged
	{
		private string training_NameField;

		private string descriptionField;

		private Training_TypeObjectType training_Type_ReferenceField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private Skill_Qualification_EnabledObjectType qualification_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Training_Name
		{
			get
			{
				return this.training_NameField;
			}
			set
			{
				this.training_NameField = value;
				this.RaisePropertyChanged("Training_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 2)]
		public Training_TypeObjectType Training_Type_Reference
		{
			get
			{
				return this.training_Type_ReferenceField;
			}
			set
			{
				this.training_Type_ReferenceField = value;
				this.RaisePropertyChanged("Training_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
				this.RaisePropertyChanged("Required");
			}
		}

		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
				this.RaisePropertyChanged("RequiredSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Skill_Qualification_EnabledObjectType Qualification_Source_Reference
		{
			get
			{
				return this.qualification_Source_ReferenceField;
			}
			set
			{
				this.qualification_Source_ReferenceField = value;
				this.RaisePropertyChanged("Qualification_Source_Reference");
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
