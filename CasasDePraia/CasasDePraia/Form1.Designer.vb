<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Group1 As Infragistics.Win.UltraWinListBar.Group = New Infragistics.Win.UltraWinListBar.Group(True)
        Dim Group2 As Infragistics.Win.UltraWinListBar.Group = New Infragistics.Win.UltraWinListBar.Group()
        Dim Group3 As Infragistics.Win.UltraWinListBar.Group = New Infragistics.Win.UltraWinListBar.Group()
        Dim Group4 As Infragistics.Win.UltraWinListBar.Group = New Infragistics.Win.UltraWinListBar.Group()
        Dim Group5 As Infragistics.Win.UltraWinListBar.Group = New Infragistics.Win.UltraWinListBar.Group()
        Dim TimeInterval1 As Infragistics.Win.UltraWinSchedule.TimeInterval = New Infragistics.Win.UltraWinSchedule.TimeInterval()
        Dim DateInterval1 As Infragistics.Win.UltraWinSchedule.DateInterval = New Infragistics.Win.UltraWinSchedule.DateInterval()
        Me.UltraCalendarLook1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        Me.UltraMonthViewMulti1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.UltraListBar1 = New Infragistics.Win.UltraWinListBar.UltraListBar()
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraTimelineView1 = New Infragistics.Win.UltraWinSchedule.UltraTimelineView()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraListBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraMonthViewMulti1
        '
        Me.UltraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti1.DayOfWeekCaptionStyle = Infragistics.Win.UltraWinSchedule.DayOfWeekCaptionStyle.FirstTwoLetters
        Me.UltraMonthViewMulti1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraMonthViewMulti1.Location = New System.Drawing.Point(0, 0)
        Me.UltraMonthViewMulti1.MonthDimensions = New System.Drawing.Size(6, 1)
        Me.UltraMonthViewMulti1.Name = "UltraMonthViewMulti1"
        Me.UltraMonthViewMulti1.ResizeMode = Infragistics.Win.UltraWinSchedule.ResizeMode.BaseOnControlSize
        Me.UltraMonthViewMulti1.Size = New System.Drawing.Size(1088, 130)
        Me.UltraMonthViewMulti1.TabIndex = 0
        '
        'UltraListBar1
        '
        Me.UltraListBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Group1.Key = "a"
        Group1.Text = "Casa dos Sabiás"
        Group2.Key = "b"
        Group2.Text = "Casa Igor"
        Group3.Key = "c"
        Group3.Text = "Casa Daniel"
        Group4.Key = "d"
        Group4.Text = "Sobrado Teresinha"
        Group5.Key = "e"
        Group5.Text = "Apartamento 31"
        Me.UltraListBar1.Groups.Add(Group1)
        Me.UltraListBar1.Groups.Add(Group2)
        Me.UltraListBar1.Groups.Add(Group3)
        Me.UltraListBar1.Groups.Add(Group4)
        Me.UltraListBar1.Groups.Add(Group5)
        Me.UltraListBar1.Location = New System.Drawing.Point(0, 0)
        Me.UltraListBar1.Name = "UltraListBar1"
        Me.UltraListBar1.Size = New System.Drawing.Size(333, 898)
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 940)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        Me.UltraStatusBar1.Size = New System.Drawing.Size(1425, 23)
        Me.UltraStatusBar1.TabIndex = 4
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraListBar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraTimelineView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraMonthViewMulti1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1425, 898)
        Me.SplitContainer1.SplitterDistance = 333
        Me.SplitContainer1.TabIndex = 6
        '
        'UltraTimelineView1
        '
        TimeInterval1.Interval = 12
        TimeInterval1.IntervalUnits = Infragistics.Win.UltraWinSchedule.TimeIntervalUnits.Hours
        Me.UltraTimelineView1.AdditionalIntervals.Add(TimeInterval1)
        Me.UltraTimelineView1.ColumnWidth = 0
        Me.UltraTimelineView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTimelineView1.Location = New System.Drawing.Point(0, 130)
        Me.UltraTimelineView1.MaximumOwnersInView = 6
        Me.UltraTimelineView1.MinimumRowResizeHeight = 30
        Me.UltraTimelineView1.Name = "UltraTimelineView1"
        Me.UltraTimelineView1.OwnerSizing = Infragistics.Win.UltraWinSchedule.TimelineViewOwnerSizing.Row
        Me.UltraTimelineView1.PrimaryInterval = DateInterval1
        Me.UltraTimelineView1.Size = New System.Drawing.Size(1088, 768)
        Me.UltraTimelineView1.TabIndex = 4
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.ToolStripContainer1)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1425, 42)
        Me.UltraPanel1.TabIndex = 3
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1425, 42)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1425, 42)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1425, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.CasasDePraia.My.Resources.Resources.Script_Load
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 39)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.CasasDePraia.My.Resources.Resources.Script_Edit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 39)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.CasasDePraia.My.Resources.Resources.Script_Delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 39)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1425, 963)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.UltraStatusBar1)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraListBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraCalendarLook1 As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
    Friend WithEvents UltraMonthViewMulti1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents UltraListBar1 As Infragistics.Win.UltraWinListBar.UltraListBar
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraTimelineView1 As Infragistics.Win.UltraWinSchedule.UltraTimelineView

End Class
