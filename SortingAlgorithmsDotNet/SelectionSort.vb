Public Class SelectionSort

#Region "Methods"
    Public Sub SelectionSort(ByVal InputArray As Integer())

        For i As Integer = 0 To InputArray.Length - 1

            Dim _MinIndex As Integer = i

            For j As Integer = i + 1 To InputArray.Length - 1

                If InputArray(j) < InputArray(_MinIndex) Then

                    _MinIndex = j

                End If

            Next

            If _MinIndex <> i Then

                Helpers.Swap(InputArray, _MinIndex, i)

            End If

        Next

    End Sub
#End Region

End Class
