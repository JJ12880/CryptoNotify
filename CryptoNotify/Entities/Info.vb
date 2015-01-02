Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace CryptoWorks.Cryptsy.Entities
    Public Class Info
        ''' <summary>
        ''' Array of currencies and the balances availalbe for each
        ''' </summary>
        <JsonProperty(PropertyName:="balances_available")> _
        Public Property BalancesAvailable() As Object
            Get
                Return m_BalancesAvailable
            End Get
            Set(value As Object)
                m_BalancesAvailable = value
            End Set
        End Property
        Private m_BalancesAvailable As Object

        ''' <summary>
        ''' Array of currencies and the amounts currently on hold for open orders
        ''' </summary>
        <JsonProperty(PropertyName:="balances_hold")> _
        Public Property BalancesHold() As Object
            Get
                Return m_BalancesHold
            End Get
            Set(value As Object)
                m_BalancesHold = value
            End Set
        End Property
        Private m_BalancesHold As Object

        ''' <summary>
        ''' Current server timestamp
        ''' </summary>
        <JsonProperty(PropertyName:="servertimestamp")> _
        Public Property Servertimestamp() As String
            Get
                Return m_Servertimestamp
            End Get
            Set(value As String)
                m_Servertimestamp = Value
            End Set
        End Property
        Private m_Servertimestamp As String

        ''' <summary>
        ''' Current timezone for the server
        ''' </summary>
        <JsonProperty(PropertyName:="servertimezone")> _
        Public Property Servertimezone() As String
            Get
                Return m_Servertimezone
            End Get
            Set(value As String)
                m_Servertimezone = Value
            End Set
        End Property
        Private m_Servertimezone As String

        ''' <summary>
        ''' Current date/time on the server
        ''' </summary>
        <JsonProperty(PropertyName:="serverdatetime")> _
        Public Property Serverdatetime() As String
            Get
                Return m_Serverdatetime
            End Get
            Set(value As String)
                m_Serverdatetime = Value
            End Set
        End Property
        Private m_Serverdatetime As String

        ''' <summary>
        ''' Count of open orders on your account
        ''' </summary>
        <JsonProperty(PropertyName:="openordercount")> _
        Public Property Openordercount() As String
            Get
                Return m_Openordercount
            End Get
            Set(value As String)
                m_Openordercount = Value
            End Set
        End Property
        Private m_Openordercount As String
    End Class
End Namespace
