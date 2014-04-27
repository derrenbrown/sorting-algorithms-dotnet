Public Class MergeSort

#Region "Methods"
    Public Function MergeSort(ByVal InputArray As Integer())

        Return MergeSort(InputArray, 0, InputArray.Length - 1)

    End Function

    Private Function MergeSort(ByVal InputArray As Integer(),
                               ByVal Lo As Integer,
                               ByVal Hi As Integer) As Integer()

        If InputArray.Length <= 1 Then

            Return InputArray

        End If

        Dim _Mid = (Hi + Lo) / 2

        Dim _Left As Integer() = MergeSort(InputArray.Take(InputArray.Length / 2).ToArray(), Lo, _Mid)
        Dim _Right As Integer() = MergeSort(InputArray.Skip(InputArray.Length / 2).ToArray(), _Mid + 1, Hi)

        Return Merge(_Left, _Right)

    End Function

    Private Function Merge(ByVal Left As Integer(),
                           ByVal Right As Integer()) As Integer()

        Dim _OutputArray As Integer() = New Integer(Left.Length + Right.Length - 1) {}

        Dim i As Integer = Left.Length - 1
        Dim j As Integer = Right.Length - 1
        Dim k As Integer = _OutputArray.Length - 1

        While i >= 0 AndAlso j >= 0

            If Left(i) > Right(j) Then

                _OutputArray(k) = Left(i)
                i -= 1

            Else

                _OutputArray(k) = Right(j)
                j -= 1

            End If

            k -= 1

        End While

        While i >= 0

            _OutputArray(k) = Left(i)
            i -= 1
            k -= 1

        End While

        While j >= 0

            _OutputArray(k) = Right(j)
            j -= 1
            k -= 1

        End While

        Return _OutputArray

    End Function
#End Region

End Class
