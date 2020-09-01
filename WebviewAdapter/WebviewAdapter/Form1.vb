Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each arg As String In My.Application.CommandLineArgs
            'Parse the incoming argument and update the user interface
            If arg.Contains("=") Then
                ' Split the arguments into key value pairs
                Dim argchunk As String() = arg.Split("=")
                Dim propertiesName As String = argchunk(0)
                Dim value As String = argchunk(1)

                ' Apply the values to the form
                Select Case propertiesName
                    Case "title"
                        Me.Text = value
                    Case "width"
                        Me.Size = New Size(Int(value), Me.Size.Height)
                    Case "height"
                        Me.Size = New Size(Me.Size.Width, Int(value))
                    Case "allow-resize"
                        If value.ToLower() = "false" Then
                            'Disable resizing
                            Me.FormBorderStyle = FormBorderStyle.FixedSingle
                        Else
                            'Default

                        End If
                    Case "icon"
                        value = System.IO.Path.GetFullPath(value)
                        If My.Computer.FileSystem.FileExists(value) Then
                            Me.Icon = New Icon(value)
                        Else
                            MsgBox("Icon file not found, given: " + value)
                        End If
                    Case "url"
                        WebBrowser1.Navigate(value)
                    Case "allow-max"
                        If value.ToLower() = "false" Then
                            Me.MaximizeBox = False
                        Else
                            Me.MaximizeBox = True
                        End If
                    Case "allow-min"
                        If value.ToLower() = "false" Then
                            Me.MinimizeBox = False
                        Else
                            Me.MinimizeBox = True
                        End If
                    Case "allow-scroll"
                        If value.ToLower() = "false" Then
                            WebBrowser1.ScrollBarsEnabled = False
                        Else
                            WebBrowser1.ScrollBarsEnabled = True
                        End If
                    Case "opacity"
                        Me.Opacity = value
                    Case "allow-taskbar"
                        If value.ToLower() = "false" Then
                            Me.ShowInTaskbar = False
                        Else
                            Me.ShowInTaskbar = True
                        End If
                    Case "top-most"
                        If value.ToLower() = "false" Then
                            Me.TopMost = False
                        Else
                            Me.TopMost = True
                        End If
                    Case "show-icon"
                        If value.ToLower() = "false" Then
                            Me.ShowIcon = False
                        Else
                            Me.ShowIcon = True
                        End If
                    Case "start-location"
                        If value.Contains(",") Then
                            Dim pos As String() = value.Split(",")
                            Me.Left = pos(0)
                            Me.Top = pos(1)
                        End If

                End Select
            End If


        Next
    End Sub
End Class
