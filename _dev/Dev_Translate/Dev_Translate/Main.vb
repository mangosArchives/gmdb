
Module Main

    Sub Main()
        Dim CSVPath, CacheString(), NullStrings() As String
        Dim NULLExisting As Boolean = False
        Dim Reader As New IO.StreamReader("creature_ai_texts.csv")
        Dim Writer As New IO.StreamWriter("creature_ai_texts.sql")
        Do
            If Reader.EndOfStream Then Exit Do
            CacheString = Reader.ReadLine().Replace(Chr(34), "").Split(";")
            If CacheString(2) = "NULL" Then
                'NullStrings = CacheString
                NULLExisting = True
            Else
                Writer.WriteLine("UPDATE creature_ai_texts SET content_loc3 = '" & CacheString(2) & "' WHERE entry = " & CacheString(0) & ";")
            End If
        Loop
        Reader.Close()
        Writer.Close()

        If NULLExisting Then
            Console.WriteLine("SQL created, but there are some untranslated creature_texts")
        Else
            Console.WriteLine("SQL created!")
        End If

        Console.ReadLine()
    End Sub

End Module
