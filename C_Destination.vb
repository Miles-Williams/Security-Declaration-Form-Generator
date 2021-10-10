<Serializable()>
Public Class C_Destination

    Private _name As String
    Private _address As String
    Private _nameTextLines As Integer
    Private _addressTextLines As Integer

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Property NameTextLines() As Integer
        Get
            Return _nameTextLines
        End Get
        Set(ByVal value As Integer)
            _nameTextLines = value
        End Set
    End Property

    Public Property AddressTextLines() As Integer
        Get
            Return _addressTextLines
        End Get
        Set(ByVal value As Integer)
            _addressTextLines = value
        End Set
    End Property

    Public Sub New(Optional parName As String = "",
                   Optional parAddress As String = "",
                   Optional parNametextlines As Integer = 2,
                   Optional parAddressTextLines As Integer = 3)

        _name = parName
        _address = parAddress
        _nameTextLines = parNametextlines
        _addressTextLines = parAddressTextLines

    End Sub

End Class
