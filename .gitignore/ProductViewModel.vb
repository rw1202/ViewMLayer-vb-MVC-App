Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library
Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New
        LoadProducts()
    End Sub

    Public Property Products As ObservableCollection(Of Product)
    Public Property Entity As Product

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts()
    End Function

    Function LoadProducts(ByVal startingFilePath As String) _
        As ObservableCollection(Of Product)
        Dim mgr = New ProductManager
        Products = mgr.LoadProducts(startingFilePath)
        Return Products
    End Function
    '    Function LoadProduct(ByVal ProductId As Integer) As Product
    '        Return LoadProduct(ProductId)
    '
    '    End Function

    '    Function LoadProduct(ByVal ProductId As Integer, _
    '                         ByVal startingFilePath As String) As Product
    '        Entity = New Product() With {.ProductId = 680,
    '            .ListPrice = 100, .Name = "10 Speed Bike",
    '            .IsActive = True, .ProductNumber = "500"
    '                        }
    '        Return Entity
    '    End Function
End Class
