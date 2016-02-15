Imports Warehouse.Management.Model

Public Interface IProductRepository
    Sub DeleteProduct(product As Product)
    Sub UpdateProduct(product As Product)
    Function GetProducts() As List(Of Product)
    Function GetAProduct() As Product
    Function GetProductById() As Product
End Interface
