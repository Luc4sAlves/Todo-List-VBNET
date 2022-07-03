Public Class CriticalityOptions
    'add an id and a name
    Public Property CriticalityId As Integer
    Public Property Name As String

    Public Property options As optionsEnum

    'convert options to IEnumerable

    'add a function to get the criticality options
    Public Shared Function GetCriticalityOptions() As List(Of CriticalityOptions)
        Dim criticalityOptions As New List(Of CriticalityOptions)
        criticalityOptions.Add(New CriticalityOptions With {.CriticalityId = 1, .Name = "Low"})
        criticalityOptions.Add(New CriticalityOptions With {.CriticalityId = 2, .Name = "Medium"})
        criticalityOptions.Add(New CriticalityOptions With {.CriticalityId = 3, .Name = "High"})
        Return criticalityOptions
    End Function

    Enum optionsEnum
        Low
        Medium
        High
    End Enum

End Class
