Imports Microsoft.VisualBasic
Imports System
Imports Reports

Namespace WebForms
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			Dim prod As New ProductReport()
		End Sub

		Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
		End Sub
	End Class
End Namespace
