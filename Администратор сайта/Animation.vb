Public Class Animation
    Private img As Image
    Private pnt As Point
    Public isanimating As Boolean

    Public Sub New(ByVal filename As String)
        img = New Bitmap(filename)
        isanimating = False
        pnt = New Point(50, 30)
    End Sub

    Public Sub Draw(ByVal e As PaintEventArgs)
        e.Graphics.DrawImage(img, pnt)
    End Sub

    Public Sub AnimateImage(ByVal handler As EventHandler)
        If Not isanimating And ImageAnimator.CanAnimate(img) Then
            ImageAnimator.Animate(img, handler)
            isanimating = True
        End If
    End Sub
    Public Sub StopAnimation(ByVal handler As EventHandler)
        If isanimating Then
            ImageAnimator.StopAnimate(img, handler)
            isanimating = False
        End If
    End Sub

End Class
