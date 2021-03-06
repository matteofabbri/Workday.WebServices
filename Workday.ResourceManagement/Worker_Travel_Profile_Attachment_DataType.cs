using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Travel_Profile_Attachment_DataType : INotifyPropertyChanged
	{
		private byte[] fileField;

		private string commentField;

		private string content_TypeField;

		private string filenameField;

		private string attachment_EncodingField;

		private bool compressedField;

		private bool compressedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "base64Binary", Order = 0)]
		public byte[] File
		{
			get
			{
				return this.fileField;
			}
			set
			{
				this.fileField = value;
				this.RaisePropertyChanged("File");
			}
		}

		[XmlElement(Order = 1)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Content_Type
		{
			get
			{
				return this.content_TypeField;
			}
			set
			{
				this.content_TypeField = value;
				this.RaisePropertyChanged("Content_Type");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				this.RaisePropertyChanged("Filename");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Attachment_Encoding
		{
			get
			{
				return this.attachment_EncodingField;
			}
			set
			{
				this.attachment_EncodingField = value;
				this.RaisePropertyChanged("Attachment_Encoding");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Compressed
		{
			get
			{
				return this.compressedField;
			}
			set
			{
				this.compressedField = value;
				this.RaisePropertyChanged("Compressed");
			}
		}

		[XmlIgnore]
		public bool CompressedSpecified
		{
			get
			{
				return this.compressedFieldSpecified;
			}
			set
			{
				this.compressedFieldSpecified = value;
				this.RaisePropertyChanged("CompressedSpecified");
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
