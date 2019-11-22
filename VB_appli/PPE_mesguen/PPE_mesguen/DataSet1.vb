

Partial Public Class DataSet1
    Partial Class VEHICULEDataTable

        Private Sub VEHICULEDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.VEHIMMATColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class

End Class
