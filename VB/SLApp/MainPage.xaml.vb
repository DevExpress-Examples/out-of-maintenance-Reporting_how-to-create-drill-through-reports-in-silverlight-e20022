Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls

Namespace SLApp
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			DataContext = New MainPageViewModel()
		End Sub

		Private Sub hyperLinkBack_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)

		End Sub
	End Class
End Namespace
