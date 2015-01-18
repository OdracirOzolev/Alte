Imports System.Collections.Generic
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinSchedule
Imports System.Diagnostics

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.UltraTimelineView1.CalendarInfo.Owners.Add("a", "Casa dos Sabiás")
        Me.UltraTimelineView1.CalendarInfo.Owners.Add("b", "Casa Igor")
        Me.UltraTimelineView1.CalendarInfo.Owners.Add("c", "Casa Daniel")
        Me.UltraTimelineView1.CalendarInfo.Owners.Add("d", "Sbrado Teresinha")
        Me.UltraTimelineView1.CalendarInfo.Owners.Add("e", "Apartamento 31")

        InitOwnerProps(Me.UltraTimelineView1)

    End Sub

    Private Sub UltraMonthViewMulti1_Click(sender As Object, e As System.EventArgs) Handles UltraMonthViewMulti1.Click

        Me.UltraTimelineView1.CalendarInfo.SelectedDateRanges.Clear()
        Me.UltraTimelineView1.CalendarInfo.SelectedDateRanges.Add(Today)
        Me.UltraTimelineView1.CalendarInfo.ActiveDay = Me.UltraMonthViewMulti1.CalendarInfo.ActiveDay

    End Sub

    Public Sub InitOwnerProps(ByVal control As UltraTimelineView)

        '  Hide the unassigned owner
        control.CalendarInfo.Owners.UnassignedOwner.Visible = False

        '  Make each owner appear as a separate row in the control
        '  Make the header text run horizontally from left to right.
        control.OwnerGroupingStyle = TimelineViewOwnerGroupingStyle.Separate
        control.OwnerHeaderTextOrientation = New TextOrientationInfo(0, TextFlowDirection.Horizontal)

        '  Make three owners visible initially.
        control.MaximumOwnersInView = 3

        '  Show owner headers.
        control.OwnerHeadersVisible = DefaultableBoolean.True

        '  Make the image size (32 x 32), and align the image with
        '  the bottom of the header so it appears under the text.
        control.OwnerHeaderImageVisible = True
        control.OwnerHeaderImageSize = New Size(32, 32)
        control.OwnerHeaderAppearance.ImageHAlign = HAlign.Center
        control.OwnerHeaderAppearance.ImageVAlign = VAlign.Bottom

        '  Activate the first visible owner use the ActiveOwnerHeaderAppearance
        '  to customize the look.
        control.ActiveOwner = control.CalendarInfo.VisibleOwners(0)
        control.ActiveOwnerHeaderAppearance.BackColor = Color.White
        control.ActiveOwnerHeaderAppearance.BackColor2 = Color.LightBlue
        control.ActiveOwnerHeaderAppearance.BorderColor = Color.DarkBlue

        '  Allow sizing of the owner rows only from the header
        '  Impose a minimum resize height so that at least one
        '  row of appointments can be displayed.
        control.OwnerSizing = TimelineViewOwnerSizing.Header
        control.MinimumRowResizeHeight = control.ActivityHeightResolved + 20
        control.MaximumOwnersInView = 10
        control.ActivityHeight = 50

    End Sub

    Private Sub UltraTimelineView1_ActiveOwnerChanged(sender As Object, e As Infragistics.Win.UltraWinSchedule.ActiveOwnerChangedEventArgs) Handles UltraTimelineView1.ActiveOwnerChanged

        UltraListBar1.Groups.Item(e.NewActiveOwner.Key).Selected = True

    End Sub

    Private Sub UltraTimelineView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles UltraTimelineView1.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.UltraMonthViewMulti1.CalendarInfo.SelectedDateRanges.Clear()
            Me.UltraMonthViewMulti1.CalendarInfo.SelectedDateRanges.Add(Me.UltraTimelineView1.SelectedDateTimeRange.StartDateTime)
            Me.UltraMonthViewMulti1.EnsureVisible(Me.UltraMonthViewMulti1.CalendarInfo.GetMonth(Me.UltraMonthViewMulti1.CalendarInfo.SelectedDateRanges.Item(0).StartDate.Date))

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

        End If

    End Sub

End Class
