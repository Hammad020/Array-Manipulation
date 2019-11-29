
Module Module1

    Sub Main()
        Dim namesArr(10) As String
        Dim sName As String
        Dim i As Integer
        Dim isFound As Boolean
        isFound = False

        'Initialisation
        For i = 1 To 9
            namesArr(i) = ""
        Next

        'populate
        For i = 1 To 9
            Console.Write("Enter name:" & i & " ")
            sName = Console.ReadLine
            namesArr(i) = sName
        Next

        'output all
        For i = 1 To 9
            Console.WriteLine(namesArr(i))
        Next

        'searching
        Console.Write("Enter Name to search for: ")
        sName = Console.ReadLine
        For i = 1 To 9
            If namesArr(i) = sName Then
                Console.WriteLine(i)
                isFound = True
            End If
        Next
        If isFound = False Then
            Console.WriteLine("Name was not found.")
        End If
        Console.ReadKey()

    End Sub

End Module

