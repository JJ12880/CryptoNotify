Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
    Public Class BaseResponse
        ''' <summary>
        ''' Was the call successful?
        ''' </summary>
        <JsonProperty(PropertyName:="success")> _
        Public Property Success() As String
            Get
                Return m_Success
            End Get
            Set(value As String)
                m_Success = Value
            End Set
        End Property
        Private m_Success As String

        ''' <summary>
        ''' Text description of any errors
        ''' </summary>
        <JsonProperty(PropertyName:="error")> _
        Public Property [Error]() As String
            Get
                Return m_Error
            End Get
            Set(value As String)
                m_Error = Value
            End Set
        End Property
        Private m_Error As String
    End Class
End Namespace
