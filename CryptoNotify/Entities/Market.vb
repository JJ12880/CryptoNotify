Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
	Public Partial Class Market
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

		<JsonProperty("label")> _
		Public Property Label() As String
			Get
				Return m_Label
			End Get
			Set
				m_Label = Value
			End Set
		End Property
		Private m_Label As String

		<JsonProperty("primaryname")> _
		Public Property Primaryname() As String
			Get
				Return m_Primaryname
			End Get
			Set
				m_Primaryname = Value
			End Set
		End Property
		Private m_Primaryname As String

		<JsonProperty("primarycode")> _
		Public Property Primarycode() As String
			Get
				Return m_Primarycode
			End Get
			Set
				m_Primarycode = Value
			End Set
		End Property
		Private m_Primarycode As String

		<JsonProperty("secondaryname")> _
		Public Property Secondaryname() As String
			Get
				Return m_Secondaryname
			End Get
			Set
				m_Secondaryname = Value
			End Set
		End Property
		Private m_Secondaryname As String

		<JsonProperty("secondarycode")> _
		Public Property Secondarycode() As String
			Get
				Return m_Secondarycode
			End Get
			Set
				m_Secondarycode = Value
			End Set
		End Property
		Private m_Secondarycode As String

		<JsonProperty("sellorders")> _
		Public Property SellOrders() As List(Of Order)
			Get
				Return m_SellOrders
			End Get
			Set
				m_SellOrders = Value
			End Set
		End Property
		Private m_SellOrders As List(Of Order)

		<JsonProperty("buyorders")> _
		Public Property BuyOrders() As List(Of Order)
			Get
				Return m_BuyOrders
			End Get
			Set
				m_BuyOrders = Value
			End Set
		End Property
		Private m_BuyOrders As List(Of Order)

		''' <summary>
		''' Returns the highest Buy price
		''' </summary>
		Public ReadOnly Property HighestBuyPrice() As Decimal
			Get
				If BuyOrders IsNot Nothing Then
					If BuyOrders.Any() Then
						Return BuyOrders.FirstOrDefault().Price
					End If
				End If

				Throw New Exception("Order book is empty")
			End Get
		End Property
		''' <summary>
		''' Returns the Lowest Buy price
		''' </summary>
		Public ReadOnly Property LowestSellPrice() As Decimal
			Get
				If SellOrders IsNot Nothing Then
					If SellOrders.Any() Then
						Return SellOrders.FirstOrDefault().Price
					End If
				End If

				Throw New Exception("Order book is empty")
			End Get
		End Property

		''' <summary>
		''' The Base Price name
		''' </summary>
		Public ReadOnly Property BasePriceName() As String
			Get
                Dim parts = Label.Split({"/"}, StringSplitOptions.None)
				Return parts(0)
			End Get
		End Property

		''' <summary>
		''' The quote price name
		''' </summary>
		Public ReadOnly Property PriceQuoteName() As String
			Get
                Dim parts = Label.Split({"/"}, StringSplitOptions.None)
				Return parts(1)
			End Get
		End Property
	End Class
End Namespace
