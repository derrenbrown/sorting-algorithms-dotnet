Public Class Helpers

#Region "Methods"
    Public Shared Sub Swap(ByVal Items As Integer(),
                           ByVal Left As Integer,
                           ByVal Right As Integer)

        If Left <> Right Then

            Dim _Temp As Integer = Items(Left)
            Items(Left) = Items(Right)
            Items(Right) = _Temp

        End If

    End Sub
#End Region

End Class


