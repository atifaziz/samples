Imports System
Imports System.Xml
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Protected DataSet1 As DataSet
    Protected dataGrid1 As DataGrid
    
' <Snippet1>
 Public Sub CreateOleDbConnection()
     Dim connection As New OleDbConnection()
     connection.ConnectionString = _
        "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Northwind.mdb"
     Console.WriteLine("Connection State: " & connection.State.ToString())
 End Sub
' </Snippet1>
End Class
