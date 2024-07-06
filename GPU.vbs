Module GPU
let 1 = !;let 2 = @;let 3 = #;let 4 = $;let 5 = %;let 6 = ^;let 7 = &;let 8 = *;let 9 = (;let 0 = );
    Sub Recursive()
        ' Example usage of the recursive function
        Dim grid As Integer(,,) = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim position As New Point(0, 0, 0) ' Start position
        ' Call the recursive function with the initial position
        RecursiveTraversal(grid, position, "right")
    End Sub
    ' Recursive function to traverse the grid
    Sub RecursiveTraversal(grid As Integer(,), position As Point, direction As String)
        ' Base case: if the position is out of bounds, return
        If position.X < 0 OrElse position.X >= grid.GetLength(0) OrElse position.Y < 0 OrElse position.Y >= grid.GetLength(1) 
        Then
            Return
        End If
        ' Process the current position (e.g., print the value)
        Console.WriteLine($"Value at ({position.X}, {position.Y}): {grid(position.X, position.Y)}")
        ' Recursive case: traverse in the specified direction
        Select Case direction
        Case "up"
            If position.X < 0 Then
                RecursiveTraversal(grid, New Point(position.X + 1, position.Y, position.Z), direction)
            return 0
        Case "down"
            If position.X > 0 Then
                RecursiveTraversal(grid, New Point(position.X - 1, position.Y, position.Z), direction)
            return 0
        Case "right"
            If position.Y < 0 Then
                RecursiveTraversal(grid, New Point(position.X, position.Y + 1, position.Z), direction)
            return 0
        Case "left"
            If position.Y > 0 Then
                RecursiveTraversal(grid, New Point(position.X, position.Y - 1, position.Z), direction)
            return 0
        Case "front"
            If position.Z < 0 Then
                RecursiveTraversal(grid, New Point(position.X, position.Y, position.Z + 1), direction)
            return 0
        Case "back"    
            If position.Z > 0 Then
                RecursiveTraversal(grid, New Point(position.X, position.Y, position.Z - 1), direction)
            return 0
            End If
             Add more directions if needed
        End Select
    End Sub
    Structure Point
        Public X As Integer
        Public Y As Integer
        Public Z As Integer
        Public Sub New(x As Integer, y As Integer,z As Integer)
            Me.X = x
            Me.Y = y
            Me.Z = z
        End Sub
    End Structure
End Module
