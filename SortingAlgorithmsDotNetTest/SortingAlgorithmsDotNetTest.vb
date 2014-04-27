Imports SortingAlgorithmsDotNet

<TestClass()>
Public Class SortingAlgorithmsDotNetTest

    'You can view the output of "Console.Write" by double-clicking on "Result" in the "Test Results" window.

#Region "Members"
    Private _EvenTestArray As Integer() = New Integer() {45, 0, 1, 78, -50, 2, 8, 3, 3, 0, 4, -10, 87, 100, 39, 4, 1, 7, 5, 2, 10, 12}
    Private _OddTestArray As Integer() = New Integer() {45, 0, 1, 78, -50, 2, 8, 3, 3, 0, 4, -10, 87, 100, 39, 4, 1, 7, 5, 2, 10, 12, 17}
#End Region

#Region "Methods"
    <TestMethod()>
    Public Sub BubbleSortTest()

        Dim _BubbleSort As New BubbleSort

        _BubbleSort.BubbleSort(_EvenTestArray)
        PrintArray("Bubble Sort - sorted even array: ",
                   _EvenTestArray)

        _BubbleSort.BubbleSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Bubble sort - sorted odd array: "),
                   _OddTestArray)

    End Sub

    <TestMethod()>
    Public Sub CountingSortTest()

        'My implementation of Counting Sort does not handle negative numbers; so the arguments must be non-negative integers.

        Dim _EvenArray As Integer() = New Integer() {45, 0, 1, 78, 8, 3, 3, 0, 4, 87, 100, 39, 4, 1, 7, 5, 2, 10, 12}
        Dim _OddArray As Integer() = New Integer() {45, 0, 1, 78, 2, 8, 3, 3, 0, 4, 87, 100, 39, 4, 1, 7, 5, 2, 10, 12, 17}

        Dim _CountingSort As New CountingSort
        Dim _OutputEvenArray As Integer()
        Dim _OutputOddArray As Integer()

        _OutputEvenArray = _CountingSort.CountingSort(_EvenArray)
        PrintArray("Counting Sort - sorted even array: ",
                   _OutputEvenArray)

        _OutputOddArray = _CountingSort.CountingSort(_OddArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Counting sort - sorted odd array: "),
                   _OutputOddArray)

    End Sub

    <TestMethod()>
    Public Sub HeapSortTest()

        Dim _HeapSort As New HeapSort

        _HeapSort.HeapSort(_EvenTestArray)
        PrintArray("Heap Sort - sorted even array: ",
                   _EvenTestArray)

        _HeapSort.HeapSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Heap sort - sorted odd array: "),
                   _OddTestArray)

    End Sub

    <TestMethod()>
    Public Sub InsertionSortTest()

        Dim _InsertionSort As New InsertionSort

        _InsertionSort.InsertionSort(_EvenTestArray)
        PrintArray("Insertion Sort - sorted even array: ",
                   _EvenTestArray)

        _InsertionSort.InsertionSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Insertion sort - sorted odd array: "),
                   _OddTestArray)

    End Sub

    <TestMethod()>
    Public Sub MergeSortTest()

        Dim _MergeSort As New MergeSort
        Dim _OutputEvenTestArray As Integer()
        Dim _OutputOddTestArray As Integer()

        _OutputEvenTestArray = _MergeSort.MergeSort(_EvenTestArray)
        PrintArray("Merge Sort - sorted even array: ",
                   _OutputEvenTestArray)

        _OutputOddTestArray = _MergeSort.MergeSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Merge sort - sorted odd array: "),
                   _OutputOddTestArray)

    End Sub

    <TestMethod()>
    Public Sub QuickSortTest()

        Dim _QuickSort As New QuickSort

        _QuickSort.QuickSort(_EvenTestArray)
        PrintArray("Quick Sort - sorted even array: ",
                   _EvenTestArray)

        _QuickSort.QuickSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Quick sort - sorted odd array: "),
                   _OddTestArray)

    End Sub

    <TestMethod()>
    Public Sub SelectionSortTest()

        Dim _SelectionSort As New SelectionSort

        _SelectionSort.SelectionSort(_EvenTestArray)
        PrintArray("Selection Sort - sorted even array: ",
                   _EvenTestArray)

        _SelectionSort.SelectionSort(_OddTestArray)
        PrintArray(String.Format("{0}{1}", vbCrLf, "Selection sort - sorted odd array: "),
                   _OddTestArray)

    End Sub

    Public Sub PrintArray(ByVal Message As String,
                          ByVal InputArray As Integer())

        Console.Write(String.Format("{0} ", Message))

        For i As Integer = 0 To InputArray.Length - 1

            Console.Write(String.Format("{0} {1}", InputArray(i).ToString(), " "))

        Next

    End Sub

#End Region

End Class
