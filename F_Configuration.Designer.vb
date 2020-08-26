<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Configuration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Configuration))
        Me.grpPrinters = New System.Windows.Forms.GroupBox()
        Me.txtDefaultPaperCopies = New System.Windows.Forms.TextBox()
        Me.txtDefaultStickerCopies = New System.Windows.Forms.TextBox()
        Me.lblDefaultPaperCopies = New System.Windows.Forms.Label()
        Me.lblDefaultStickerCopies = New System.Windows.Forms.Label()
        Me.cboCurrentPaperPrinter = New System.Windows.Forms.ComboBox()
        Me.cboCurrentStickerPrinter = New System.Windows.Forms.ComboBox()
        Me.lblCurrentPaperPrinter = New System.Windows.Forms.Label()
        Me.lblCurrentStickerPrinter = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.grpDefaultSettings = New System.Windows.Forms.GroupBox()
        Me.txtKnownConsignor = New System.Windows.Forms.TextBox()
        Me.lblKnownConsignor = New System.Windows.Forms.Label()
        Me.txtDefaultContents = New System.Windows.Forms.TextBox()
        Me.rdbInternational = New System.Windows.Forms.RadioButton()
        Me.btnSaveDirectoryRoot = New System.Windows.Forms.Button()
        Me.lblSaveDirectoryRoot = New System.Windows.Forms.Label()
        Me.lblDefaultContents = New System.Windows.Forms.Label()
        Me.rdbDomestic = New System.Windows.Forms.RadioButton()
        Me.lblCurrentSaveDirectoryRoot = New System.Windows.Forms.Label()
        Me.chkTollPrefixDefault = New System.Windows.Forms.CheckBox()
        Me.grpUsers = New System.Windows.Forms.GroupBox()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.grpSignature = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpPrinters.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDefaultSettings.SuspendLayout()
        Me.grpUsers.SuspendLayout()
        Me.grpSignature.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPrinters
        '
        Me.grpPrinters.Controls.Add(Me.txtDefaultPaperCopies)
        Me.grpPrinters.Controls.Add(Me.txtDefaultStickerCopies)
        Me.grpPrinters.Controls.Add(Me.lblDefaultPaperCopies)
        Me.grpPrinters.Controls.Add(Me.lblDefaultStickerCopies)
        Me.grpPrinters.Controls.Add(Me.cboCurrentPaperPrinter)
        Me.grpPrinters.Controls.Add(Me.cboCurrentStickerPrinter)
        Me.grpPrinters.Controls.Add(Me.lblCurrentPaperPrinter)
        Me.grpPrinters.Controls.Add(Me.lblCurrentStickerPrinter)
        Me.grpPrinters.Location = New System.Drawing.Point(12, 12)
        Me.grpPrinters.Name = "grpPrinters"
        Me.grpPrinters.Size = New System.Drawing.Size(362, 176)
        Me.grpPrinters.TabIndex = 0
        Me.grpPrinters.TabStop = False
        Me.grpPrinters.Text = "Printers"
        '
        'txtDefaultPaperCopies
        '
        Me.txtDefaultPaperCopies.Location = New System.Drawing.Point(125, 132)
        Me.txtDefaultPaperCopies.Name = "txtDefaultPaperCopies"
        Me.txtDefaultPaperCopies.Size = New System.Drawing.Size(26, 30)
        Me.txtDefaultPaperCopies.TabIndex = 9
        Me.txtDefaultPaperCopies.Text = "1"
        '
        'txtDefaultStickerCopies
        '
        Me.txtDefaultStickerCopies.Location = New System.Drawing.Point(125, 64)
        Me.txtDefaultStickerCopies.Name = "txtDefaultStickerCopies"
        Me.txtDefaultStickerCopies.Size = New System.Drawing.Size(26, 30)
        Me.txtDefaultStickerCopies.TabIndex = 8
        Me.txtDefaultStickerCopies.Text = "1"
        '
        'lblDefaultPaperCopies
        '
        Me.lblDefaultPaperCopies.AutoSize = True
        Me.lblDefaultPaperCopies.Location = New System.Drawing.Point(6, 135)
        Me.lblDefaultPaperCopies.Name = "lblDefaultPaperCopies"
        Me.lblDefaultPaperCopies.Size = New System.Drawing.Size(99, 21)
        Me.lblDefaultPaperCopies.TabIndex = 7
        Me.lblDefaultPaperCopies.Text = "Default Copies:"
        '
        'lblDefaultStickerCopies
        '
        Me.lblDefaultStickerCopies.AutoSize = True
        Me.lblDefaultStickerCopies.Location = New System.Drawing.Point(6, 67)
        Me.lblDefaultStickerCopies.Name = "lblDefaultStickerCopies"
        Me.lblDefaultStickerCopies.Size = New System.Drawing.Size(99, 21)
        Me.lblDefaultStickerCopies.TabIndex = 6
        Me.lblDefaultStickerCopies.Text = "Default Copies:"
        '
        'cboCurrentPaperPrinter
        '
        Me.cboCurrentPaperPrinter.FormattingEnabled = True
        Me.cboCurrentPaperPrinter.Location = New System.Drawing.Point(125, 98)
        Me.cboCurrentPaperPrinter.Name = "cboCurrentPaperPrinter"
        Me.cboCurrentPaperPrinter.Size = New System.Drawing.Size(231, 29)
        Me.cboCurrentPaperPrinter.TabIndex = 5
        '
        'cboCurrentStickerPrinter
        '
        Me.cboCurrentStickerPrinter.FormattingEnabled = True
        Me.cboCurrentStickerPrinter.Location = New System.Drawing.Point(125, 29)
        Me.cboCurrentStickerPrinter.Name = "cboCurrentStickerPrinter"
        Me.cboCurrentStickerPrinter.Size = New System.Drawing.Size(231, 29)
        Me.cboCurrentStickerPrinter.TabIndex = 4
        '
        'lblCurrentPaperPrinter
        '
        Me.lblCurrentPaperPrinter.AutoSize = True
        Me.lblCurrentPaperPrinter.Location = New System.Drawing.Point(6, 101)
        Me.lblCurrentPaperPrinter.Name = "lblCurrentPaperPrinter"
        Me.lblCurrentPaperPrinter.Size = New System.Drawing.Size(92, 21)
        Me.lblCurrentPaperPrinter.TabIndex = 3
        Me.lblCurrentPaperPrinter.Text = "Paper Printer:"
        '
        'lblCurrentStickerPrinter
        '
        Me.lblCurrentStickerPrinter.AutoSize = True
        Me.lblCurrentStickerPrinter.Location = New System.Drawing.Point(6, 32)
        Me.lblCurrentStickerPrinter.Name = "lblCurrentStickerPrinter"
        Me.lblCurrentStickerPrinter.Size = New System.Drawing.Size(101, 21)
        Me.lblCurrentStickerPrinter.TabIndex = 1
        Me.lblCurrentStickerPrinter.Text = "Sticker Printer:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(404, 357)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 30)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(629, 357)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(517, 357)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 30)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'picSignature
        '
        Me.picSignature.ErrorImage = Nothing
        Me.picSignature.Location = New System.Drawing.Point(18, 29)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(300, 100)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 4
        Me.picSignature.TabStop = False
        '
        'grpDefaultSettings
        '
        Me.grpDefaultSettings.Controls.Add(Me.txtKnownConsignor)
        Me.grpDefaultSettings.Controls.Add(Me.lblKnownConsignor)
        Me.grpDefaultSettings.Controls.Add(Me.txtDefaultContents)
        Me.grpDefaultSettings.Controls.Add(Me.rdbInternational)
        Me.grpDefaultSettings.Controls.Add(Me.btnSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.lblSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.lblDefaultContents)
        Me.grpDefaultSettings.Controls.Add(Me.rdbDomestic)
        Me.grpDefaultSettings.Controls.Add(Me.lblCurrentSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.chkTollPrefixDefault)
        Me.grpDefaultSettings.Location = New System.Drawing.Point(12, 194)
        Me.grpDefaultSettings.Name = "grpDefaultSettings"
        Me.grpDefaultSettings.Size = New System.Drawing.Size(362, 235)
        Me.grpDefaultSettings.TabIndex = 6
        Me.grpDefaultSettings.TabStop = False
        Me.grpDefaultSettings.Text = "Default Settings"
        '
        'txtKnownConsignor
        '
        Me.txtKnownConsignor.Location = New System.Drawing.Point(162, 192)
        Me.txtKnownConsignor.Name = "txtKnownConsignor"
        Me.txtKnownConsignor.Size = New System.Drawing.Size(196, 30)
        Me.txtKnownConsignor.TabIndex = 13
        '
        'lblKnownConsignor
        '
        Me.lblKnownConsignor.AutoSize = True
        Me.lblKnownConsignor.Location = New System.Drawing.Point(10, 195)
        Me.lblKnownConsignor.Name = "lblKnownConsignor"
        Me.lblKnownConsignor.Size = New System.Drawing.Size(146, 21)
        Me.lblKnownConsignor.TabIndex = 12
        Me.lblKnownConsignor.Text = "Known Consignor Ref:"
        '
        'txtDefaultContents
        '
        Me.txtDefaultContents.Location = New System.Drawing.Point(162, 156)
        Me.txtDefaultContents.Name = "txtDefaultContents"
        Me.txtDefaultContents.Size = New System.Drawing.Size(196, 30)
        Me.txtDefaultContents.TabIndex = 11
        '
        'rdbInternational
        '
        Me.rdbInternational.AutoSize = True
        Me.rdbInternational.Location = New System.Drawing.Point(253, 115)
        Me.rdbInternational.Name = "rdbInternational"
        Me.rdbInternational.Size = New System.Drawing.Size(105, 25)
        Me.rdbInternational.TabIndex = 5
        Me.rdbInternational.TabStop = True
        Me.rdbInternational.Text = "International"
        Me.rdbInternational.UseVisualStyleBackColor = True
        '
        'btnSaveDirectoryRoot
        '
        Me.btnSaveDirectoryRoot.Location = New System.Drawing.Point(10, 80)
        Me.btnSaveDirectoryRoot.Name = "btnSaveDirectoryRoot"
        Me.btnSaveDirectoryRoot.Size = New System.Drawing.Size(103, 30)
        Me.btnSaveDirectoryRoot.TabIndex = 2
        Me.btnSaveDirectoryRoot.Text = "Change SDR"
        Me.btnSaveDirectoryRoot.UseVisualStyleBackColor = True
        '
        'lblSaveDirectoryRoot
        '
        Me.lblSaveDirectoryRoot.AutoSize = True
        Me.lblSaveDirectoryRoot.Location = New System.Drawing.Point(6, 26)
        Me.lblSaveDirectoryRoot.Name = "lblSaveDirectoryRoot"
        Me.lblSaveDirectoryRoot.Size = New System.Drawing.Size(134, 21)
        Me.lblSaveDirectoryRoot.TabIndex = 0
        Me.lblSaveDirectoryRoot.Text = "Save Directory Root:"
        '
        'lblDefaultContents
        '
        Me.lblDefaultContents.AutoSize = True
        Me.lblDefaultContents.Location = New System.Drawing.Point(10, 159)
        Me.lblDefaultContents.Name = "lblDefaultContents"
        Me.lblDefaultContents.Size = New System.Drawing.Size(115, 21)
        Me.lblDefaultContents.TabIndex = 10
        Me.lblDefaultContents.Text = "Default Contents:"
        '
        'rdbDomestic
        '
        Me.rdbDomestic.AutoSize = True
        Me.rdbDomestic.Location = New System.Drawing.Point(162, 115)
        Me.rdbDomestic.Name = "rdbDomestic"
        Me.rdbDomestic.Size = New System.Drawing.Size(85, 25)
        Me.rdbDomestic.TabIndex = 4
        Me.rdbDomestic.TabStop = True
        Me.rdbDomestic.Text = "Domestic"
        Me.rdbDomestic.UseVisualStyleBackColor = True
        '
        'lblCurrentSaveDirectoryRoot
        '
        Me.lblCurrentSaveDirectoryRoot.Location = New System.Drawing.Point(146, 25)
        Me.lblCurrentSaveDirectoryRoot.Name = "lblCurrentSaveDirectoryRoot"
        Me.lblCurrentSaveDirectoryRoot.Size = New System.Drawing.Size(208, 44)
        Me.lblCurrentSaveDirectoryRoot.TabIndex = 1
        Me.lblCurrentSaveDirectoryRoot.Text = "<select a directory to build the save file structure in>"
        '
        'chkTollPrefixDefault
        '
        Me.chkTollPrefixDefault.AutoSize = True
        Me.chkTollPrefixDefault.Location = New System.Drawing.Point(10, 116)
        Me.chkTollPrefixDefault.Name = "chkTollPrefixDefault"
        Me.chkTollPrefixDefault.Size = New System.Drawing.Size(109, 25)
        Me.chkTollPrefixDefault.TabIndex = 3
        Me.chkTollPrefixDefault.Text = "Toll Prefix On"
        Me.chkTollPrefixDefault.UseVisualStyleBackColor = True
        '
        'grpUsers
        '
        Me.grpUsers.Controls.Add(Me.btnEditUser)
        Me.grpUsers.Controls.Add(Me.btnDeleteUser)
        Me.grpUsers.Controls.Add(Me.btnAddUser)
        Me.grpUsers.Controls.Add(Me.lstUsers)
        Me.grpUsers.Controls.Add(Me.grpSignature)
        Me.grpUsers.Location = New System.Drawing.Point(380, 12)
        Me.grpUsers.Name = "grpUsers"
        Me.grpUsers.Size = New System.Drawing.Size(349, 339)
        Me.grpUsers.TabIndex = 7
        Me.grpUsers.TabStop = False
        Me.grpUsers.Text = "Users"
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(249, 126)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(75, 30)
        Me.btnEditUser.TabIndex = 9
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(249, 78)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 30)
        Me.btnDeleteUser.TabIndex = 8
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(249, 30)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 30)
        Me.btnAddUser.TabIndex = 7
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 21
        Me.lstUsers.Location = New System.Drawing.Point(9, 30)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(203, 130)
        Me.lstUsers.TabIndex = 6
        '
        'grpSignature
        '
        Me.grpSignature.Controls.Add(Me.picSignature)
        Me.grpSignature.Location = New System.Drawing.Point(6, 182)
        Me.grpSignature.Name = "grpSignature"
        Me.grpSignature.Size = New System.Drawing.Size(337, 145)
        Me.grpSignature.TabIndex = 5
        Me.grpSignature.TabStop = False
        Me.grpSignature.Text = "Signature"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Security_Declaration_Form_Generator.My.Resources.Resources.WeidmullerLogo_Full
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(549, 400)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'F_Configuration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(740, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpUsers)
        Me.Controls.Add(Me.grpDefaultSettings)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpPrinters)
        Me.Font = New System.Drawing.Font("Weidmueller Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Configuration"
        Me.Text = "Configuration"
        Me.grpPrinters.ResumeLayout(False)
        Me.grpPrinters.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDefaultSettings.ResumeLayout(False)
        Me.grpDefaultSettings.PerformLayout()
        Me.grpUsers.ResumeLayout(False)
        Me.grpSignature.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPrinters As GroupBox
    Friend WithEvents lblCurrentStickerPrinter As Label
    Friend WithEvents cboCurrentStickerPrinter As ComboBox
    Friend WithEvents lblCurrentPaperPrinter As Label
    Friend WithEvents cboCurrentPaperPrinter As ComboBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents picSignature As PictureBox
    Friend WithEvents grpDefaultSettings As GroupBox
    Friend WithEvents rdbInternational As RadioButton
    Friend WithEvents rdbDomestic As RadioButton
    Friend WithEvents chkTollPrefixDefault As CheckBox
    Friend WithEvents btnSaveDirectoryRoot As Button
    Friend WithEvents lblCurrentSaveDirectoryRoot As Label
    Friend WithEvents lblSaveDirectoryRoot As Label
    Friend WithEvents grpUsers As GroupBox
    Friend WithEvents grpSignature As GroupBox
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lstUsers As ListBox
    Friend WithEvents txtDefaultPaperCopies As TextBox
    Friend WithEvents txtDefaultStickerCopies As TextBox
    Friend WithEvents lblDefaultPaperCopies As Label
    Friend WithEvents lblDefaultStickerCopies As Label
    Friend WithEvents txtDefaultContents As TextBox
    Friend WithEvents lblDefaultContents As Label
    Friend WithEvents txtKnownConsignor As TextBox
    Friend WithEvents lblKnownConsignor As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
