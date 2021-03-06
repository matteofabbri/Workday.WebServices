using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Stock_Request_Request_CriteriaType : INotifyPropertyChanged
	{
		private LocationObjectType[] inventory_Site_ReferenceField;

		private string inventory_Stock_Request_IDField;

		private DateTime order_Date_On_or_AfterField;

		private bool order_Date_On_or_AfterFieldSpecified;

		private DateTime order_Date_On_or_BeforeField;

		private bool order_Date_On_or_BeforeFieldSpecified;

		private DateTime targeted_Fulfillment_Date_On_or_AfterField;

		private bool targeted_Fulfillment_Date_On_or_AfterFieldSpecified;

		private DateTime targeted_Fulfillment_Date_On_or_BeforeField;

		private bool targeted_Fulfillment_Date_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] inventory_Fulfillment_Status_ReferenceField;

		private Inventory_Stock_Request_Transaction_TypeObjectType[] stock_Request_Transaction_Type_ReferenceField;

		private LocationObjectType[] transfer_to_Site_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType[] inventory_Stock_Request_Type_ReferenceField;

		private LocationObjectType[] inventory_Par_Location_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private LocationObjectType[] deliver_To_Location_ReferenceField;

		private WorkerObjectType[] created_by_Worker_ReferenceField;

		private bool include_High_Priority_OnlyField;

		private bool include_High_Priority_OnlyFieldSpecified;

		private bool include_InTransit_OnlyField;

		private bool include_InTransit_OnlyFieldSpecified;

		private bool exclude_CanceledField;

		private bool exclude_CanceledFieldSpecified;

		private bool exclude_ClosedField;

		private bool exclude_ClosedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Site_Reference", Order = 0)]
		public LocationObjectType[] Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Inventory_Stock_Request_ID
		{
			get
			{
				return this.inventory_Stock_Request_IDField;
			}
			set
			{
				this.inventory_Stock_Request_IDField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Order_Date_On_or_After
		{
			get
			{
				return this.order_Date_On_or_AfterField;
			}
			set
			{
				this.order_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Order_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_AfterSpecified
		{
			get
			{
				return this.order_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Order_Date_On_or_Before
		{
			get
			{
				return this.order_Date_On_or_BeforeField;
			}
			set
			{
				this.order_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Order_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.order_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Targeted_Fulfillment_Date_On_or_After
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_AfterField;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Targeted_Fulfillment_Date_On_or_AfterSpecified
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Targeted_Fulfillment_Date_On_or_Before
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_BeforeField;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Targeted_Fulfillment_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Inventory_Fulfillment_Status_Reference", Order = 6)]
		public Document_StatusObjectType[] Inventory_Fulfillment_Status_Reference
		{
			get
			{
				return this.inventory_Fulfillment_Status_ReferenceField;
			}
			set
			{
				this.inventory_Fulfillment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Fulfillment_Status_Reference");
			}
		}

		[XmlElement("Stock_Request_Transaction_Type_Reference", Order = 7)]
		public Inventory_Stock_Request_Transaction_TypeObjectType[] Stock_Request_Transaction_Type_Reference
		{
			get
			{
				return this.stock_Request_Transaction_Type_ReferenceField;
			}
			set
			{
				this.stock_Request_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Request_Transaction_Type_Reference");
			}
		}

		[XmlElement("Transfer_to_Site_Reference", Order = 8)]
		public LocationObjectType[] Transfer_to_Site_Reference
		{
			get
			{
				return this.transfer_to_Site_ReferenceField;
			}
			set
			{
				this.transfer_to_Site_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_to_Site_Reference");
			}
		}

		[XmlElement("Inventory_Stock_Request_Type_Reference", Order = 9)]
		public Inventory_Stock_Request_TypeObjectType[] Inventory_Stock_Request_Type_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Type_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Type_Reference");
			}
		}

		[XmlElement("Inventory_Par_Location_Reference", Order = 10)]
		public LocationObjectType[] Inventory_Par_Location_Reference
		{
			get
			{
				return this.inventory_Par_Location_ReferenceField;
			}
			set
			{
				this.inventory_Par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Par_Location_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement("Deliver_To_Location_Reference", Order = 12)]
		public LocationObjectType[] Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement("Created_by_Worker_Reference", Order = 13)]
		public WorkerObjectType[] Created_by_Worker_Reference
		{
			get
			{
				return this.created_by_Worker_ReferenceField;
			}
			set
			{
				this.created_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Worker_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Include_High_Priority_Only
		{
			get
			{
				return this.include_High_Priority_OnlyField;
			}
			set
			{
				this.include_High_Priority_OnlyField = value;
				this.RaisePropertyChanged("Include_High_Priority_Only");
			}
		}

		[XmlIgnore]
		public bool Include_High_Priority_OnlySpecified
		{
			get
			{
				return this.include_High_Priority_OnlyFieldSpecified;
			}
			set
			{
				this.include_High_Priority_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Include_High_Priority_OnlySpecified");
			}
		}

		[XmlElement("Include_In-Transit_Only", Order = 15)]
		public bool Include_InTransit_Only
		{
			get
			{
				return this.include_InTransit_OnlyField;
			}
			set
			{
				this.include_InTransit_OnlyField = value;
				this.RaisePropertyChanged("Include_InTransit_Only");
			}
		}

		[XmlIgnore]
		public bool Include_InTransit_OnlySpecified
		{
			get
			{
				return this.include_InTransit_OnlyFieldSpecified;
			}
			set
			{
				this.include_InTransit_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Include_InTransit_OnlySpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Exclude_Canceled
		{
			get
			{
				return this.exclude_CanceledField;
			}
			set
			{
				this.exclude_CanceledField = value;
				this.RaisePropertyChanged("Exclude_Canceled");
			}
		}

		[XmlIgnore]
		public bool Exclude_CanceledSpecified
		{
			get
			{
				return this.exclude_CanceledFieldSpecified;
			}
			set
			{
				this.exclude_CanceledFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_CanceledSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Exclude_Closed
		{
			get
			{
				return this.exclude_ClosedField;
			}
			set
			{
				this.exclude_ClosedField = value;
				this.RaisePropertyChanged("Exclude_Closed");
			}
		}

		[XmlIgnore]
		public bool Exclude_ClosedSpecified
		{
			get
			{
				return this.exclude_ClosedFieldSpecified;
			}
			set
			{
				this.exclude_ClosedFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_ClosedSpecified");
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
