Public Class HeapSort

#Region "Properties"
    Private ReadOnly Property LeftIndex(ByVal Index As Integer) As Integer
        Get
            Return 2 * Index + 1
        End Get
    End Property

    Private ReadOnly Property RightIndex(ByVal Index As Integer) As Integer
        Get
            Return 2 * Index + 2
        End Get
    End Property
#End Region

#Region "Methods"
    Public Sub HeapSort(ByVal InputArray As Integer())

        Dim _Heap As Integer() = BuildHeap(InputArray)
        Dim _Size As Integer = InputArray.Length

        For i As Integer = _Size - 1 To 0 Step -1

            Helpers.Swap(InputArray, 0, i)
            Heapify(InputArray, 0, i)

        Next

    End Sub

    Private Sub Heapify(ByVal InputArray As Integer(),
                        ByVal Index As Integer,
                        ByVal Max As Integer)

        Dim _Left As Integer = LeftIndex(Index)
        Dim _Right As Integer = RightIndex(Index)

        Dim _Largest As Integer = 0

        If _Left < Max AndAlso InputArray(_Left) > InputArray(Index) Then

            _Largest = _Left

        Else

            _Largest = Index

        End If

        If _Right < Max AndAlso InputArray(_Right) > InputArray(_Largest) Then

            _Largest = _Right

        End If

        If _Largest <> Index Then

            Helpers.Swap(InputArray, Index, _Largest)
            Heapify(InputArray, _Largest, Max)

        End If

    End Sub

    Private Function BuildHeap(ByVal InputArray As Integer()) As Integer()

        Dim _HeapSize As Integer = InputArray.Length

        For i As Integer = (InputArray.Length / 2) - 1 To 0 Step -1

            Heapify(InputArray, i, _HeapSize)

        Next

        Return InputArray

    End Function
#End Region

End Class
