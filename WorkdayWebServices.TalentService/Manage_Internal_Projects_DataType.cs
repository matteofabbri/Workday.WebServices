using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.TalentService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Internal_Projects_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Person_Skill_Source_CategoryObjectType source_ReferenceField;

		private Internal_Project_ExperienceType[] internal_ProjectsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Person_Skill_Source_CategoryObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement("Internal_Projects", Order = 2)]
		public Internal_Project_ExperienceType[] Internal_Projects
		{
			get
			{
				return this.internal_ProjectsField;
			}
			set
			{
				this.internal_ProjectsField = value;
				this.RaisePropertyChanged("Internal_Projects");
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