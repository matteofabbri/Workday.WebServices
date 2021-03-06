using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Career_Preferences_DataType : INotifyPropertyChanged
	{
		private Career_ResponsibilityObjectType career_Interest_ReferenceField;

		private string career_InterestsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Career_ResponsibilityObjectType Career_Interest_Reference
		{
			get
			{
				return this.career_Interest_ReferenceField;
			}
			set
			{
				this.career_Interest_ReferenceField = value;
				this.RaisePropertyChanged("Career_Interest_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Career_Interests
		{
			get
			{
				return this.career_InterestsField;
			}
			set
			{
				this.career_InterestsField = value;
				this.RaisePropertyChanged("Career_Interests");
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
