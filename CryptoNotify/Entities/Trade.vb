Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
    Public Class Trade
        ''' <summary>
        ''' An integer identifier for this trade
        ''' </summary>
        <JsonProperty("tradeid")> _
        Public Property Tradeid() As String
            Get
                Return m_Tradeid
            End Get
            Set(value As String)
                m_Tradeid = Value
            End Set
        End Property
        Private m_Tradeid As String

        ''' <summary>
        ''' Type of trade (Buy/Sell)
        ''' </summary>
        <JsonProperty("tradetype")> _
        Public Property Tradetype() As String
            Get
                Return m_Tradetype
            End Get
            Set(value As String)
                m_Tradetype = Value
            End Set
        End Property
        Private m_Tradetype As String

        ''' <summary>
        ''' Server datetime trade occurred
        ''' </summary>
        <JsonProperty("datetime")> _
        Public Property Datetime() As String
            Get
                Return m_Datetime
            End Get
            Set(value As String)
                m_Datetime = Value
            End Set
        End Property
        Private m_Datetime As String

        ''' <summary>
        ''' The price the trade occurred at
        ''' </summary>
        <JsonProperty("tradeprice")> _
        Public Property Tradeprice() As String
            Get
                Return m_Tradeprice
            End Get
            Set(value As String)
                m_Tradeprice = Value
            End Set
        End Property
        Private m_Tradeprice As String

        ''' <summary>
        ''' Quantity traded
        ''' </summary>
        <JsonProperty("quantity")> _
        Public Property Quantity() As String
            Get
                Return m_Quantity
            End Get
            Set(value As String)
                m_Quantity = Value
            End Set
        End Property
        Private m_Quantity As String

        ''' <summary>
        ''' Total value of trade (tradeprice * quantity) - Does not include fees
        ''' </summary>
        <JsonProperty("total")> _
        Public Property Total() As Decimal
            Get
                Return m_Total
            End Get
            Set(value As Decimal)
                m_Total = Value
            End Set
        End Property
        Private m_Total As Decimal

        ''' <summary>
        ''' Fee Charged for this Trade
        ''' </summary>
        <JsonProperty("fee")> _
        Public Property Fee() As Decimal
            Get
                Return m_Fee
            End Get
            Set(value As Decimal)
                m_Fee = Value
            End Set
        End Property
        Private m_Fee As Decimal

        ''' <summary>
        ''' The type of Order which initiated this trade
        ''' </summary>
        <JsonProperty("initiate_ordertype")> _
        Public Property InitiateOrdertype() As String
            Get
                Return m_InitiateOrdertype
            End Get
            Set(value As String)
                m_InitiateOrdertype = Value
            End Set
        End Property
        Private m_InitiateOrdertype As String

        ''' <summary>
        ''' Original Order id this trade was executed against
        ''' </summary>
        <JsonProperty("order_id")> _
        Public Property OrderId() As String
            Get
                Return m_OrderId
            End Get
            Set(value As String)
                m_OrderId = Value
            End Set
        End Property
        Private m_OrderId As String
    End Class
End Namespace
