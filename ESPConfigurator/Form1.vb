Imports System.Net.Sockets
Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sock As TcpClient = New TcpClient()
            Dim address As Net.IPAddress = Net.IPAddress.Parse(txtIP.Text)

            Dim test As Net.IPAddress = New Net.IPAddress(0)

            Net.IPAddress.TryParse(txtlocalIP.Text, test)
            txtlocalIP.Text = test.ToString
            Net.IPAddress.TryParse(txtlocalGW.Text, test)
            txtlocalGW.Text = test.ToString
            Net.IPAddress.TryParse(txtlocalSN.Text, test)
            txtlocalSN.Text = test.ToString
            Net.IPAddress.TryParse(txtlocalDN1.Text, test)
            txtlocalDN1.Text = test.ToString
            Net.IPAddress.TryParse(txtlocalDN2.Text, test)
            txtlocalDN2.Text = test.ToString


            If address.ToString = "" Then
                Throw New Exception("Indirizzo IP dell'access point non valido")
            ElseIf Not Net.IPAddress.TryParse(txtlocalIP.Text, test) Then
                Throw New Exception("Indirizzo IP locale non valido")
            ElseIf Not Net.IPAddress.TryParse(txtlocalGW.Text, test) Then
                Throw New Exception("Indirizzo IP del gateway  non valido")
            ElseIf Not Net.IPAddress.TryParse(txtlocalSN.Text, test) Then
                Throw New Exception("Subnect mask non valida")
            ElseIf Not Net.IPAddress.TryParse(txtlocalDN1.Text, test) Then
                Throw New Exception("Indirizzo IP del DNS primario non valido")
            ElseIf Not Net.IPAddress.TryParse(txtlocalDN2.Text, test) Then
                Throw New Exception("Indirizzo IP del DNS secondario non valido")
            ElseIf txtSSID.Text = "" Then
                Throw New Exception("Nome del SSID non valido.")
            End If

            sock.Connect(address, 80)

            If sock.Connected Then
                ToolStripStatusLabel1.Text = "Connessione stabilita."
                Dim stream As NetworkStream
                stream = sock.GetStream
                If stream.CanWrite Then

                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtSSID.Text), 0, txtSSID.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtPassword.Text), 0, txtPassword.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtlocalIP.Text), 0, txtlocalIP.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtlocalGW.Text), 0, txtlocalGW.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtlocalSN.Text), 0, txtlocalSN.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtlocalDN1.Text), 0, txtlocalDN1.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(txtlocalDN2.Text), 0, txtlocalDN2.Text.Length)
                    stream.Write(System.Text.Encoding.UTF8.GetBytes(vbLf), 0, 1)
                    Thread.Sleep(150)
                Else
                    ToolStripStatusLabel1.Text = "Impossibile stabilire la connessione"
                End If
            End If
            sock.Close()
            ToolStripStatusLabel1.Text &= " Invio ok. Disconnesso."
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
            ToolStripStatusLabel1.Text = "Impossibile stabilire la connessione"
        End Try
    End Sub
End Class
