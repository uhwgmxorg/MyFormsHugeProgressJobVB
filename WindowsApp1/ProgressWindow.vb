Public Class ProgressWindow

    Public Event Cancel As EventHandler

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        RaiseEvent Cancel(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' ProgressWindow_Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProgressWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        StartPosition = FormStartPosition.CenterParent
    End Sub

    ''' <summary>
    ''' ProgressWindow_VisibleChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProgressWindow_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Top = Owner.Top + (Owner.Height - Height) / 2
        Left = Owner.Left + (Owner.Width - Width) / 2
    End Sub

    ''' <summary>
    ''' ProgressWindow_FormClosing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProgressWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    ''' <summary>
    ''' ProgressBarUpDate
    ''' </summary>
    Public Sub ProgressBarUpDate()
        Me.progressBar1.Invoke(CType(Sub() Math.Min(Threading.Interlocked.Increment(Me.progressBar1.Value), Me.progressBar1.Value - 1), Action))
    End Sub

    ''' <summary>
    ''' ProgressBarReset
    ''' </summary>
    Public Sub ProgressBarReset()
        Me.progressBar1.Value = Me.progressBar1.Minimum
    End Sub

    ''' <summary>
    ''' ProgressSet
    ''' </summary>
    ''' <param name="max"></param>
    ''' <param name="min"></param>
    Public Sub ProgressSet(ByVal max As Integer, ByVal Optional min As Integer = 0)
        Me.progressBar1.Maximum = max
        Me.progressBar1.Minimum = min
    End Sub
End Class