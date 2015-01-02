Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
	Public Class MarketTrade
		''' <summary>
		'''A unique ID for the trade
		''' </summary>
		<JsonProperty("tradeid")> _
		Public Property Tradeid() As String
			Get
				Return m_Tradeid
			End Get
			Set
				m_Tradeid = Value
			End Set
		End Property
		Private m_Tradeid As String

		''' <summary>
		'''Server datetime trade occurred
		''' </summary>
		<JsonProperty("datetime")> _
		Public Property Datetime() As String
			Get
				Return m_Datetime
			End Get
			Set
				m_Datetime = Value
			End Set
		End Property
		Private m_Datetime As String

		''' <summary>
		'''The price the trade occurred at
		''' </summary>
		<JsonProperty("tradeprice")> _
		Public Property Tradeprice() As String
			Get
				Return m_Tradeprice
			End Get
			Set
				m_Tradeprice = Value
			End Set
		End Property
		Private m_Tradeprice As String

		''' <summary>
		'''Quantity traded
		''' </summary>
		<JsonProperty("quantity")> _
		Public Property Quantity() As String
			Get
				Return m_Quantity
			End Get
			Set
				m_Quantity = Value
			End Set
		End Property
		Private m_Quantity As String

		''' <summary>
		'''Total value of trade (tradeprice * quantity)
		''' </summary>
		<JsonProperty("total")> _
		Public Property Total() As String
			Get
				Return m_Total
			End Get
			Set
				m_Total = Value
			End Set
		End Property
		Private m_Total As String

		''' <summary>
		'''The type of order which initiated this trade
		''' </summary>
		<JsonProperty("initiate_ordertype")> _
		Public Property InitiateOrdertype() As String
			Get
				Return m_InitiateOrdertype
			End Get
			Set
				m_InitiateOrdertype = Value
			End Set
		End Property
		Private m_InitiateOrdertype As String
	End Class
End Namespace
