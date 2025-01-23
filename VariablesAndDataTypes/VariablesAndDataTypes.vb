'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/JaceFoxman/OperatorsExample.git

Option Explicit On
Option Strict Off

Module VariablesAndDataTypes

    Sub Main()

        'camelCase/Declare Variavbles 
        Dim jellyBeans As Integer
        Dim laffyTaffy As Integer
        Dim money As Decimal
        Dim studentName As String


        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10 'can also write as jellyBeans += 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        laffyTaffy = 26
        Console.WriteLine(laffyTaffy)

        money = 9.12837490812374D 'adding D tells the system you know
        jellyBeans = CInt(1.56)
        studentName = "7"

        jellyBeans = CInt(studentName)

        Console.WriteLine()


    End Sub

End Module
