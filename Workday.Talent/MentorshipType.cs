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
	public class MentorshipType : INotifyPropertyChanged
	{
		private MentorshipObjectType mentorship_ReferenceField;

		private Mentorship_DataType[] mentorship_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public MentorshipObjectType Mentorship_Reference
		{
			get
			{
				return this.mentorship_ReferenceField;
			}
			set
			{
				this.mentorship_ReferenceField = value;
				this.RaisePropertyChanged("Mentorship_Reference");
			}
		}

		[XmlElement("Mentorship_Data", Order = 1)]
		public Mentorship_DataType[] Mentorship_Data
		{
			get
			{
				return this.mentorship_DataField;
			}
			set
			{
				this.mentorship_DataField = value;
				this.RaisePropertyChanged("Mentorship_Data");
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
