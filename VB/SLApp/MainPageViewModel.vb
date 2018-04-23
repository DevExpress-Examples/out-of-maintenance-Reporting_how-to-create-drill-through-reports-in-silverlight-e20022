Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Xpf.Mvvm
Imports DevExpress.Xpf.Printing

Namespace SLApp
	Public Class MainPageViewModel
		Implements INotifyPropertyChanged
		Private privatePreviewModel As ReportPreviewModel
		Public Property PreviewModel() As ReportPreviewModel
			Get
				Return privatePreviewModel
			End Get
			Private Set(ByVal value As ReportPreviewModel)
				privatePreviewModel = value
			End Set
		End Property
		Private privatePopupPreviewModel As ReportPreviewModel
		Public Property PopupPreviewModel() As ReportPreviewModel
			Get
				Return privatePopupPreviewModel
			End Get
			Set(ByVal value As ReportPreviewModel)
				privatePopupPreviewModel = value
			End Set
		End Property
		Private privateLinkClickedCommand As DelegateCommand
		Public Property LinkClickedCommand() As DelegateCommand
			Get
				Return privateLinkClickedCommand
			End Get
			Set(ByVal value As DelegateCommand)
				privateLinkClickedCommand = value
			End Set
		End Property
		Private privateShowProductsCommand As DelegateCommand
		Public Property ShowProductsCommand() As DelegateCommand
			Get
				Return privateShowProductsCommand
			End Get
			Set(ByVal value As DelegateCommand)
				privateShowProductsCommand = value
			End Set
		End Property

		Private _linkText As String
		Public Property LinkText() As String
			Get
				Return _linkText
			End Get
			Set(ByVal value As String)
				If _linkText <> value Then
					_linkText = value
					OnPropertyChanged("LinkText")
				End If
			End Set
		End Property

		''' <summary>
		''' Initializes a new instance of the MainPageViewModel class.
		''' </summary>
		Public Sub New()
			PreviewModel = New ReportPreviewModel With {.ServiceUri = "../ReportService.svc", .ReportName = "Reports.OrderReport"}
			AddHandler PreviewModel.PreviewClick, AddressOf PreviewModel_PreviewClick
			AddHandler PreviewModel.PreviewMouseMove, AddressOf PreviewModel_PreviewMouseMove

			LinkClickedCommand = New DelegateCommand(AddressOf LinkClicked)
			ShowProductsCommand = New DelegateCommand(AddressOf ShowProducts)
		End Sub


		Private Sub ShowProducts()
			Dim model = New ReportPreviewModel With {.ServiceUri = "../ReportService.svc", .ReportName = "Reports.ProductReport"}
			Dim window = New DocumentPreviewWindow With {.Model = model}
			window.Show()
			model.CreateDocument()
		End Sub

		Private Sub LinkClicked()
			If PreviewModel.ReportName <> "Reports.InvoiceReport" Then
				Return
			End If
			PreviewModel.Clear()
			PreviewModel.ReportName = "Reports.OrderReport"
			PreviewModel.CreateDocument()

			LinkText = ""
		End Sub

		Protected Sub PreviewModel_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If (Not String.IsNullOrEmpty(e.ElementTag)) Then
				e.Element.Cursor = Cursors.Hand
			End If
		End Sub

		Protected Sub PreviewModel_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			Dim orderId As Integer
			If (Not Integer.TryParse(e.ElementTag, orderId)) Then
				Return
			End If

			LinkText = "Go Back"

			PreviewModel.ReportName = "Reports.InvoiceReport"
			PreviewModel.IsDocumentMapVisible = False

			PreviewModel.Clear()
			PreviewModel.Parameters("OrderId").Value = orderId

			PreviewModel.CreateDocument()
		End Sub

		Public Sub OnPropertyChanged(ByVal [property] As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	End Class
End Namespace
