Namespace CustomAppointmentFormWithSeconds
    Partial Public Class CustomAppointmentForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            DirectCast(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.progressPanel.SuspendLayout()
            DirectCast(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lblLabel
            ' 
            Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' chkAllDay
            ' 
            ' 
            ' edtStartDate
            ' 
            Me.edtStartDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
            ' 
            ' edtEndDate
            ' 
            Me.edtEndDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
            ' 
            ' edtStartTime
            ' 
            Me.edtStartTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
            ' 
            ' edtEndTime
            ' 
            Me.edtEndTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
            ' 
            ' edtLabel
            ' 
            ' 
            ' edtShowTimeAs
            ' 
            ' 
            ' tbSubject
            ' 
            ' 
            ' edtResource
            ' 
            ' 
            ' edtResources
            ' 
            ' 
            ' 
            ' 
            Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
            Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
            Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
            Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
            Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
            ' 
            ' chkReminder
            ' 
            ' 
            ' tbDescription
            ' 
            ' 
            ' cbReminder
            ' 
            ' 
            ' tbLocation
            ' 
            ' 
            ' tbProgress
            ' 
            Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            ' 
            ' lblPercentComplete
            ' 
            Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' lblPercentCompleteValue
            ' 
            Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
            ' 
            ' CustomAppointmentForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.ClientSize = New System.Drawing.Size(528, 382)
            Me.Name = "CustomAppointmentForm"
            DirectCast(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.progressPanel.ResumeLayout(False)
            Me.progressPanel.PerformLayout()
            DirectCast(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region
    End Class
End Namespace
