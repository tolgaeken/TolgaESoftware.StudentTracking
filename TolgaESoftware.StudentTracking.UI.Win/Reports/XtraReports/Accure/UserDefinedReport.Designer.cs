namespace TolgaESoftware.StudentTracking.UI.Win.Reports.XtraReports.Accure
{
    partial class UserDefinedReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Epos_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Contact_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Discount_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Payment_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Refund_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Service_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Student_Informations = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Epos_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contact_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refund_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Service_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Informations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // Epos_Informations
            // 
            this.Epos_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.EposInformationsReport);
            this.Epos_Informations.Name = "Epos_Informations";
            // 
            // Contact_Informations
            // 
            this.Contact_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.ContactInformationsReport);
            this.Contact_Informations.Name = "Contact_Informations";
            // 
            // Discount_Informations
            // 
            this.Discount_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.DiscountInformationsReport);
            this.Discount_Informations.Name = "Discount_Informations";
            // 
            // Payment_Informations
            // 
            this.Payment_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.PaymentInformationsReport);
            this.Payment_Informations.Name = "Payment_Informations";
            // 
            // Refund_Informations
            // 
            this.Refund_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.RefundInformationsReport);
            this.Refund_Informations.Name = "Refund_Informations";
            // 
            // Service_Informations
            // 
            this.Service_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.ServiceInformationsReport);
            this.Service_Informations.Name = "Service_Informations";
            // 
            // Student_Informations
            // 
            this.Student_Informations.DataSource = typeof(TolgaESoftware.StudentTracking.Model.DataTransferObject.StudentReport);
            this.Student_Informations.Name = "Student_Informations";
            // 
            // UserDefinedReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Epos_Informations,
            this.Contact_Informations,
            this.Discount_Informations,
            this.Payment_Informations,
            this.Refund_Informations,
            this.Service_Informations,
            this.Student_Informations});
            this.DataSource = this.Student_Informations;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Header = "Kullanıcı Tanımlı Rapor";
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.Epos_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contact_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refund_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Service_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Informations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Epos_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Contact_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Discount_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Payment_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Refund_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Service_Informations;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Student_Informations;
    }
}
