using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Hierarchy_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_HierarchyObjectType[] project_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Hierarchy_Reference", Order = 0)]
		public Project_HierarchyObjectType[] Project_Hierarchy_Reference
		{
			get
			{
				return this.project_Hierarchy_ReferenceField;
			}
			set
			{
				this.project_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Project_Hierarchy_Reference");
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
