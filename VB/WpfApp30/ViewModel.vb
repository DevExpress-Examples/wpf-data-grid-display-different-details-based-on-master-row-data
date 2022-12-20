Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WpfApp30

    Public Class ViewModel

        Public Property Tasks As ObservableCollection(Of WpfApp30.Task)

        Public Sub New()
            Me.InitTasks()
        End Sub

        Private Sub InitTasks()
            Me.Tasks = New System.Collections.ObjectModel.ObservableCollection(Of WpfApp30.Task)()
            For i As Integer = 0 To 30 - 1
                Dim succeed As Boolean = i Mod 2 = 0
                Dim task As WpfApp30.Task = DevExpress.Mvvm.POCO.ViewModelSource.Create(Function() New WpfApp30.Task() With {.TaskID = i, .TaskName = "Task" & i, .Succeed = succeed})
                If succeed Then
                    task.CompletedActions = Me.GenerateActions(i)
                Else
                    task.Errors = Me.GenerateErrors(i)
                End If

                Me.Tasks.Add(task)
            Next
        End Sub

        Private Function GenerateErrors(ByVal parentTaskID As Integer) As ObservableCollection(Of WpfApp30.[Error])
            Dim errors As System.Collections.ObjectModel.ObservableCollection(Of WpfApp30.[Error]) = New System.Collections.ObjectModel.ObservableCollection(Of WpfApp30.[Error])()
            For i As Integer = 0 To 10 - 1
                errors.Add(New WpfApp30.[Error]() With {.ErrorCode = parentTaskID * 1000 + i, .ErrorDescription = String.Format("Task {0} error {1}", parentTaskID, i)})
            Next

            Return errors
        End Function

        Private Function GenerateActions(ByVal parentTaskID As Integer) As ObservableCollection(Of WpfApp30.Action)
            Dim actions As System.Collections.ObjectModel.ObservableCollection(Of WpfApp30.Action) = New System.Collections.ObjectModel.ObservableCollection(Of WpfApp30.Action)()
            For i As Integer = 0 To 10 - 1
                actions.Add(New WpfApp30.Action() With {.ActionName = String.Format("Task {0} action {1}", parentTaskID, i)})
            Next

            Return actions
        End Function
    End Class

    Public Class Task

        Public Property TaskID As Integer

        Public Property TaskName As String

        Public Overridable Property Succeed As Boolean

        Public Property Errors As ObservableCollection(Of WpfApp30.[Error])

        Public Property CompletedActions As ObservableCollection(Of WpfApp30.Action)
    End Class

    Public Class [Error]

        Public Property ErrorCode As Integer

        Public Property ErrorDescription As String
    End Class

    Public Class Action

        Public Property ActionName As String
    End Class
End Namespace
