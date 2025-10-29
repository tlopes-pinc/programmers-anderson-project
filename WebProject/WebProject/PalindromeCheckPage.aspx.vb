Imports System.Web.Services

Public Class PalindromeCheckPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    Public Shared Function IsPalindrome(input As Long) As Boolean
        If input < 0 Then
            Return False
        End If

        Dim text As String = input.ToString()
        Dim reversed As Char() = text.ToCharArray()
        Array.Reverse(reversed)

        Return input = New String(reversed).ToLower()
    End Function
End Class