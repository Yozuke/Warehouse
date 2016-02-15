Public Class Product
    Private _productId As Integer
    Private _productName As String
    Private _stock As Integer
    Private _volumetric As Integer
    Private _priceInternational As Double
    Private _priceDomestic As Double
    Private _sale As Double
    Private _percentage As Decimal

    Public Property ProductId As Integer
        Get
            Return _productId
        End Get
        Set(value As Integer)
            _productId = value
        End Set
    End Property
    Public Property ProductName As String
        Get
            Return _productName
        End Get
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                _productName = value
            End If
        End Set
    End Property
    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
    Public Property Volumetric As Integer
        Get
            Return _volumetric
        End Get
        Set(value As Integer)
            _volumetric = value
        End Set
    End Property
    Public Property PriceInternational As Double
        Get
            Return _priceInternational
        End Get
        Set(value As Double)
            _priceInternational = value
        End Set
    End Property
    Public Property PriceDomestic As Double
        Get
            Return _priceDomestic
        End Get
        Set(value As Double)
            _priceDomestic = value
        End Set
    End Property
    Public Property Sale As Double
        Get
            Return _sale
        End Get
        Set(value As Double)
            _sale = value
        End Set
    End Property
    Public Property Percentage As Decimal
        Get
            Return _percentage
        End Get
        Set(value As Decimal)
            _percentage = value
        End Set
    End Property
End Class
