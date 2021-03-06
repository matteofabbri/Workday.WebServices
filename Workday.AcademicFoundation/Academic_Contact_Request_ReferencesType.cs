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
	public class Academic_Contact_Request_ReferencesType : INotifyPropertyChanged
	{
		private Academic_ContactObjectType[] academic_Contact_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Academic_Contact_Reference", Order = 0)]
		public Academic_ContactObjectType[] Academic_Contact_Reference
		{
			get
			{
				return this.academic_Contact_ReferenceField;
			}
			set
			{
				this.academic_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Contact_Reference");
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
