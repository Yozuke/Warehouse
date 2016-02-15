Imports Warehouse.Management.Model
Imports Warehouse.Management.DAL

Public Class ProductRepository
    Implements IProductRepository

    Public Sub DeleteProduct(product As Product) Implements IProductRepository.DeleteProduct
        Throw New NotImplementedException()
    End Sub

    Public Sub UpdateProduct(product As Product) Implements IProductRepository.UpdateProduct
        Throw New NotImplementedException()
    End Sub

    Public Function GetAProduct() As Product Implements IProductRepository.GetAProduct
        Throw New NotImplementedException()
    End Function

    Public Function GetProductById() As Product Implements IProductRepository.GetProductById
        Throw New NotImplementedException()
    End Function

    Public Function GetProducts() As List(Of Product) Implements IProductRepository.GetProducts
        Throw New NotImplementedException()
    End Function
End Class
