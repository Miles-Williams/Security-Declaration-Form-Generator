<Serializable()>
Public Class C_Destination
    Public Property Name As String
    Public Property Address As String
    'Public Property Suburb As String
    'Public Property State As String
    'Public Property PostalCode As String
    'Public Property Country As String

    Public Sub New(parName As String,
                   parAddress As String)
        'parSuburb As String,
        'parState As String,
        'parpostalCode As String,
        'parCountry As String)

        Name = parName
        Address = parAddress
        'Suburb = parSuburb
        'State = parState
        'PostalCode = parpostalCode
        'Country = parCountry

    End Sub

End Class
