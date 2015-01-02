Imports Newtonsoft.Json

Namespace CryptoWorks.Cryptsy.Entities
	Public Class OrderResponse
		Inherits BaseResponse
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

		<JsonProperty("moreinfo")> _
		Public Property Moreinfo() As String
			Get
				Return m_Moreinfo
			End Get
			Set
				m_Moreinfo = Value
			End Set
		End Property
		Private m_Moreinfo As String
	End Class
End Namespace
