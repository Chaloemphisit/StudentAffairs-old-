Imports System.ComponentModel
Public Class frmLoadData
    Private Sub cancelAsyncButton_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles btnCancle.Click
        If frmStdList.bgwRetrieveData.WorkerSupportsCancellation = True Then
            ' Cancel the asynchronous operation.
            frmStdList.bgwRetrieveData.CancelAsync()
            System.Threading.Thread.Sleep(500)
            End
        End If

    End Sub

    Private Sub frmLoadData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmStdList.bgwRetrieveData.IsBusy <> True Then
            ' Start the asynchronous operation.
            frmStdList.bgwRetrieveData.RunWorkerAsync()
        End If
    End Sub
End Class