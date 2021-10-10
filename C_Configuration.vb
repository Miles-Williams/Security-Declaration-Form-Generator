<Serializable()>
Public Class C_Configuration

    Private _currentStickerPrinter As String
    Private _currentPaperPrinter As String
    Private _defaultStickerCopies As Integer
    Private _defaultPaperCopies As Integer
    Private _saveDirectoryRoot As String
    Private _defaultsToDomestic As Boolean
    Private _defaultsToInternational As Boolean
    Private _tollPrefixDefault As Boolean
    Private _defaultContents As String
    Private _knownConsignorRef As String

    Public Property CurrentStickerPrinter() As String
        Get
            Return _currentStickerPrinter
        End Get
        Set(ByVal value As String)
            _currentStickerPrinter = value
        End Set
    End Property

    Public Property CurrentPaperPrinter() As String
        Get
            Return _currentPaperPrinter
        End Get
        Set(ByVal value As String)
            _currentPaperPrinter = value
        End Set
    End Property

    Public Property DefaultStickerCopies() As Integer
        Get
            Return _defaultStickerCopies
        End Get
        Set(ByVal value As Integer)
            _defaultStickerCopies = value
        End Set
    End Property

    Public Property DefaultPaperCopies() As Integer
        Get
            Return _defaultPaperCopies
        End Get
        Set(ByVal value As Integer)
            _defaultPaperCopies = value
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

    Public Property DefaultsToDomestic() As Boolean
        Get
            Return _defaultsToDomestic
        End Get
        Set(ByVal value As Boolean)
            _defaultsToDomestic = value
        End Set
    End Property

    Public Property DefaultsToInternational() As Boolean
        Get
            Return _defaultsToInternational
        End Get
        Set(ByVal value As Boolean)
            _defaultsToInternational = value
        End Set
    End Property

    Public Property TollPrefixDefault() As Boolean
        Get
            Return _tollPrefixDefault
        End Get
        Set(ByVal value As Boolean)
            _tollPrefixDefault = value
        End Set
    End Property

    Public Property DefaultContents() As String
        Get
            Return _defaultContents
        End Get
        Set(ByVal value As String)
            _defaultContents = value
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

End Class
