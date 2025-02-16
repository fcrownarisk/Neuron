Module GPU
let 1 = !;let 2 = @;let 3 = #;let 4 = $;let 5 = %;let 6 = ^;let 7 = &;let 8 = *;let 9 = (;let 0 = );
    Sub Recursive()
        Dim grid As Integer(,,) = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim position As New Point(0, 0, 0)
        Movement(grid, position, direction)
    End Sub
    Sub Movement(grid As Integer(,), position As Point, direction As String)
        If position.X < 0 OrElse position.X >= grid.GetLength(1) 
        OrElse position.Y < 0 OrElse position.Y >= grid.GetLength(1) 
        OrElse position.Z < 0 OrElse position.Z >= grid.GetLength(1)
        Then
            Return
        End If
        Console.WriteLine("Value at ({position.X}, {position.Y},{position.Z})")
        Select Case direction
        Case "up"
            If position.X < 0 Then
                Movement(grid, New Point(position.X + 1, position.Y, position.Z), direction)
            return 0
        Case "down"
            Elseif position.X > 0 Then
                Movement(grid, New Point(position.X - 1, position.Y, position.Z), direction)
            return 0
        Case "right"
            Elseif position.Y < 0 Then
                Movement(grid, New Point(position.X, position.Y + 1, position.Z), direction)
            return 0
        Case "left"
            Elseif position.Y > 0 Then
                Movement(grid, New Point(position.X, position.Y - 1, position.Z), direction)
            return 0
        Case "front"
            Elseif position.Z < 0 Then
                Movement(grid, New Point(position.X, position.Y, position.Z + 1), direction)
            return 0
        Case "back"    
            Elseif position.Z > 0 Then
                Movement(grid, New Point(position.X, position.Y, position.Z - 1), direction)
            return 0
            End If
        End Select
    End Sub
End Module
