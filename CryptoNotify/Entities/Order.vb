Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
	Public Class Order
		''' <summary>
		''' ID for this Order
		''' </summary>
		<JsonProperty("orderid")> _
		Public Property Orderid() As String
			Get
				Return m_Orderid
			End Get
			Set
				m_Orderid = Value
			End Set
		End Property
		Private m_Orderid As String

		''' <summary>
		''' The Markets ID this Order was created for
		''' </summary>
		<JsonProperty("marketid")> _
		Public Property Marketid() As String
			Get
				Return m_Marketid
			End Get
			Set
				m_Marketid = Value
			End Set
		End Property
		Private m_Marketid As String

		''' <summary>
		''' Datetime the Order was created
		''' </summary>
		<JsonProperty("created")> _
		Public Property Created() As DateTime
			Get
				Return m_Created
			End Get
			Set
				m_Created = Value
			End Set
		End Property
		Private m_Created As DateTime

		''' <summary>
		''' Type of Order (Buy/Sell)
		''' </summary>
		<JsonProperty("ordertype")> _
		Public Property Ordertype() As String
			Get
				Return m_Ordertype
			End Get
			Set
				m_Ordertype = Value
			End Set
		End Property
		Private m_Ordertype As String
		''' <summary>
		''' The price per unit for this Order
		''' </summary>
		<JsonProperty("price")> _
		Public Property Price() As Decimal
			Get
				Return m_Price
			End Get
			Set
				m_Price = Value
			End Set
		End Property
		Private m_Price As Decimal

		''' <summary>
		''' Quantity remaining for this Order
		''' </summary>
		<JsonProperty("quantity")> _
		Public Property Quantity() As Decimal
			Get
				Return m_Quantity
			End Get
			Set
				m_Quantity = Value
			End Set
		End Property
		Private m_Quantity As Decimal

		''' <summary>
		''' Total value of Order (price * quantity)
		''' </summary>
		<JsonProperty("total")> _
		Public Property Total() As Decimal
			Get
				Return m_Total
			End Get
			Set
				m_Total = Value
			End Set
		End Property
		Private m_Total As Decimal

		''' <summary>
		''' Original Total Order Quantity
		''' </summary>
		<JsonProperty("orig_quantity")> _
		Public Property OrigQuantity() As Decimal
			Get
				Return m_OrigQuantity
			End Get
			Set
				m_OrigQuantity = Value
			End Set
		End Property
		Private m_OrigQuantity As Decimal
	End Class
End Namespace
