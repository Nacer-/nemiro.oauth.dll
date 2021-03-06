﻿Imports Nemiro.OAuth

Public Class MyClient
  Inherits OAuth2Client

  ''' <summary>
  ''' Unique provider name: <b>MyClient</b>.
  ''' </summary>
  Public Overrides ReadOnly Property ProviderName As String
    Get
      Return "MyClient"
    End Get
  End Property

  ''' <summary>
  ''' Initializes a new instance of the class.
  ''' </summary>
  ''' <param name="clientId">The Client ID obtained from the provider website.</param>
  ''' <param name="clientSecret">The Client Secret obtained from the provider website.</param>
  Public Sub New(clientId As String, clientSecret As String)
    MyBase.New("https://example.org/oauth", "https://example.org/oauth/access_token", clientId, clientSecret)
  End Sub

  ''' <summary>
  ''' Gets the user details.
  ''' </summary>
  Public Overrides Function GetUserInfo() As UserInfo
    Return New UserInfo(UniValue.Empty, Nothing)
  End Function

End Class