''' <summary>
''' Application Session Management - Replace global variables in module
''' </summary>
Public Class AppSession

    ' Singleton instance
    Private Shared _instance As AppSession
    Private Shared ReadOnly _lock As New Object()

    ' Session properties
    Public Property IsLoggedIn As Boolean = False
    Public Property UserID As String = ""
    Public Property Username As String = ""
    Public Property UserLevel As String = ""
    Public Property KodeProdi As String = ""
    Public Property NamaProdi As String = ""

    ' Private constructor (Singleton pattern)
    Private Sub New()
    End Sub

    ''' <summary>
    ''' Get singleton instance
    ''' </summary>
    Public Shared ReadOnly Property Instance As AppSession
        Get
            If _instance Is Nothing Then
                SyncLock _lock
                    If _instance Is Nothing Then
                        _instance = New AppSession()
                    End If
                End SyncLock
            End If
            Return _instance
        End Get
    End Property

    ''' <summary>
    ''' Set user session after login
    ''' </summary>
    Public Sub SetUserSession(userID As String, username As String, level As String, Optional kodeProdi As String = "", Optional namaProdi As String = "")
        Me.IsLoggedIn = True
        Me.UserID = userID
        Me.Username = username
        Me.UserLevel = level
        Me.KodeProdi = kodeProdi
        Me.NamaProdi = namaProdi
    End Sub

    ''' <summary>
    ''' Clear session (logout)
    ''' </summary>
    Public Sub ClearSession()
        Me.IsLoggedIn = False
        Me.UserID = ""
        Me.Username = ""
        Me.UserLevel = ""
        Me.KodeProdi = ""
        Me.NamaProdi = ""
    End Sub

    ''' <summary>
    ''' Check if user has admin privileges
    ''' </summary>
    Public Function IsAdmin() As Boolean
        Return Me.UserLevel.ToUpper() = "ADMINISTRATOR"
    End Function

End Class
