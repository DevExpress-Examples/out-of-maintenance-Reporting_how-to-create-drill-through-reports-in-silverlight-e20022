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
	End Class
End Namespace
