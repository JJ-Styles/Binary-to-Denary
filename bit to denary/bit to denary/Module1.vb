Module Module1

    Sub Main()
        Dim answer As Integer = 0
        Dim bit As String
        Dim column As Integer = 0

        Console.WriteLine("Enter Bit Value:")
        bit = Console.ReadLine
        column = Math.Pow(2, (bit.ToString.Length - 1))
        answer = answer + (column * Convert.ToInt32(bit.ToString.Substring(0, 1)))

        Do
            bit = bit.ToString.Substring(1, (bit.ToString.Length - 1))
            column = column / 2
            answer = answer + (column * Convert.ToInt32(bit.ToString.Substring(0, 1)))
        Loop Until (column < 1) Or (bit.ToString.Length = 1)
        Console.WriteLine("Decimal Value Is: " & answer)
        Console.ReadKey()
    End Sub

End Module
