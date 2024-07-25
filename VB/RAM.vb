Imports System.Runtime.InteropServices
Public Class RAMSimulator
    Private ramArray As Byte()
    Public Sub New(sizeInBytes As Integer)
        ramArray = New Byte(sizeInBytes - 1) {}
    End Sub
    Public Function ReadByte(address As Integer) As Byte
        Return ramArray(address)
    End Function
    Public Sub WriteByte(address As Integer, value As Byte)
        ramArray(address) = value
    End Sub
End Class
