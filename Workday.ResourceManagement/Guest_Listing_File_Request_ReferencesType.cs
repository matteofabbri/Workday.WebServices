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
	public class Guest_Listing_File_Request_ReferencesType : INotifyPropertyChanged
	{
		private Guest_Listing_FileObjectType[] guest_Listing_File_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Guest_Listing_File_Reference", Order = 0)]
		public Guest_Listing_FileObjectType[] Guest_Listing_File_Reference
		{
			get
			{
				return this.guest_Listing_File_ReferenceField;
			}
			set
			{
				this.guest_Listing_File_ReferenceField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Reference");
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
