Public Class C_ExcelData

    Private _contents As String
    Private _knownConsignorRef As String
    Private _firstConNumber As String
    Private _conNumbers As String
    Private _issuedOn As Date
    Private _paperCopies As Integer
    Private _stickerCopies As Integer
    Private _printMedium As E_PrintMedium
    Private _destination As E_Destination
    Private _saveDirectoryRoot As String
    Private _paperPrinter As String
    Private _stickerPrinter As String
    Private _cargoDestinationObject As C_Destination
    Private _fullName As String
    Private _sigPath As String

    Public Property Contents() As String
        Get
            Return _contents
        End Get
        Set(ByVal value As String)
            _contents = value
        End Set
    End Property

    Public Property KnownConsignorRef() As String
        Get
            Return _knownConsignorRef
        End Get
        Set(ByVal value As String)
            _knownConsignorRef = value
        End Set
    End Property

    Public Property FirstConNumber() As String
        Get
            Return _firstConNumber
        End Get
        Set(ByVal value As String)
            _firstConNumber = value
        End Set
    End Property

    Public Property ConNumbers() As String
        Get
            Return _conNumbers
        End Get
        Set(ByVal value As String)
            _conNumbers = value
        End Set
    End Property

    Public Property IssuedOn() As Date
        Get
            Return _issuedOn
        End Get
        Set(ByVal value As Date)
            _issuedOn = value
        End Set
    End Property

    Public Property PaperCopies() As Integer
        Get
            Return _paperCopies
        End Get
        Set(ByVal value As Integer)
            _paperCopies = value
        End Set
    End Property

    Public Property StickerCopies() As Integer
        Get
            Return _stickerCopies
        End Get
        Set(ByVal value As Integer)
            _stickerCopies = value
        End Set
    End Property

    Public Property PrintMedium() As E_PrintMedium
        Get
            Return _printMedium
        End Get
        Set(ByVal value As E_PrintMedium)
            _printMedium = value
        End Set
    End Property

    Public Property Destination() As E_Destination
        Get
            Return _destination
        End Get
        Set(ByVal value As E_Destination)
            _destination = value
        End Set
    End Property

    Public Property SaveDirectoryRoot() As String
        Get
            Return _saveDirectoryRoot
        End Get
        Set(ByVal value As String)
            _saveDirectoryRoot = value
        End Set
    End Property

    Public Property PaperPrinter() As String
        Get
            Return _paperPrinter
        End Get
        Set(ByVal value As String)
            _paperPrinter = value
        End Set
    End Property

    Public Property StickerPrinter() As String
        Get
            Return _stickerPrinter
        End Get
        Set(ByVal value As String)
            _stickerPrinter = value
        End Set
    End Property

    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal value As String)
            _fullName = value
        End Set
    End Property

    Public Property SigPath() As String
        Get
            Return _sigPath
        End Get
        Set(ByVal value As String)
            _sigPath = value
        End Set
    End Property

    Public Property CargoDestinationObject() As C_Destination
        Get
            Return _cargoDestinationObject
        End Get
        Set(ByVal value As C_Destination)
            _cargoDestinationObject = value
        End Set
    End Property


    Public Sub New(parContents As String,
                   parKnownConsignorRef As String,
                   parFirstCon As String,
                   parConNumbers As String,
                   parIssuedOn As Date,
                   parPaperCopies As Integer,
                   parStickerCopies As Integer,
                   parPrintMedium As E_PrintMedium,
                   parDestination As E_Destination,
                   parSdr As String,
                   parPaperPrinter As String,
                   parStickerPrinter As String,
                   parCargoDestinationObject As C_Destination,
                   Optional parFullName As String = "",
                   Optional parSigPath As String = "")

        _contents = parContents
        _knownConsignorRef = parKnownConsignorRef
        _firstConNumber = parFirstCon
        _conNumbers = parConNumbers
        _issuedOn = parIssuedOn
        _paperCopies = parPaperCopies
        _stickerCopies = parStickerCopies
        _printMedium = parPrintMedium
        _destination = parDestination
        _saveDirectoryRoot = parSdr
        _paperPrinter = parPaperPrinter
        _stickerPrinter = parStickerPrinter
        _cargoDestinationObject = parCargoDestinationObject
        _fullName = parFullName
        _sigPath = parSigPath

    End Sub

End Class
