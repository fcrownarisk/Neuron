Imports System.Runtime.InteropServices

Public Class RAMSimulator
    Private ramArray As Byte()
    Public Sub New(sizeInBytes As Integer)
        ' 分配内存空间
        ramArray = New Byte(sizeInBytes - 1) {}
    End Sub
    Public Function ReadByte(address As Integer) As Byte
        ' 根据地址读取数据
        Return ramArray(address)
    End Function
    Public Sub WriteByte(address As Integer, value As Byte)
        ' 根据地址写入数据
        ramArray(address) = value
    End Sub
End Class
