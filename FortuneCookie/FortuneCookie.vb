'Miranda Breves
'RCET0265
'Spring 2022
'Fortune Cookie
'https://github.com/MEBreves/FortuneCookie

Option Explicit On
Option Strict On
Module FortuneCookie

    Sub Main()

        'Declaring variable
        Dim randomNumber As Integer

        'To turn on the random number generator program, the random function must be initialized. Then the function can be used.
        'If not initialized, the Rnd Function will output the same value everytime.
        Randomize()
        randomNumber = CInt((Rnd() * 7) + 1) 'Generates a random number between 1 and 8

        'Announcing the fortune to the user
        Console.WriteLine("Behold, your fortune: ")
        Console.WriteLine()

        'Picking a random fortune from 8 options based off of the random number created above
        Select Case randomNumber
            Case 1
                Console.WriteLine("I hope it's snowing and cold, because you're going to be stuck inside all day.")
            Case 2
                Console.WriteLine("Huzzah! Someone will invite you to something over the weekend.")
            Case 3
                Console.WriteLine("Study up. There's a quiz coming soon, and not everyone will be prepared.")
            Case 4
                Console.WriteLine("Check the grocery store sales. You'll find a good deal on something you've wanted for a while.")
            Case 5
                Console.WriteLine("Have you tried the Tech Cafe soup? Today's gonna be a doozy.")
            Case 6
                Console.WriteLine("Watch out for those stairs, man.")
            Case 7
                Console.WriteLine("Don't let yesterday take up too much of today.")
            Case 8
                Console.WriteLine("If you eat something and nobody sees you eat it, it has no calories.")
            Case Else
                Console.WriteLine(randomNumber)
                Console.WriteLine("The spirits seem to not like you today. This option had no chance of happening.")
        End Select

        Console.WriteLine()
        Console.WriteLine("Please press the Enter key to exit the program.")
        Console.Read()

    End Sub

End Module
