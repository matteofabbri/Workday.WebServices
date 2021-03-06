using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Political_Affiliation_Request_ReferencesType : INotifyPropertyChanged
	{
		private Political_AffiliationObjectType[] political_Affiliation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Political_Affiliation_Reference", Order = 0)]
		public Political_AffiliationObjectType[] Political_Affiliation_Reference
		{
			get
			{
				return this.political_Affiliation_ReferenceField;
			}
			set
			{
				this.political_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Political_Affiliation_Reference");
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
