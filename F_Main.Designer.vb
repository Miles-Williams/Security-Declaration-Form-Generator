<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Main))
        Me.btnCreateConsignment = New System.Windows.Forms.Button()
        Me.btnAddConsignment = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbLogin = New System.Windows.Forms.ToolStripButton()
        Me.tsbConfiguration = New System.Windows.Forms.ToolStripButton()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.txtConsignment = New System.Windows.Forms.TextBox()
        Me.lblEnterConNumber = New System.Windows.Forms.Label()
        Me.lstConsignments = New System.Windows.Forms.ListBox()
        Me.lblCuLbl = New System.Windows.Forms.Label()
        Me.lblCurrentUsername = New System.Windows.Forms.Label()
        Me.rdbDomestic = New System.Windows.Forms.RadioButton()
        Me.rdbInternational = New System.Windows.Forms.RadioButton()
        Me.chkTollPrefix = New System.Windows.Forms.CheckBox()
        Me.chkSticker = New System.Windows.Forms.CheckBox()
        Me.chkPaper = New System.Windows.Forms.CheckBox()
        Me.chkBothPrinters = New System.Windows.Forms.CheckBox()
        Me.lblPaperPrinter = New System.Windows.Forms.Label()
        Me.lblStickerPrinter = New System.Windows.Forms.Label()
        Me.btnRemoveConsignment = New System.Windows.Forms.Button()
        Me.lblStickerCopies = New System.Windows.Forms.Label()
        Me.txtStickerCopies = New System.Windows.Forms.TextBox()
        Me.txtPaperCopies = New System.Windows.Forms.TextBox()
        Me.lblPaperCopies = New System.Windows.Forms.Label()
        Me.lblContents = New System.Windows.Forms.Label()
        Me.txtContents = New System.Windows.Forms.TextBox()
        Me.picOrangeStripe = New System.Windows.Forms.PictureBox()
        Me.btnDefaultContents = New System.Windows.Forms.Button()
        Me.grpPrintingOptions = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpConsignment = New System.Windows.Forms.GroupBox()
        Me.lblIssuedBy = New System.Windows.Forms.Label()
        Me.lblIssuedByValue = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picOrangeStripe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrintingOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsignment.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateConsignment
        '
        Me.btnCreateConsignment.Location = New System.Drawing.Point(23, 306)
        Me.btnCreateConsignment.Name = "btnCreateConsignment"
        Me.btnCreateConsignment.Size = New System.Drawing.Size(155, 30)
        Me.btnCreateConsignment.TabIndex = 3
        Me.btnCreateConsignment.Text = "Create Consignment"
        Me.btnCreateConsignment.UseVisualStyleBackColor = True
        '
        'btnAddConsignment
        '
        Me.btnAddConsignment.Location = New System.Drawing.Point(101, 227)
        Me.btnAddConsignment.Name = "btnAddConsignment"
        Me.btnAddConsignment.Size = New System.Drawing.Size(75, 30)
        Me.btnAddConsignment.TabIndex = 1
        Me.btnAddConsignment.Text = "Add"
        Me.btnAddConsignment.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStrip1.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLogin, Me.tsbConfiguration, Me.tsbAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(799, 28)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbLogin
        '
        Me.tsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLogin.Image = CType(resources.GetObject("tsbLogin.Image"), System.Drawing.Image)
        Me.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogin.Name = "tsbLogin"
        Me.tsbLogin.Size = New System.Drawing.Size(46, 25)
        Me.tsbLogin.Text = "Login"
        Me.tsbLogin.ToolTipText = "Click To Login"
        '
        'tsbConfiguration
        '
        Me.tsbConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbConfiguration.Image = CType(resources.GetObject("tsbConfiguration.Image"), System.Drawing.Image)
        Me.tsbConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConfiguration.Name = "tsbConfiguration"
        Me.tsbConfiguration.Size = New System.Drawing.Size(95, 25)
        Me.tsbConfiguration.Text = "Configuration"
        Me.tsbConfiguration.ToolTipText = "Click To Open Configuration"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAbout.Image = CType(resources.GetObject("tsbAbout.Image"), System.Drawing.Image)
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(51, 25)
        Me.tsbAbout.Text = "About"
        '
        'txtConsignment
        '
        Me.txtConsignment.Location = New System.Drawing.Point(184, 187)
        Me.txtConsignment.Name = "txtConsignment"
        Me.txtConsignment.Size = New System.Drawing.Size(190, 30)
        Me.txtConsignment.TabIndex = 0
        '
        'lblEnterConNumber
        '
        Me.lblEnterConNumber.AutoSize = True
        Me.lblEnterConNumber.Location = New System.Drawing.Point(10, 190)
        Me.lblEnterConNumber.Name = "lblEnterConNumber"
        Me.lblEnterConNumber.Size = New System.Drawing.Size(147, 21)
        Me.lblEnterConNumber.TabIndex = 5
        Me.lblEnterConNumber.Text = "Consignment Number:"
        '
        'lstConsignments
        '
        Me.lstConsignments.FormattingEnabled = True
        Me.lstConsignments.ItemHeight = 21
        Me.lstConsignments.Location = New System.Drawing.Point(184, 227)
        Me.lstConsignments.Name = "lstConsignments"
        Me.lstConsignments.Size = New System.Drawing.Size(190, 109)
        Me.lstConsignments.TabIndex = 3
        '
        'lblCuLbl
        '
        Me.lblCuLbl.AutoSize = True
        Me.lblCuLbl.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuLbl.Location = New System.Drawing.Point(302, 2)
        Me.lblCuLbl.Name = "lblCuLbl"
        Me.lblCuLbl.Size = New System.Drawing.Size(90, 21)
        Me.lblCuLbl.TabIndex = 7
        Me.lblCuLbl.Text = "Current user:"
        '
        'lblCurrentUsername
        '
        Me.lblCurrentUsername.AutoSize = True
        Me.lblCurrentUsername.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUsername.Location = New System.Drawing.Point(402, 2)
        Me.lblCurrentUsername.Name = "lblCurrentUsername"
        Me.lblCurrentUsername.Size = New System.Drawing.Size(192, 21)
        Me.lblCurrentUsername.TabIndex = 8
        Me.lblCurrentUsername.Text = "<no user currently logged in>"
        '
        'rdbDomestic
        '
        Me.rdbDomestic.AutoSize = True
        Me.rdbDomestic.Location = New System.Drawing.Point(10, 68)
        Me.rdbDomestic.Name = "rdbDomestic"
        Me.rdbDomestic.Size = New System.Drawing.Size(85, 25)
        Me.rdbDomestic.TabIndex = 4
        Me.rdbDomestic.TabStop = True
        Me.rdbDomestic.Text = "Domestic"
        Me.rdbDomestic.UseVisualStyleBackColor = True
        '
        'rdbInternational
        '
        Me.rdbInternational.AutoSize = True
        Me.rdbInternational.Location = New System.Drawing.Point(101, 68)
        Me.rdbInternational.Name = "rdbInternational"
        Me.rdbInternational.Size = New System.Drawing.Size(105, 25)
        Me.rdbInternational.TabIndex = 5
        Me.rdbInternational.TabStop = True
        Me.rdbInternational.Text = "International"
        Me.rdbInternational.UseVisualStyleBackColor = True
        '
        'chkTollPrefix
        '
        Me.chkTollPrefix.AutoSize = True
        Me.chkTollPrefix.Location = New System.Drawing.Point(10, 150)
        Me.chkTollPrefix.Name = "chkTollPrefix"
        Me.chkTollPrefix.Size = New System.Drawing.Size(168, 25)
        Me.chkTollPrefix.TabIndex = 6
        Me.chkTollPrefix.Text = "Add Toll prefix (87750)"
        Me.chkTollPrefix.UseVisualStyleBackColor = True
        '
        'chkSticker
        '
        Me.chkSticker.AutoSize = True
        Me.chkSticker.Location = New System.Drawing.Point(10, 30)
        Me.chkSticker.Name = "chkSticker"
        Me.chkSticker.Size = New System.Drawing.Size(187, 25)
        Me.chkSticker.TabIndex = 7
        Me.chkSticker.Text = "Print sticker using printer:"
        Me.chkSticker.UseVisualStyleBackColor = True
        '
        'chkPaper
        '
        Me.chkPaper.AutoSize = True
        Me.chkPaper.Location = New System.Drawing.Point(10, 150)
        Me.chkPaper.Name = "chkPaper"
        Me.chkPaper.Size = New System.Drawing.Size(201, 25)
        Me.chkPaper.TabIndex = 9
        Me.chkPaper.Text = "Print A4 sheet using printer:"
        Me.chkPaper.UseVisualStyleBackColor = True
        '
        'chkBothPrinters
        '
        Me.chkBothPrinters.AutoSize = True
        Me.chkBothPrinters.Location = New System.Drawing.Point(10, 270)
        Me.chkBothPrinters.Name = "chkBothPrinters"
        Me.chkBothPrinters.Size = New System.Drawing.Size(157, 25)
        Me.chkBothPrinters.TabIndex = 11
        Me.chkBothPrinters.Text = "Print to both printers"
        Me.chkBothPrinters.UseVisualStyleBackColor = True
        '
        'lblPaperPrinter
        '
        Me.lblPaperPrinter.AutoSize = True
        Me.lblPaperPrinter.Location = New System.Drawing.Point(10, 190)
        Me.lblPaperPrinter.Name = "lblPaperPrinter"
        Me.lblPaperPrinter.Size = New System.Drawing.Size(192, 21)
        Me.lblPaperPrinter.TabIndex = 14
        Me.lblPaperPrinter.Text = "<set printer in configuration>"
        '
        'lblStickerPrinter
        '
        Me.lblStickerPrinter.AutoSize = True
        Me.lblStickerPrinter.Location = New System.Drawing.Point(10, 70)
        Me.lblStickerPrinter.Name = "lblStickerPrinter"
        Me.lblStickerPrinter.Size = New System.Drawing.Size(192, 21)
        Me.lblStickerPrinter.TabIndex = 15
        Me.lblStickerPrinter.Text = "<set printer in configuration>"
        '
        'btnRemoveConsignment
        '
        Me.btnRemoveConsignment.Location = New System.Drawing.Point(103, 266)
        Me.btnRemoveConsignment.Name = "btnRemoveConsignment"
        Me.btnRemoveConsignment.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveConsignment.TabIndex = 2
        Me.btnRemoveConsignment.Text = "Remove"
        Me.btnRemoveConsignment.UseVisualStyleBackColor = True
        '
        'lblStickerCopies
        '
        Me.lblStickerCopies.AutoSize = True
        Me.lblStickerCopies.Location = New System.Drawing.Point(10, 110)
        Me.lblStickerCopies.Name = "lblStickerCopies"
        Me.lblStickerCopies.Size = New System.Drawing.Size(136, 21)
        Me.lblStickerCopies.TabIndex = 18
        Me.lblStickerCopies.Text = "No. of sticker copies:"
        '
        'txtStickerCopies
        '
        Me.txtStickerCopies.Location = New System.Drawing.Point(152, 107)
        Me.txtStickerCopies.Name = "txtStickerCopies"
        Me.txtStickerCopies.Size = New System.Drawing.Size(30, 30)
        Me.txtStickerCopies.TabIndex = 8
        '
        'txtPaperCopies
        '
        Me.txtPaperCopies.Location = New System.Drawing.Point(152, 227)
        Me.txtPaperCopies.Name = "txtPaperCopies"
        Me.txtPaperCopies.Size = New System.Drawing.Size(30, 30)
        Me.txtPaperCopies.TabIndex = 10
        '
        'lblPaperCopies
        '
        Me.lblPaperCopies.AutoSize = True
        Me.lblPaperCopies.Location = New System.Drawing.Point(10, 230)
        Me.lblPaperCopies.Name = "lblPaperCopies"
        Me.lblPaperCopies.Size = New System.Drawing.Size(128, 21)
        Me.lblPaperCopies.TabIndex = 20
        Me.lblPaperCopies.Text = "No. of paper copies:"
        '
        'lblContents
        '
        Me.lblContents.AutoSize = True
        Me.lblContents.Location = New System.Drawing.Point(10, 110)
        Me.lblContents.Name = "lblContents"
        Me.lblContents.Size = New System.Drawing.Size(152, 21)
        Me.lblContents.TabIndex = 23
        Me.lblContents.Text = "Consignment Contents:"
        '
        'txtContents
        '
        Me.txtContents.Location = New System.Drawing.Point(184, 107)
        Me.txtContents.Multiline = True
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(190, 68)
        Me.txtContents.TabIndex = 12
        '
        'picOrangeStripe
        '
        Me.picOrangeStripe.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picOrangeStripe.ErrorImage = Nothing
        Me.picOrangeStripe.InitialImage = Nothing
        Me.picOrangeStripe.Location = New System.Drawing.Point(398, 26)
        Me.picOrangeStripe.Name = "picOrangeStripe"
        Me.picOrangeStripe.Size = New System.Drawing.Size(2, 368)
        Me.picOrangeStripe.TabIndex = 24
        Me.picOrangeStripe.TabStop = False
        '
        'btnDefaultContents
        '
        Me.btnDefaultContents.Location = New System.Drawing.Point(221, 65)
        Me.btnDefaultContents.Name = "btnDefaultContents"
        Me.btnDefaultContents.Size = New System.Drawing.Size(153, 30)
        Me.btnDefaultContents.TabIndex = 13
        Me.btnDefaultContents.Text = "Default contents"
        Me.btnDefaultContents.UseVisualStyleBackColor = True
        '
        'grpPrintingOptions
        '
        Me.grpPrintingOptions.BackColor = System.Drawing.SystemColors.Window
        Me.grpPrintingOptions.Controls.Add(Me.PictureBox1)
        Me.grpPrintingOptions.Controls.Add(Me.txtPaperCopies)
        Me.grpPrintingOptions.Controls.Add(Me.chkSticker)
        Me.grpPrintingOptions.Controls.Add(Me.lblPaperCopies)
        Me.grpPrintingOptions.Controls.Add(Me.chkPaper)
        Me.grpPrintingOptions.Controls.Add(Me.txtStickerCopies)
        Me.grpPrintingOptions.Controls.Add(Me.chkBothPrinters)
        Me.grpPrintingOptions.Controls.Add(Me.lblStickerCopies)
        Me.grpPrintingOptions.Controls.Add(Me.lblPaperPrinter)
        Me.grpPrintingOptions.Controls.Add(Me.lblStickerPrinter)
        Me.grpPrintingOptions.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrintingOptions.Location = New System.Drawing.Point(406, 30)
        Me.grpPrintingOptions.Name = "grpPrintingOptions"
        Me.grpPrintingOptions.Size = New System.Drawing.Size(380, 350)
        Me.grpPrintingOptions.TabIndex = 1
        Me.grpPrintingOptions.TabStop = False
        Me.grpPrintingOptions.Text = "Printing Options"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Security_Declaration_Form_Generator.My.Resources.Resources.WeidmullerLogo_Full
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(10, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'grpConsignment
        '
        Me.grpConsignment.BackColor = System.Drawing.SystemColors.Window
        Me.grpConsignment.Controls.Add(Me.btnCreateConsignment)
        Me.grpConsignment.Controls.Add(Me.lblContents)
        Me.grpConsignment.Controls.Add(Me.lblIssuedBy)
        Me.grpConsignment.Controls.Add(Me.rdbDomestic)
        Me.grpConsignment.Controls.Add(Me.rdbInternational)
        Me.grpConsignment.Controls.Add(Me.lblIssuedByValue)
        Me.grpConsignment.Controls.Add(Me.chkTollPrefix)
        Me.grpConsignment.Controls.Add(Me.lstConsignments)
        Me.grpConsignment.Controls.Add(Me.txtContents)
        Me.grpConsignment.Controls.Add(Me.btnAddConsignment)
        Me.grpConsignment.Controls.Add(Me.btnRemoveConsignment)
        Me.grpConsignment.Controls.Add(Me.btnDefaultContents)
        Me.grpConsignment.Controls.Add(Me.lblEnterConNumber)
        Me.grpConsignment.Controls.Add(Me.txtConsignment)
        Me.grpConsignment.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConsignment.Location = New System.Drawing.Point(12, 30)
        Me.grpConsignment.Name = "grpConsignment"
        Me.grpConsignment.Size = New System.Drawing.Size(380, 350)
        Me.grpConsignment.TabIndex = 0
        Me.grpConsignment.TabStop = False
        Me.grpConsignment.Text = "Consignment Details"
        '
        'lblIssuedBy
        '
        Me.lblIssuedBy.AutoSize = True
        Me.lblIssuedBy.Location = New System.Drawing.Point(10, 30)
        Me.lblIssuedBy.Name = "lblIssuedBy"
        Me.lblIssuedBy.Size = New System.Drawing.Size(72, 21)
        Me.lblIssuedBy.TabIndex = 21
        Me.lblIssuedBy.Text = "Issued by:"
        '
        'lblIssuedByValue
        '
        Me.lblIssuedByValue.AutoSize = True
        Me.lblIssuedByValue.Location = New System.Drawing.Point(88, 31)
        Me.lblIssuedByValue.Name = "lblIssuedByValue"
        Me.lblIssuedByValue.Size = New System.Drawing.Size(192, 21)
        Me.lblIssuedByValue.TabIndex = 22
        Me.lblIssuedByValue.Text = "<no user currently logged in>"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1065, 2)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(799, 391)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblCurrentUsername)
        Me.Controls.Add(Me.lblCuLbl)
        Me.Controls.Add(Me.grpConsignment)
        Me.Controls.Add(Me.grpPrintingOptions)
        Me.Controls.Add(Me.picOrangeStripe)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_Main"
        Me.Text = "SDF Generator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picOrangeStripe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrintingOptions.ResumeLayout(False)
        Me.grpPrintingOptions.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsignment.ResumeLayout(False)
        Me.grpConsignment.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateConsignment As Button
    Friend WithEvents btnAddConsignment As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtConsignment As TextBox
    Friend WithEvents lblEnterConNumber As Label
    Friend WithEvents lstConsignments As ListBox
    Friend WithEvents lblCuLbl As Label
    Friend WithEvents lblCurrentUsername As Label
    Friend WithEvents rdbDomestic As RadioButton
    Friend WithEvents rdbInternational As RadioButton
    Friend WithEvents tsbLogin As ToolStripButton
    Friend WithEvents tsbConfiguration As ToolStripButton
    Friend WithEvents chkTollPrefix As CheckBox
    Friend WithEvents chkSticker As CheckBox
    Friend WithEvents chkPaper As CheckBox
    Friend WithEvents chkBothPrinters As CheckBox
    Friend WithEvents lblPaperPrinter As Label
    Friend WithEvents lblStickerPrinter As Label
    Friend WithEvents btnRemoveConsignment As Button
    Friend WithEvents lblStickerCopies As Label
    Friend WithEvents txtStickerCopies As TextBox
    Friend WithEvents txtPaperCopies As TextBox
    Friend WithEvents lblPaperCopies As Label
    Friend WithEvents lblContents As Label
    Friend WithEvents txtContents As TextBox
    Friend WithEvents picOrangeStripe As PictureBox
    Friend WithEvents btnDefaultContents As Button
    Friend WithEvents grpPrintingOptions As GroupBox
    Friend WithEvents grpConsignment As GroupBox
    Friend WithEvents lblIssuedBy As Label
    Friend WithEvents lblIssuedByValue As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tsbAbout As ToolStripButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
