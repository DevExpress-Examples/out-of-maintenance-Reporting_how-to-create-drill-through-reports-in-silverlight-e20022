Imports Microsoft.VisualBasic
Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core.Commands
Imports System.Linq

Namespace SLApp
	Public Class MainPageViewModel
		Implements INotifyPropertyChanged
		Private _previewModel As ReportPreviewModel
		Public ReadOnly Property PreviewModel() As ReportPreviewModel
			Get
				Return _previewModel
			End Get
		End Property

		Private _popupPreviewModel As ReportPreviewModel
		Public ReadOnly Property PopupPreviewModel() As ReportPreviewModel
			Get
				Return _popupPreviewModel
			End Get
		End Property

		Private ReadOnly _linkClickedCommand As DelegateCommand(Of Object)
		Public ReadOnly Property LinkClickedCommand() As DelegateCommand(Of Object)
			Get
				Return _linkClickedCommand
			End Get
		End Property

		Private ReadOnly _showProductsCommand As DelegateCommand(Of Object)
		Public ReadOnly Property ShowProductsCommand() As DelegateCommand(Of Object)
			Get
				Return _showProductsCommand
			End Get
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


		Private _orderId As Integer
		Public Property OrderId() As Integer
			Get
				Return _orderId
			End Get
			Set(ByVal value As Integer)
				If _orderId <> value Then
					_orderId = value
					OnPropertyChanged("OrderId")
				End If
			End Set
		End Property
		''' <summary>
		''' Initializes a new instance of the MainPageViewModel class.
		''' </summary>
		Public Sub New()
			_previewModel = New ReportPreviewModel With {.ServiceUri = "../ReportService.svc", .ReportName = "Reports.OrderReport"}

			_popupPreviewModel = New ReportPreviewModel With {.ServiceUri = "../ReportService.svc", .ReportName = "Reports.ProductReport"}

			AddHandler _previewModel.PreviewClick, AddressOf previewModel_PreviewClick
			AddHandler _previewModel.PreviewMouseMove, AddressOf previewModel_PreviewMouseMove
			AddHandler _previewModel.RequestDefaultParameterValues, AddressOf previewModel_RequestDefaultParameterValues

			OrderId = 0
			_linkClickedCommand = New DelegateCommand(Of Object)(AddressOf LinkClicked)
			_showProductsCommand = New DelegateCommand(Of Object)(AddressOf ShowProducts)
		End Sub


		Protected Friend Sub ShowProducts(ByVal obj As Object)
			Dim doc = New DocumentPreviewWindow With {.Model = _popupPreviewModel, .Name = "PopupPreview"}
			doc.Model.CreateDocument()
			doc.Preview.AutoCreateDocument = True
			doc.Show()
		End Sub

		Protected Friend Sub LinkClicked(ByVal o As Object)
			If _previewModel.ReportName = "Reports.InvoiceReport" Then
				_previewModel.ReportName = "Reports.OrderReport"
				_previewModel.CreateDocument()

				LinkText = ""
			End If
		End Sub

		Protected Friend Sub previewModel_RequestDefaultParameterValues(ByVal sender As Object, ByVal e As EventArgs)
			If _previewModel.ReportName = "Reports.InvoiceReport" Then
				_previewModel.Parameters("OrderId").Value = OrderId
			End If
		End Sub

		Protected Sub previewModel_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag IsNot Nothing AndAlso (Not e.ElementTag.Equals(String.Empty)) Then
				e.Control.Cursor = Cursors.Hand
			End If
		End Sub

		Protected Sub previewModel_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag IsNot Nothing AndAlso (Not e.ElementTag.Equals(String.Empty)) Then
				OrderId = Integer.Parse(e.ElementTag)
				LinkText = "Go Back"

				_previewModel.ReportName = "Reports.InvoiceReport"
				_previewModel.IsDocumentMapVisible = False

				If _previewModel.Parameters.Count > 0 Then
					_previewModel.Parameters("OrderId").Value = OrderId
				End If

				_previewModel.CreateDocument()
			End If
		End Sub

		Public Overridable Sub OnPropertyChanged(ByVal [property] As String)
			Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
			If handler IsNot Nothing Then
				handler(Me, New PropertyChangedEventArgs([property]))
			End If
		End Sub
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	End Class
End Namespace
