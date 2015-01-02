Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
    Public Class Transaction
        ''' <summary>
        ''' Name of currency account
        ''' </summary>
        <JsonProperty("currency")> _
        Public Property Currency() As String
            Get
                Return m_Currency
            End Get
            Set(value As String)
                m_Currency = Value
            End Set
        End Property
        Private m_Currency As String

        ''' <summary>
        ''' timestamp	The timestamp the activity posted
        ''' </summary>
        <JsonProperty("timestamp")> _
        Public Property Timestamp() As String
            Get
                Return m_Timestamp
            End Get
            Set(value As String)
                m_Timestamp = Value
            End Set
        End Property
        Private m_Timestamp As String

        ''' <summary>
        ''' The datetime the activity posted
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
        ''' Server timezone
        ''' </summary>
        <JsonProperty("timezone")> _
        Public Property Timezone() As String
            Get
                Return m_Timezone
            End Get
            Set(value As String)
                m_Timezone = Value
            End Set
        End Property
        Private m_Timezone As String

        ''' <summary>
        ''' Type of activity. (Deposit / Withdrawal)
        ''' </summary>
        <JsonProperty("type")> _
        Public Property Type() As String
            Get
                Return m_Type
            End Get
            Set(value As String)
                m_Type = Value
            End Set
        End Property
        Private m_Type As String

        ''' <summary>
        ''' Address to which the deposit posted or Withdrawal was sent
        ''' </summary>
        <JsonProperty("address")> _
        Public Property Address() As String
            Get
                Return m_Address
            End Get
            Set(value As String)
                m_Address = Value
            End Set
        End Property
        Private m_Address As String

        ''' <summary>
        ''' Amount of transaction (Not including any fees)
        ''' </summary>
        <JsonProperty("amount")> _
        Public Property Amount() As String
            Get
                Return m_Amount
            End Get
            Set(value As String)
                m_Amount = Value
            End Set
        End Property
        Private m_Amount As String

        ''' <summary>
        ''' Fee (If any) Charged for this Transaction (Generally only on Withdrawals)
        ''' </summary>
        <JsonProperty("Fee")> _
        Public Property Fee() As String
            Get
                Return m_Fee
            End Get
            Set(value As String)
                m_Fee = Value
            End Set
        End Property
        Private m_Fee As String

        ''' <summary>
        ''' Network Transaction ID (If available)
        ''' </summary>
        <JsonProperty("trxid")> _
        Public Property Trxid() As String
            Get
                Return m_Trxid
            End Get
            Set(value As String)
                m_Trxid = Value
            End Set
        End Property
        Private m_Trxid As String


    End Class
End Namespace
