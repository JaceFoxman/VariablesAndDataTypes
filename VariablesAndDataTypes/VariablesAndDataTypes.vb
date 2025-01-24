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

        Dim jellybeans As Integer
        Dim laffytaffy As Integer
        Dim money As Decimal
        Dim studentname As String
        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer = 5

        Console.WriteLine(jellybeans)

        jellybeans = 120
        Console.WriteLine(jellybeans)

        jellybeans = jellybeans + 10 'can also write as jellyBeans += 10
        Console.WriteLine(jellybeans)

        jellybeans += 10
        Console.WriteLine(jellybeans)

        laffytaffy = 26
        Console.WriteLine(laffytaffy)

        money = 9.12837490812374D 'adding D tells the system you know
        jellybeans = CInt(1.56)
        studentname = "7"

        jellybeans = CInt(studentname)

        Console.WriteLine("Please enter a fruit")
        userInput = Console.ReadLine()

        Console.Write("The fruit you entered was: ")
        Console.WriteLine(userInput)

        Console.WriteLine($"You Entered:{userInput}!")




        'Decisions
        Console.Write($"choose 1st number:")
        userInput = Console.ReadLine()

        firstNumber = CInt(userInput)

        Console.WriteLine("Please make a selection:" & vbNewLine _
                          & "1.add" & vbNewLine _
                          & "2.subtract" & vbNewLine _
                          & "3.multiply")

        userInput = Console.ReadLine()

        Console.WriteLine($"you chose {userInput}")

        If userInput = "1" Then
            Console.WriteLine("let's add")
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        ElseIf userInput = "2" Then
            Console.WriteLine("let's subtract")
        ElseIf userInput = "3" Then
            Console.WriteLine("let's multiply")
        Else
            Console.WriteLine("Invalid Option")
        End If



    End Sub

End Module
