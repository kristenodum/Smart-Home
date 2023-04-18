<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmartHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picSmartHome = New System.Windows.Forms.PictureBox()
        Me.lblSmartHome = New System.Windows.Forms.Label()
        Me.lblElectricSavings = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMaxSavings = New System.Windows.Forms.Label()
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartHome
        '
        Me.picSmartHome.Image = Global.Smart_Home.My.Resources.Resources.smarthome
        Me.picSmartHome.Location = New System.Drawing.Point(0, 0)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(372, 241)
        Me.picSmartHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartHome.TabIndex = 0
        Me.picSmartHome.TabStop = False
        '
        'lblSmartHome
        '
        Me.lblSmartHome.AutoSize = True
        Me.lblSmartHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmartHome.Location = New System.Drawing.Point(468, 46)
        Me.lblSmartHome.Name = "lblSmartHome"
        Me.lblSmartHome.Size = New System.Drawing.Size(207, 37)
        Me.lblSmartHome.TabIndex = 1
        Me.lblSmartHome.Text = "Smart Home"
        '
        'lblElectricSavings
        '
        Me.lblElectricSavings.AutoSize = True
        Me.lblElectricSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectricSavings.Location = New System.Drawing.Point(450, 94)
        Me.lblElectricSavings.Name = "lblElectricSavings"
        Me.lblElectricSavings.Size = New System.Drawing.Size(259, 37)
        Me.lblElectricSavings.TabIndex = 2
        Me.lblElectricSavings.Text = "Electric Savings"
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Items.AddRange(New Object() {"January ", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September ", "October ", "November ", "December "})
        Me.cboMonths.Location = New System.Drawing.Point(502, 160)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(151, 26)
        Me.cboMonths.TabIndex = 3
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(346, 266)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(93, 20)
        Me.lblSavings.TabIndex = 4
        Me.lblSavings.Text = "XXXXXXX"
        Me.lblSavings.Visible = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Location = New System.Drawing.Point(326, 307)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(146, 42)
        Me.btnStatistics.TabIndex = 5
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(359, 368)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(69, 20)
        Me.lblAverageSavings.TabIndex = 6
        Me.lblAverageSavings.Text = "XXXXX"
        Me.lblAverageSavings.Visible = False
        '
        'lblMaxSavings
        '
        Me.lblMaxSavings.AutoSize = True
        Me.lblMaxSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSavings.Location = New System.Drawing.Point(359, 406)
        Me.lblMaxSavings.Name = "lblMaxSavings"
        Me.lblMaxSavings.Size = New System.Drawing.Size(69, 20)
        Me.lblMaxSavings.TabIndex = 7
        Me.lblMaxSavings.Text = "XXXXX"
        Me.lblMaxSavings.Visible = False
        '
        'SmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMaxSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblElectricSavings)
        Me.Controls.Add(Me.lblSmartHome)
        Me.Controls.Add(Me.picSmartHome)
        Me.Name = "SmartHome"
        Me.Text = "Smart Home Application"
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblSmartHome As Label
    Friend WithEvents lblElectricSavings As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMaxSavings As Label

    Private Sub SmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbxMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        'The cboMonths displays the savings for the seleced months 

        Dim intSelectedCityIndex = cboMonths.SelectedIndex
        lblSavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        'The btnStatistics click will calls two sub methods to compute the average monthly savings and 
        'the most savings for a given month 
        ComputeAverage()
        ComputeMaxSavings()
    End Sub
End Class
