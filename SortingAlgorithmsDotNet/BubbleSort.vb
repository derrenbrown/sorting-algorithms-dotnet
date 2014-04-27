Public Class BubbleSort

#Region "Methods"
    Public Sub BubbleSort(ByVal InputArray As Integer())

        For i As Integer = 0 To InputArray.Length - 1

            For j As Integer = 0 To InputArray.Length - 2

                If InputArray(j) > InputArray(j + 1) Then

                    Helpers.Swap(InputArray, j, j + 1)

                End If

            Next

        Next

    End Sub
#End Region

End Class
