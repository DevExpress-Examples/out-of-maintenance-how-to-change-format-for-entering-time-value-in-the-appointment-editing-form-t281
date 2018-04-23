Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomAppointmentFormWithSeconds
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = (DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl))
            Dim form As New CustomAppointmentFormWithSeconds.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
            Try
                e.DialogResult = form.ShowDialog()
                e.Handled = True
            Finally
                form.Dispose()
            End Try

        End Sub
    End Class
End Namespace
