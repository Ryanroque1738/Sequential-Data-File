Imports System.IO

Module Module1

    Sub Main()

        Dim decSales As Decimal = 0

        Dim inputFile As StreamReader

        inputFile = File.OpenText("Sales.dat")

        Console.WriteLine("Sales from file sales.dat")

        Do Until inputFile.Peek = -1
            decSales = CDec(inputFile.ReadLine())
            Console.WriteLine(decSales)
        Loop

        inputFile.Close()

        Console.WriteLine()
        Console.Write("Press the enter key to terminate the program")
        Console.Read()

    End Sub

End Module
