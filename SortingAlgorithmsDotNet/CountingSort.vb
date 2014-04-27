Public Class CountingSort

#Region "Methods"
    Public Function CountingSort(ByVal InputArray As Integer()) As Integer()

        Dim _CountArray As Integer() = New Integer(InputArray.Max) {}
        Dim _OutputArray As Integer() = New Integer(InputArray.Length - 1) {}

        For i As Integer = 0 To InputArray.Length - 1

            _CountArray(InputArray(i)) += 1

        Next

        For i As Integer = 1 To _CountArray.Length - 1

            _CountArray(i) += _CountArray(i - 1)

        Next

        For i As Integer = 0 To InputArray.Length - 1

            _OutputArray(_CountArray(InputArray(i)) - 1) = InputArray(i)
            _CountArray(InputArray(i)) -= 1

        Next

        Return _OutputArray

    End Function
#End Region

End Class
