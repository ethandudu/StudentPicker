<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Wheel_PB = New System.Windows.Forms.PictureBox()
        Me.Spin_BT = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Copyright_LB = New System.Windows.Forms.Label()
        Me.File_BT = New System.Windows.Forms.Button()
        Me.File_Dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Student_MLB = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Wheel_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wheel_PB
        '
        Me.Wheel_PB.Image = Global.Student_Picker.My.Resources.Resources.wheel_static
        Me.Wheel_PB.Location = New System.Drawing.Point(281, 141)
        Me.Wheel_PB.Name = "Wheel_PB"
        Me.Wheel_PB.Size = New System.Drawing.Size(239, 252)
        Me.Wheel_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Wheel_PB.TabIndex = 0
        Me.Wheel_PB.TabStop = False
        '
        'Spin_BT
        '
        Me.Spin_BT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Spin_BT.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spin_BT.Location = New System.Drawing.Point(331, 470)
        Me.Spin_BT.Name = "Spin_BT"
        Me.Spin_BT.Size = New System.Drawing.Size(139, 29)
        Me.Spin_BT.TabIndex = 1
        Me.Spin_BT.Text = "Tirer"
        Me.Spin_BT.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Picker"
        '
        'Copyright_LB
        '
        Me.Copyright_LB.AutoSize = True
        Me.Copyright_LB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Copyright_LB.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright_LB.Location = New System.Drawing.Point(12, 515)
        Me.Copyright_LB.Name = "Copyright_LB"
        Me.Copyright_LB.Size = New System.Drawing.Size(89, 15)
        Me.Copyright_LB.TabIndex = 2
        Me.Copyright_LB.Text = "© Ethan Duault"
        '
        'File_BT
        '
        Me.File_BT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.File_BT.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_BT.Location = New System.Drawing.Point(649, 176)
        Me.File_BT.Name = "File_BT"
        Me.File_BT.Size = New System.Drawing.Size(139, 29)
        Me.File_BT.TabIndex = 2
        Me.File_BT.Text = "Choisir fichier"
        Me.File_BT.UseVisualStyleBackColor = True
        '
        'File_Dialog
        '
        Me.File_Dialog.DefaultExt = "txt"
        Me.File_Dialog.Filter = "Fichiers TXT|*.txt"
        '
        'Student_MLB
        '
        Me.Student_MLB.AutoSize = True
        Me.Student_MLB.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_MLB.Location = New System.Drawing.Point(366, 441)
        Me.Student_MLB.Name = "Student_MLB"
        Me.Student_MLB.Size = New System.Drawing.Size(67, 23)
        Me.Student_MLB.TabIndex = 3
        Me.Student_MLB.Text = "ELEVE"
        Me.Student_MLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "L'élève choisi est :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Student_MLB)
        Me.Controls.Add(Me.Copyright_LB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.File_BT)
        Me.Controls.Add(Me.Spin_BT)
        Me.Controls.Add(Me.Wheel_PB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Picker"
        CType(Me.Wheel_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wheel_PB As PictureBox
    Friend WithEvents Spin_BT As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Copyright_LB As Label
    Friend WithEvents File_BT As Button
    Friend WithEvents File_Dialog As OpenFileDialog
    Friend WithEvents Student_MLB As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
End Class
