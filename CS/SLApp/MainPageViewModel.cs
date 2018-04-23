using System;
using System.ComponentModel;
using System.Windows.Input;
using DevExpress.Xpf.Mvvm;
using DevExpress.Xpf.Printing;

namespace SLApp {
    public class MainPageViewModel : INotifyPropertyChanged {
        public ReportPreviewModel PreviewModel { get; private set; }
        public ReportPreviewModel PopupPreviewModel { get; set; }
        public DelegateCommand LinkClickedCommand { get; set; }
        public DelegateCommand ShowProductsCommand { get; set; }

        string _linkText;
        public string LinkText {
            get { return _linkText; }
            set {
                if(_linkText != value) {
                    _linkText = value;
                    OnPropertyChanged("LinkText");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainPageViewModel class.
        /// </summary>
        public MainPageViewModel() {
            PreviewModel = new ReportPreviewModel {
                ServiceUri = "../ReportService.svc",
                ReportName = "Reports.OrderReport"
            };
            PreviewModel.PreviewClick += PreviewModel_PreviewClick;
            PreviewModel.PreviewMouseMove += PreviewModel_PreviewMouseMove;

            LinkClickedCommand = new DelegateCommand(LinkClicked);
            ShowProductsCommand = new DelegateCommand(ShowProducts);
        }


        void ShowProducts() {
            var model = new ReportPreviewModel {
                ServiceUri = "../ReportService.svc",
                ReportName = "Reports.ProductReport"
            };
            var window = new DocumentPreviewWindow { Model = model };
            window.Show();
            model.CreateDocument();
        }

        void LinkClicked() {
            if(PreviewModel.ReportName != "Reports.InvoiceReport")
                return;
            PreviewModel.Clear();
            PreviewModel.ReportName = "Reports.OrderReport";
            PreviewModel.CreateDocument();

            LinkText = "";
        }

        protected void PreviewModel_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if(!string.IsNullOrEmpty(e.ElementTag))
                e.Element.Cursor = Cursors.Hand;
        }

        protected void PreviewModel_PreviewClick(object sender, PreviewClickEventArgs e) {
            int orderId;
            if(!int.TryParse(e.ElementTag, out orderId))
                return;

            LinkText = "Go Back";

            PreviewModel.ReportName = "Reports.InvoiceReport";
            PreviewModel.IsDocumentMapVisible = false;

            PreviewModel.Clear();
            PreviewModel.Parameters["OrderId"].Value = orderId;

            PreviewModel.CreateDocument();
        }

        public void OnPropertyChanged(string property) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
