Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Réseaux.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unused = Shell("C:\Users\Simon\test\psexec.bat")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Réseaux.Items.Clear()
        'checklan("10.80.15.", 1)
        'checklan("10.80.24.", 1)
        'checklan("10.255.85.", 1)
        'checklan("10.80.13.", 1)
        checklan("10.80.1.", 1)
        checklan("10.80.6.", 1)
        checklan("10.80.102.", 1)
        'checklan("10.80.15.", 2)
        'checklan("10.80.24.", 2)
        'checklan("10.255.85.", 2)
        'checklan("10.80.13.", 2)
        checklan("10.80.1.", 2)
        checklan("10.80.6.", 2)
        checklan("10.80.102.", 2)
        ''quiter l'application
    End Sub
    Function checklan(lan, état)
        '''test du réseau sélectionné
        ''crée une liste de poste a ne pas éteindre (whitelist)
        Dim count = 0
        For x = 1 To 10
            If My.Computer.Network.Ping(lan & x) Then
                count = count + 1
                Réseaux.Items.Add(lan & x & " = Server pinged successfully.")
                ''lancer un web service qui sauvegardera l'indication post allumé dans la base sur le cham état correspondant
                ''éteindre le PC si il n'appartien pas a la whitlist
            End If
        Next
        If count = 0 Then Réseaux.Items.Add(lan & "0/24s = aucun PC n'as été Ping")
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''lancer un web service pour réinitialiser les état a vide
        ''démarer un timer qui lancera au bout de 3 minutes une fonction (la meme que label6_click) penser a éteindre la timer
    End Sub
End Class
