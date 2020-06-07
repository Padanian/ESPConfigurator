Imports System.Net.Sockets
Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sock As TcpClient = New TcpClient()
            Dim address As Net.IPAddress = Net.IPAddress.Parse(txtIP.Text)
            sock.Connect(address, 80)

            If sock.Connected Then
                ToolStripStatusLabel1.Text = "Connessione stabilita."
                Dim stream As NetworkStream
                stream = sock.GetStream
                If stream.CanWrite Then


                    If txtSSID.Text <> "" Then
                        'astream.Write(Array As Byte(MAGIC_EEPROM))
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
                    End If
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
