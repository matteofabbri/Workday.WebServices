using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Increment_Sequence_Generator_ResponseType : INotifyPropertyChanged
	{
		private Sequence_GeneratorObjectType sequence_Generator_ReferenceField;

		private string sequenced_ValueField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Sequence_GeneratorObjectType Sequence_Generator_Reference
		{
			get
			{
				return this.sequence_Generator_ReferenceField;
			}
			set
			{
				this.sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Sequenced_Value
		{
			get
			{
				return this.sequenced_ValueField;
			}
			set
			{
				this.sequenced_ValueField = value;
				this.RaisePropertyChanged("Sequenced_Value");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
