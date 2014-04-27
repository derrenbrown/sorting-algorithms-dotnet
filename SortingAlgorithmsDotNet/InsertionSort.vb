Public Class InsertionSort

#Region "Methods"
    Public Sub InsertionSort(ByVal InputArray As Integer())

        For i As Integer = 1 To InputArray.Length - 1

            Dim _Key As Integer = InputArray(i)
            Dim j As Integer = i - 1

            While j >= 0 AndAlso InputArray(j) > _Key

                InputArray(j + 1) = InputArray(j)
                j -= 1

            End While

            InputArray(j + 1) = _Key

        Next

    End Sub
#End Region

End Class
