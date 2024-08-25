Class MainWindow
    Private Sub PrintPreviewButton_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim printdialog As New PrintDialog()
            If printdialog.ShowDialog() = True Then
                ' Tentukan ukuran kertas custom dalam inci
                'Dim widthInInches As Double = 8.5
                'Dim heightInInches As Double = 11

                ' Konversi ukuran kertas ke piksel (1 inci = 96 piksel)
                'Dim widthInPixels As Double = widthInInches * 96
                'Dim heightInPixels As Double = heightInInches * 96

                ' Atur ukuran kertas pada PrintTicket
                'printdialog.PrintTicket.PageMediaSize = New System.Printing.PageMediaSize(widthInPixels, heightInPixels)

                ' Cetak visual
                printdialog.PrintVisual(AreaPrint, "AreaPrint")
            End If
        Catch ex As Exception
            ' Tambahkan penanganan kesalahan di sini jika diperlukan
        End Try
    End Sub
End Class
