using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Core.Commands;
using System.Linq;

namespace SLApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ReportPreviewModel _previewModel;
        public ReportPreviewModel PreviewModel
        {
            get
            {
                return _previewModel;
            }
        }

        private ReportPreviewModel _popupPreviewModel;
        public ReportPreviewModel PopupPreviewModel
        {
            get
            {
                return _popupPreviewModel;
            }
        }

        private readonly DelegateCommand<object> _linkClickedCommand;
        public DelegateCommand<object> LinkClickedCommand
        {
            get
            {
                return _linkClickedCommand;
            }
        }

        private readonly DelegateCommand<object> _showProductsCommand;
        public DelegateCommand<object> ShowProductsCommand
        {
            get
            {
                return _showProductsCommand;
            }
        }

        private string _linkText;
        public string LinkText
        {
            get { return _linkText; }
            set
            {
                if (_linkText != value)
                {
                    _linkText = value;
                    OnPropertyChanged("LinkText");
                }
            }
        }


        private int _orderId;
        public int OrderId
        {
            get
            {
                return _orderId;
            }
            set
            {
                if (_orderId != value)
                {
                    _orderId = value;
                    OnPropertyChanged("OrderId");
                }
            }
        }
        /// <summary>
        /// Initializes a new instance of the MainPageViewModel class.
        /// </summary>
        public MainPageViewModel()
        {
            _previewModel = new ReportPreviewModel
            {
                ServiceUri = "../ReportService.svc",
                ReportName = "Reports.OrderReport"
            };

            _popupPreviewModel = new ReportPreviewModel
            {
                ServiceUri = "../ReportService.svc",
                ReportName = "Reports.ProductReport",
            };

            _previewModel.PreviewClick += previewModel_PreviewClick;
            _previewModel.PreviewMouseMove += previewModel_PreviewMouseMove;
            _previewModel.RequestDefaultParameterValues += previewModel_RequestDefaultParameterValues;

            OrderId = 0;
            _linkClickedCommand = new DelegateCommand<object>(LinkClicked);
            _showProductsCommand = new DelegateCommand<object>(ShowProducts);
        }


        protected internal void ShowProducts(object obj)
        {
            var doc = new DocumentPreviewWindow
            {
                Model = _popupPreviewModel,
                Name = "PopupPreview",
            };
            doc.Model.CreateDocument();
            doc.Preview.AutoCreateDocument = true;
            doc.Show();
        }

        protected internal void LinkClicked(object o)
        {
            if (_previewModel.ReportName == "Reports.InvoiceReport")
            {
                _previewModel.ReportName = "Reports.OrderReport";
                _previewModel.CreateDocument();
                
                LinkText = "";
            }
        }

        protected internal void previewModel_RequestDefaultParameterValues(object sender, EventArgs e)
        {
            if (_previewModel.ReportName == "Reports.InvoiceReport")
                _previewModel.Parameters["OrderId"].Value = OrderId;
        }

        protected void previewModel_PreviewMouseMove(object sender, PreviewClickEventArgs e)
        {
            if (e.ElementTag != null && !e.ElementTag.Equals(string.Empty))
                e.Control.Cursor = Cursors.Hand;
        }

        protected void previewModel_PreviewClick(object sender, PreviewClickEventArgs e)
        {
            if (e.ElementTag != null && !e.ElementTag.Equals(string.Empty))
            {
                OrderId = int.Parse(e.ElementTag);
                LinkText = "Go Back";

                _previewModel.ReportName = "Reports.InvoiceReport";
                _previewModel.IsDocumentMapVisible = false;

                if (_previewModel.Parameters.Count > 0)
                    _previewModel.Parameters["OrderId"].Value = OrderId;

                _previewModel.CreateDocument();
            }
        }

        public virtual void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
