﻿Public Class Main
    Public Rstudent As String
    Public student_list As New List(Of String) 'List of students from file provided
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wheel_PB.Image = My.Resources.wheel_static
        Timer1.Interval = 3000
        Timer2.Interval = 300
        Student_MLB.Visible = False
        Label2.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Spin_BT.Click

        If My.Computer.FileSystem.FileExists(My.Settings.File_Location) Then 'Check if the provided file exist

            My.Computer.Audio.Play(My.Resources.Spin_Sound, AudioPlayMode.Background) 'Audio FX
            Wheel_PB.Image = My.Resources.wheel_anim 'Start wheel animation
            Timer1.Enabled = True 'Enabling and starting the timer for enabling again the buttons
            Timer1.Start()
            Timer2.Enabled = True
            Timer2.Start()
            Spin_BT.Enabled = False 'Disabling buttons
            File_BT.Enabled = False
            Student_MLB.Visible = True 'Enabling the student's name label
            Label2.Visible = True
            Spin_BT.Text = "Tirage ..."
            Dim rn As New Random

            Try
                Using fReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(My.Settings.File_Location, System.Text.Encoding.UTF8)
                    fReader.TextFieldType = FileIO.FieldType.Delimited 'Define the file delimiter by ;
                    fReader.SetDelimiters(",")

                    Dim currentRow As String()

                    While Not fReader.EndOfData

                        Try
                            currentRow = fReader.ReadFields()
                            Dim currentField As String
                            For Each currentField In currentRow
                                student_list.Add(currentField)
                            Next

                            My.Settings.Student_Choosed = student_list(rn.Next(0, student_list.Count - 1)) 'Random selection of the student

                        Catch ex As Exception
                            MsgBox("Une erreur est survenue", MsgBoxStyle.Exclamation) 'Diplay error if an issue occurs
                        End Try

                    End While

                End Using

            Catch ex As Exception
                MsgBox("Une erreur est survenue", MsgBoxStyle.Exclamation) 'Diplay error if an issue occurs
            End Try

        Else
            MsgBox("Aucun fichier d'élèves défini", MsgBoxStyle.Information, "Alerte") 'Display a warning if no file is provided
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Timer1.Stop()
        Timer2.Enabled = False
        Timer2.Stop()
        Wheel_PB.Image = My.Resources.wheel_static
        Spin_BT.Enabled = True
        File_BT.Enabled = True
        Student_MLB.Text = My.Settings.Student_Choosed
        Spin_BT.Text = "Tirer"

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Copyright_LB.Click
        Process.Start("https://github.com/ethandudu/StudentPicker")
    End Sub

    Private Sub File_BT_Click(sender As Object, e As EventArgs) Handles File_BT.Click
        File_Dialog.Title = "Sélectionnez votre fichier élèves"
        File_Dialog.ShowDialog()
        My.Settings.File_Location = File_Dialog.FileName
        My.Settings.Save()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim rn As New Random
        Rstudent = student_list(rn.Next(0, student_list.Count - 1))
        Student_MLB.Text = Rstudent
    End Sub
End Class