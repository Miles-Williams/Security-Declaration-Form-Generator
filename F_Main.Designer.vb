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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpConsignment = New System.Windows.Forms.GroupBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblConsignorsFullName = New System.Windows.Forms.Label()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picOrangeStripe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateConsignment
        '
        Me.btnCreateConsignment.Location = New System.Drawing.Point(13, 206)
        Me.btnCreateConsignment.Name = "btnCreateConsignment"
        Me.btnCreateConsignment.Size = New System.Drawing.Size(210, 24)
        Me.btnCreateConsignment.TabIndex = 3
        Me.btnCreateConsignment.Text = "Create New Consignment"
        Me.btnCreateConsignment.UseVisualStyleBackColor = True
        '
        'btnAddConsignment
        '
        Me.btnAddConsignment.Location = New System.Drawing.Point(148, 135)
        Me.btnAddConsignment.Name = "btnAddConsignment"
        Me.btnAddConsignment.Size = New System.Drawing.Size(75, 23)
        Me.btnAddConsignment.TabIndex = 1
        Me.btnAddConsignment.Text = "Add"
        Me.btnAddConsignment.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLogin, Me.tsbConfiguration, Me.tsbAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbLogin
        '
        Me.tsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLogin.Image = CType(resources.GetObject("tsbLogin.Image"), System.Drawing.Image)
        Me.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogin.Name = "tsbLogin"
        Me.tsbLogin.Size = New System.Drawing.Size(41, 22)
        Me.tsbLogin.Text = "Login"
        Me.tsbLogin.ToolTipText = "Click To Login"
        '
        'tsbConfiguration
        '
        Me.tsbConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbConfiguration.Image = CType(resources.GetObject("tsbConfiguration.Image"), System.Drawing.Image)
        Me.tsbConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConfiguration.Name = "tsbConfiguration"
        Me.tsbConfiguration.Size = New System.Drawing.Size(85, 22)
        Me.tsbConfiguration.Text = "Configuration"
        Me.tsbConfiguration.ToolTipText = "Click To Open Configuration"
        '
        'txtConsignment
        '
        Me.txtConsignment.Location = New System.Drawing.Point(13, 137)
        Me.txtConsignment.Name = "txtConsignment"
        Me.txtConsignment.Size = New System.Drawing.Size(129, 20)
        Me.txtConsignment.TabIndex = 0
        '
        'lblEnterConNumber
        '
        Me.lblEnterConNumber.AutoSize = True
        Me.lblEnterConNumber.Location = New System.Drawing.Point(10, 115)
        Me.lblEnterConNumber.Name = "lblEnterConNumber"
        Me.lblEnterConNumber.Size = New System.Drawing.Size(136, 13)
        Me.lblEnterConNumber.TabIndex = 5
        Me.lblEnterConNumber.Text = "Enter Consignment Number"
        '
        'lstConsignments
        '
        Me.lstConsignments.FormattingEnabled = True
        Me.lstConsignments.Location = New System.Drawing.Point(229, 135)
        Me.lstConsignments.Name = "lstConsignments"
        Me.lstConsignments.Size = New System.Drawing.Size(133, 95)
        Me.lstConsignments.TabIndex = 3
        '
        'lblCuLbl
        '
        Me.lblCuLbl.AutoSize = True
        Me.lblCuLbl.Location = New System.Drawing.Point(6, 27)
        Me.lblCuLbl.Name = "lblCuLbl"
        Me.lblCuLbl.Size = New System.Drawing.Size(120, 13)
        Me.lblCuLbl.TabIndex = 7
        Me.lblCuLbl.Text = "Currently logged in user:"
        '
        'lblCurrentUsername
        '
        Me.lblCurrentUsername.AutoSize = True
        Me.lblCurrentUsername.Location = New System.Drawing.Point(132, 27)
        Me.lblCurrentUsername.Name = "lblCurrentUsername"
        Me.lblCurrentUsername.Size = New System.Drawing.Size(143, 13)
        Me.lblCurrentUsername.TabIndex = 8
        Me.lblCurrentUsername.Text = "<no user currently logged in>"
        '
        'rdbDomestic
        '
        Me.rdbDomestic.AutoSize = True
        Me.rdbDomestic.Location = New System.Drawing.Point(9, 52)
        Me.rdbDomestic.Name = "rdbDomestic"
        Me.rdbDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdbDomestic.TabIndex = 4
        Me.rdbDomestic.TabStop = True
        Me.rdbDomestic.Text = "Domestic"
        Me.rdbDomestic.UseVisualStyleBackColor = True
        '
        'rdbInternational
        '
        Me.rdbInternational.AutoSize = True
        Me.rdbInternational.Location = New System.Drawing.Point(105, 52)
        Me.rdbInternational.Name = "rdbInternational"
        Me.rdbInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdbInternational.TabIndex = 5
        Me.rdbInternational.TabStop = True
        Me.rdbInternational.Text = "International"
        Me.rdbInternational.UseVisualStyleBackColor = True
        '
        'chkTollPrefix
        '
        Me.chkTollPrefix.AutoSize = True
        Me.chkTollPrefix.Location = New System.Drawing.Point(222, 52)
        Me.chkTollPrefix.Name = "chkTollPrefix"
        Me.chkTollPrefix.Size = New System.Drawing.Size(132, 17)
        Me.chkTollPrefix.TabIndex = 6
        Me.chkTollPrefix.Text = "Add Toll prefix (87750)"
        Me.chkTollPrefix.UseVisualStyleBackColor = True
        '
        'chkSticker
        '
        Me.chkSticker.AutoSize = True
        Me.chkSticker.Location = New System.Drawing.Point(9, 87)
        Me.chkSticker.Name = "chkSticker"
        Me.chkSticker.Size = New System.Drawing.Size(144, 17)
        Me.chkSticker.TabIndex = 7
        Me.chkSticker.Text = "Print sticker using printer:"
        Me.chkSticker.UseVisualStyleBackColor = True
        '
        'chkPaper
        '
        Me.chkPaper.AutoSize = True
        Me.chkPaper.Location = New System.Drawing.Point(9, 149)
        Me.chkPaper.Name = "chkPaper"
        Me.chkPaper.Size = New System.Drawing.Size(155, 17)
        Me.chkPaper.TabIndex = 9
        Me.chkPaper.Text = "Print A4 sheet using printer:"
        Me.chkPaper.UseVisualStyleBackColor = True
        '
        'chkBothPrinters
        '
        Me.chkBothPrinters.AutoSize = True
        Me.chkBothPrinters.Location = New System.Drawing.Point(9, 212)
        Me.chkBothPrinters.Name = "chkBothPrinters"
        Me.chkBothPrinters.Size = New System.Drawing.Size(120, 17)
        Me.chkBothPrinters.TabIndex = 11
        Me.chkBothPrinters.Text = "Print to both printers"
        Me.chkBothPrinters.UseVisualStyleBackColor = True
        '
        'lblPaperPrinter
        '
        Me.lblPaperPrinter.AutoSize = True
        Me.lblPaperPrinter.Location = New System.Drawing.Point(170, 150)
        Me.lblPaperPrinter.Name = "lblPaperPrinter"
        Me.lblPaperPrinter.Size = New System.Drawing.Size(140, 13)
        Me.lblPaperPrinter.TabIndex = 14
        Me.lblPaperPrinter.Text = "<set printer in configuration>"
        '
        'lblStickerPrinter
        '
        Me.lblStickerPrinter.AutoSize = True
        Me.lblStickerPrinter.Location = New System.Drawing.Point(154, 88)
        Me.lblStickerPrinter.Name = "lblStickerPrinter"
        Me.lblStickerPrinter.Size = New System.Drawing.Size(140, 13)
        Me.lblStickerPrinter.TabIndex = 15
        Me.lblStickerPrinter.Text = "<set printer in configuration>"
        '
        'btnRemoveConsignment
        '
        Me.btnRemoveConsignment.Location = New System.Drawing.Point(148, 164)
        Me.btnRemoveConsignment.Name = "btnRemoveConsignment"
        Me.btnRemoveConsignment.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveConsignment.TabIndex = 2
        Me.btnRemoveConsignment.Text = "Remove"
        Me.btnRemoveConsignment.UseVisualStyleBackColor = True
        '
        'lblStickerCopies
        '
        Me.lblStickerCopies.AutoSize = True
        Me.lblStickerCopies.Location = New System.Drawing.Point(9, 116)
        Me.lblStickerCopies.Name = "lblStickerCopies"
        Me.lblStickerCopies.Size = New System.Drawing.Size(107, 13)
        Me.lblStickerCopies.TabIndex = 18
        Me.lblStickerCopies.Text = "No. of sticker copies:"
        '
        'txtStickerCopies
        '
        Me.txtStickerCopies.Location = New System.Drawing.Point(122, 113)
        Me.txtStickerCopies.Name = "txtStickerCopies"
        Me.txtStickerCopies.Size = New System.Drawing.Size(20, 20)
        Me.txtStickerCopies.TabIndex = 8
        '
        'txtPaperCopies
        '
        Me.txtPaperCopies.Location = New System.Drawing.Point(122, 176)
        Me.txtPaperCopies.Name = "txtPaperCopies"
        Me.txtPaperCopies.Size = New System.Drawing.Size(20, 20)
        Me.txtPaperCopies.TabIndex = 10
        '
        'lblPaperCopies
        '
        Me.lblPaperCopies.AutoSize = True
        Me.lblPaperCopies.Location = New System.Drawing.Point(9, 179)
        Me.lblPaperCopies.Name = "lblPaperCopies"
        Me.lblPaperCopies.Size = New System.Drawing.Size(103, 13)
        Me.lblPaperCopies.TabIndex = 20
        Me.lblPaperCopies.Text = "No. of paper copies:"
        '
        'lblContents
        '
        Me.lblContents.AutoSize = True
        Me.lblContents.Location = New System.Drawing.Point(10, 54)
        Me.lblContents.Name = "lblContents"
        Me.lblContents.Size = New System.Drawing.Size(116, 13)
        Me.lblContents.TabIndex = 23
        Me.lblContents.Text = "Consignment Contents:"
        '
        'txtContents
        '
        Me.txtContents.Location = New System.Drawing.Point(13, 80)
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(349, 20)
        Me.txtContents.TabIndex = 12
        '
        'picOrangeStripe
        '
        Me.picOrangeStripe.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picOrangeStripe.ErrorImage = Nothing
        Me.picOrangeStripe.InitialImage = Nothing
        Me.picOrangeStripe.Location = New System.Drawing.Point(379, 0)
        Me.picOrangeStripe.Name = "picOrangeStripe"
        Me.picOrangeStripe.Size = New System.Drawing.Size(2, 280)
        Me.picOrangeStripe.TabIndex = 24
        Me.picOrangeStripe.TabStop = False
        '
        'btnDefaultContents
        '
        Me.btnDefaultContents.Location = New System.Drawing.Point(129, 49)
        Me.btnDefaultContents.Name = "btnDefaultContents"
        Me.btnDefaultContents.Size = New System.Drawing.Size(233, 23)
        Me.btnDefaultContents.TabIndex = 13
        Me.btnDefaultContents.Text = "Set consignment contents to default value"
        Me.btnDefaultContents.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.PictureBox1)
        Me.grpOptions.Controls.Add(Me.lblCuLbl)
        Me.grpOptions.Controls.Add(Me.lblCurrentUsername)
        Me.grpOptions.Controls.Add(Me.rdbDomestic)
        Me.grpOptions.Controls.Add(Me.rdbInternational)
        Me.grpOptions.Controls.Add(Me.chkTollPrefix)
        Me.grpOptions.Controls.Add(Me.txtPaperCopies)
        Me.grpOptions.Controls.Add(Me.chkSticker)
        Me.grpOptions.Controls.Add(Me.lblPaperCopies)
        Me.grpOptions.Controls.Add(Me.chkPaper)
        Me.grpOptions.Controls.Add(Me.txtStickerCopies)
        Me.grpOptions.Controls.Add(Me.chkBothPrinters)
        Me.grpOptions.Controls.Add(Me.lblStickerCopies)
        Me.grpOptions.Controls.Add(Me.lblPaperPrinter)
        Me.grpOptions.Controls.Add(Me.lblStickerPrinter)
        Me.grpOptions.Location = New System.Drawing.Point(12, 28)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(360, 240)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Security_Declaration_Form_Generator.My.Resources.Resources.WeidmullerLogo_Full
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(173, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'grpConsignment
        '
        Me.grpConsignment.Controls.Add(Me.lblContents)
        Me.grpConsignment.Controls.Add(Me.btnCreateConsignment)
        Me.grpConsignment.Controls.Add(Me.lblFullName)
        Me.grpConsignment.Controls.Add(Me.lblConsignorsFullName)
        Me.grpConsignment.Controls.Add(Me.btnDefaultContents)
        Me.grpConsignment.Controls.Add(Me.lstConsignments)
        Me.grpConsignment.Controls.Add(Me.txtContents)
        Me.grpConsignment.Controls.Add(Me.btnAddConsignment)
        Me.grpConsignment.Controls.Add(Me.btnRemoveConsignment)
        Me.grpConsignment.Controls.Add(Me.lblEnterConNumber)
        Me.grpConsignment.Controls.Add(Me.txtConsignment)
        Me.grpConsignment.Location = New System.Drawing.Point(388, 28)
        Me.grpConsignment.Name = "grpConsignment"
        Me.grpConsignment.Size = New System.Drawing.Size(384, 240)
        Me.grpConsignment.TabIndex = 0
        Me.grpConsignment.TabStop = False
        Me.grpConsignment.Text = "Consignment"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(10, 27)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(112, 13)
        Me.lblFullName.TabIndex = 21
        Me.lblFullName.Text = "Consignors Full Name:"
        '
        'lblConsignorsFullName
        '
        Me.lblConsignorsFullName.AutoSize = True
        Me.lblConsignorsFullName.Location = New System.Drawing.Point(136, 27)
        Me.lblConsignorsFullName.Name = "lblConsignorsFullName"
        Me.lblConsignorsFullName.Size = New System.Drawing.Size(143, 13)
        Me.lblConsignorsFullName.TabIndex = 22
        Me.lblConsignorsFullName.Text = "<no user currently logged in>"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAbout.Image = CType(resources.GetObject("tsbAbout.Image"), System.Drawing.Image)
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(44, 22)
        Me.tsbAbout.Text = "About"
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 277)
        Me.Controls.Add(Me.grpConsignment)
        Me.Controls.Add(Me.grpOptions)
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
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsignment.ResumeLayout(False)
        Me.grpConsignment.PerformLayout()
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
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpConsignment As GroupBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblConsignorsFullName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tsbAbout As ToolStripButton
End Class
