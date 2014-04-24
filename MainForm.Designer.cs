namespace SelfDC
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.cmnuEdit = new System.Windows.Forms.MenuItem();
            this.cmnuDelete = new System.Windows.Forms.MenuItem();
            this.bcReader = new Symbol.Barcode2.Design.Barcode2();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuExport = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.panEdit = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQta = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListView();
            this.clCode = new System.Windows.Forms.ColumnHeader();
            this.clQta = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(4, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.Text = "Quantita\':";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(4, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.Text = "Codice:";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 295);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(314, 24);
            this.statusBar.Text = "statusBar";
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.Add(this.cmnuEdit);
            this.contextMenu.MenuItems.Add(this.cmnuDelete);
            // 
            // cmnuEdit
            // 
            this.cmnuEdit.Text = "Modifica";
            this.cmnuEdit.Click += new System.EventHandler(this.actEdit);
            // 
            // cmnuDelete
            // 
            this.cmnuDelete.Text = "Elimina";
            this.cmnuDelete.Click += new System.EventHandler(this.actDelete);
            // 
            // bcReader
            // 
            this.bcReader.Config.DecoderParameters.CODABAR = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.bcReader.Config.DecoderParameters.CODABARParams.NotisEditing = false;
            this.bcReader.Config.DecoderParameters.CODABARParams.Redundancy = true;
            this.bcReader.Config.DecoderParameters.CODE128 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.CODE128Params.EAN128 = true;
            this.bcReader.Config.DecoderParameters.CODE128Params.ISBT128 = true;
            this.bcReader.Config.DecoderParameters.CODE128Params.Other128 = true;
            this.bcReader.Config.DecoderParameters.CODE128Params.Redundancy = false;
            this.bcReader.Config.DecoderParameters.CODE39 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.Concatenation = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.FullAscii = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.Redundancy = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.bcReader.Config.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.bcReader.Config.DecoderParameters.CODE93 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.CODE93Params.Redundancy = false;
            this.bcReader.Config.DecoderParameters.D2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.D2OF5Params.Redundancy = true;
            this.bcReader.Config.DecoderParameters.EAN13 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.EAN8 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.bcReader.Config.DecoderParameters.I2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.bcReader.Config.DecoderParameters.I2OF5Params.Redundancy = true;
            this.bcReader.Config.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.bcReader.Config.DecoderParameters.I2OF5Params.VerifyCheckDigit = Symbol.Barcode2.Design.I2OF5.CheckDigitSchemes.Default;
            this.bcReader.Config.DecoderParameters.KOREAN_3OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.KOREAN_3OF5Params.Redundancy = true;
            this.bcReader.Config.DecoderParameters.MSI = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode2.Design.CheckDigitCounts.Default;
            this.bcReader.Config.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode2.Design.CheckDigitSchemes.Default;
            this.bcReader.Config.DecoderParameters.MSIParams.Redundancy = true;
            this.bcReader.Config.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.bcReader.Config.DecoderParameters.UPCA = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.bcReader.Config.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.bcReader.Config.DecoderParameters.UPCE0 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.bcReader.Config.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.bcReader.Config.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Symbol.Barcode2.Design.DPM_MODE.DPM_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Symbol.Barcode2.Design.FOCUS_MODE.FOCUS_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Symbol.Barcode2.Design.FOCUS_POSITION.FOCUS_POSITION_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Symbol.Barcode2.Design.ILLUMINATION_MODE.ILLUMINATION_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Symbol.Barcode2.Design.INVERSE1D_MODE.INVERSE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Symbol.Barcode2.Design.PICKLIST_MODE.PICKLIST_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Symbol.Barcode2.Design.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Symbol.Barcode2.Design.VIEWFINDER_MODE.VIEWFINDER_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamWidth = Symbol.Barcode2.Design.BEAM_WIDTH.DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Symbol.Barcode2.Design.DBP_MODE.DBP_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Symbol.Barcode2.Design.RASTER_MODE.RASTER_MODE_DEFAULT;
            this.bcReader.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.bcReader.Config.ScanParameters.BeepFrequency = 2670;
            this.bcReader.Config.ScanParameters.BeepTime = 200;
            this.bcReader.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
            this.bcReader.Config.ScanParameters.LedTime = 3000;
            this.bcReader.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
            this.bcReader.Config.ScanParameters.WaveFile = "";
            this.bcReader.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
            this.bcReader.EnableScanner = false;
            this.bcReader.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.bcReader_OnScan);
            this.bcReader.OnStatus += new Symbol.Barcode2.Design.Barcode2.OnStatusEventHandler(this.bcReader_OnStatus);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.mnuFile);
            this.mainMenu.MenuItems.Add(this.menuItem5);
            this.mainMenu.MenuItems.Add(this.menuItem2);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.Add(this.mnuExport);
            this.mnuFile.MenuItems.Add(this.menuItem1);
            this.mnuFile.MenuItems.Add(this.mnuQuit);
            this.mnuFile.Text = "File";
            // 
            // mnuExport
            // 
            this.mnuExport.Text = "Esporta";
            this.mnuExport.Click += new System.EventHandler(this.actExport);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "-";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Text = "Esci";
            this.mnuQuit.Click += new System.EventHandler(this.actQuit);
            // 
            // menuItem5
            // 
            this.menuItem5.MenuItems.Add(this.mnuEdit);
            this.menuItem5.MenuItems.Add(this.mnuDelete);
            this.menuItem5.MenuItems.Add(this.menuItem8);
            this.menuItem5.MenuItems.Add(this.menuItem9);
            this.menuItem5.Text = "Record";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Text = "Modifica";
            this.mnuEdit.Click += new System.EventHandler(this.actEdit);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Text = "Elimina";
            this.mnuDelete.Click += new System.EventHandler(this.actDelete);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Seleziona Tutto";
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.Text = "?";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Info";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // panEdit
            // 
            this.panEdit.Controls.Add(this.btnCancel);
            this.panEdit.Controls.Add(this.btnSave);
            this.panEdit.Controls.Add(label3);
            this.panEdit.Controls.Add(label2);
            this.panEdit.Controls.Add(this.txtQta);
            this.panEdit.Controls.Add(this.txtCode);
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEdit.Location = new System.Drawing.Point(0, 0);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(314, 92);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 20);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 20);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salva";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQta
            // 
            this.txtQta.Location = new System.Drawing.Point(79, 32);
            this.txtQta.Name = "txtQta";
            this.txtQta.Size = new System.Drawing.Size(100, 23);
            this.txtQta.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(79, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 23);
            this.txtCode.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Columns.Add(this.clCode);
            this.listBox.Columns.Add(this.clQta);
            this.listBox.ContextMenu = this.contextMenu;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.listBox.FullRowSelect = true;
            this.listBox.Location = new System.Drawing.Point(0, 92);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(314, 203);
            this.listBox.TabIndex = 5;
            this.listBox.TabStop = false;
            this.listBox.View = System.Windows.Forms.View.Details;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // clCode
            // 
            this.clCode.Text = "codice";
            this.clCode.Width = 201;
            // 
            // clQta
            // 
            this.clQta.Text = "qta";
            this.clQta.Width = 99;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(314, 319);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Self DC";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Closed += new System.EventHandler(this.MainForm2_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm2_Closing);
            this.Resize += new System.EventHandler(this.FormResize);
            this.panEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar;
        private Symbol.Barcode2.Design.Barcode2 bcReader;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem cmnuEdit;
        private System.Windows.Forms.MenuItem cmnuDelete;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuQuit;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuDelete;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuExport;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQta;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ListView listBox;
        private System.Windows.Forms.ColumnHeader clCode;
        private System.Windows.Forms.ColumnHeader clQta;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;

    }
}