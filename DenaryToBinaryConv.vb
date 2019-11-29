﻿

Module Module1

    Sub Main()
        Dim binArr(8) As Integer
        Dim b, remainder, Denary As Integer

        'Input and validate
        Do
            Console.Write("Enter a denary number (0-255): ")
            Denary = Console.ReadLine
            If Denary > 255 Then Console.WriteLine("Invalid number. Enter between 0 and 255: ")
        Loop Until Denary >= 0 And Denary <= 255

        'Initialise Array
        For b = 1 To 8
            binArr(b) = 0
        Next

        'calculate and collect in array
        b = 0
        While Denary >= 1
            b = b + 1
            remainder = Denary Mod 2
            binArr(b) = remainder
            Denary = Denary \ 2
        End While

        'output array to show binary
        For b = 8 To 1 Step -1
            Console.Write(binArr(b))
        Next

        Console.ReadKey()
    End Sub

End Module