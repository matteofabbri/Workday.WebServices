using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payee_Tax_Code_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payee_Tax_Code_ReferenceField;

		private Put_Payee_Tax_Code_Response_DataType put_Payee_Tax_Code_Response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payee_Tax_Code_Reference
		{
			get
			{
				return this.payee_Tax_Code_ReferenceField;
			}
			set
			{
				this.payee_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Put_Payee_Tax_Code_Response_DataType Put_Payee_Tax_Code_Response_Data
		{
			get
			{
				return this.put_Payee_Tax_Code_Response_DataField;
			}
			set
			{
				this.put_Payee_Tax_Code_Response_DataField = value;
				this.RaisePropertyChanged("Put_Payee_Tax_Code_Response_Data");
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
