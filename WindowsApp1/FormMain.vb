Imports System.Threading
Imports System.Threading.Tasks

Public Class FormMain


    Private _task As Task
    Private _ts As CancellationTokenSource
    Private _ct As CancellationToken
    Const MAX_ITERATIONS As Integer = 20
    Private _progressWindow As ProgressWindow

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

    ' ***************************
    ' Button Events        
    ' ***************************
#Region "Button Events"

    ''' <summary>
    ''' button_Start_Task_Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button_Start_Task_Click(sender As Object, e As EventArgs) Handles button_Start_Task.Click
        _progressWindow.Show()
        EnableDisableButtons(True)
        _progressWindow.ProgressSet(MAX_ITERATIONS * MAX_ITERATIONS * MAX_ITERATIONS)
        _progressWindow.ProgressBarReset()
        _ts = New CancellationTokenSource()
        _ct = _ts.Token
        _task = Task.Factory.StartNew(Sub() JobManager(), _ct)
    End Sub

    ''' <summary>
    ''' button_Cancel_Task_Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button_Cancel_Task_Click(sender As Object, e As EventArgs) Handles button_Cancel_Task.Click
        _ts.Cancel()
        EnableDisableButtons(False)
        _progressWindow.Hide()
    End Sub

    ''' <summary>
    ''' button_Toggle_Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button_Toggle_Click(sender As Object, e As EventArgs) Handles button_Toggle.Click
        If _progressWindow.Visible Then
            _progressWindow.Hide()
        Else
            _progressWindow.Show()
        End If
    End Sub

    ''' <summary>
    ''' button_Close_Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button_Close_Click(sender As Object, e As EventArgs) Handles button_Close.Click
        Close()
    End Sub

#End Region
    ' ***************************
    ' Menu Events          
    ' ***************************
#Region "Menu Events"

#End Region
    ' ***************************
    ' Other Events          
    ' ***************************
#Region "Other Events"

    ''' <summary>
    ''' FormMain_Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDisableButtons(False)
        _progressWindow = New ProgressWindow()
        _progressWindow.Owner = Me
        AddHandler _progressWindow.Cancel, AddressOf Me.CancelEvent
    End Sub

    ''' <summary>
    ''' CancelEvent
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelEvent(ByVal sender As Object, ByVal e As EventArgs)
        _ts.Cancel()
        EnableDisableButtons(False)
    End Sub

    ''' <summary>
    ''' FormMain_FormClosing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _progressWindow.Dispose()
        e.Cancel = False
    End Sub

#End Region
    ' ***************************
    ' Other Functions       
    ' ***************************
#Region "Other Functions"

    ''' <summary>
    ''' JobManager
    ''' </summary>
    Public Sub JobManager()

        ' Call the TheHugeJob
        TheHugeJob()
        _progressWindow.Invoke(CType((Sub() _progressWindow.Hide()), Action))
        ' Mange button state
        EnableDisableButtons(False)
        ' give a signal
        Console.Beep()
    End Sub

    ''' <summary>
    ''' TheHugeJob
    ''' </summary>
    Public Sub TheHugeJob()
        Dim i, j, k As Integer
        Dim d As Double = 0.0

        For i = 0 To MAX_ITERATIONS - 1

            For j = 0 To MAX_ITERATIONS - 1

                For k = 0 To MAX_ITERATIONS - 1

                    If _ct.IsCancellationRequested Then
                        ' UI thread decided to cancel
                        Debug.WriteLine(String.Format("We have a Cancellation Requested "))
                        Return
                    End If

                    d += 1
                    Debug.WriteLine(String.Format("i={0} j={1} k={2} d={3}", i, j, k, d))
                    _progressWindow.ProgressBarUpDate()
                Next
            Next
        Next
    End Sub

    ''' <summary>
    ''' EnableDisableButtons
    ''' </summary>
    ''' <param name="running"></param>
    Private Sub EnableDisableButtons(ByVal running As Boolean)
        Me.button_Start_Task.Invoke(Sub() button_Cancel_Task.Enabled = running)
        Me.button_Start_Task.Invoke(Sub() button_Start_Task.Enabled = Not running)
    End Sub
#End Region
End Class
