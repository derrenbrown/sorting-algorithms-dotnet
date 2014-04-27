Public Class QuickSort

#Region "Members"
    Private _Pivot As New Random
#End Region

#Region "Methods"
    Public Sub QuickSort(ByVal InputArray As Integer())

        QuickSort(InputArray, 0, InputArray.Length - 1)

    End Sub

    Private Sub QuickSort(ByVal InputArray As Integer(),
                          ByVal Lo As Integer,
                          ByVal Hi As Integer)

        If Lo < Hi Then

            Dim _PivotIndex As Integer = _Pivot.Next(Lo, Hi)
            Dim _NewPivot As Integer = Partition(InputArray, Lo, Hi, _PivotIndex)

            QuickSort(InputArray, Lo, _NewPivot - 1)
            QuickSort(InputArray, _NewPivot + 1, Hi)

        End If

    End Sub

    Private Function Partition(ByVal InputArray As Integer(),
                               ByVal Lo As Integer,
                               ByVal Hi As Integer,
                               ByVal Pivot As Integer) As Integer

        Dim _Pivot As Integer = InputArray(Pivot)

        Helpers.Swap(InputArray, Pivot, Hi)

        Dim _Index As Integer = Lo

        For i As Integer = Lo To Hi

            If InputArray(i) < _Pivot Then

                Helpers.Swap(InputArray, _Index, i)
                _Index += 1

            End If

        Next

        Helpers.Swap(InputArray, _Index, Hi)

        Return _Index

    End Function
#End Region

End Class
