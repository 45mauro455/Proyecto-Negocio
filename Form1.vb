Public Class Form1
    Private Sub Tabla_ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tabla_ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabla_ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDatosNegocioDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OasisdbDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.OasisdbDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'BaseDatosNegocioDataSet.tabla_Productos' Puede moverla o quitarla según sea necesario.
        Me.Tabla_ProductosTableAdapter.Fill(Me.BaseDatosNegocioDataSet.tabla_Productos)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
