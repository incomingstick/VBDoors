Public Class Player
    'Damage Percent Modifier
    Private strengthInt As Integer
    Public Property Strength As Integer
        Get
            Return strengthInt
        End Get
        Set(value As Integer)
            strengthInt = value
        End Set
    End Property
    'Health Modifier
    Private staminaInt As Integer
    Public Property Stamina As Integer
        Get
            Return staminaInt
        End Get
        Set(value As Integer)
            staminaInt = value
        End Set
    End Property
    'Defence Modifier
    Private dexterityInt As Integer
    Public Property Dexterity As Integer
        Get
            Return dexterityInt
        End Get
        Set(value As Integer)
            dexterityInt = value
        End Set
    End Property
    Private levelInt As Integer
    Public Property Level As Integer
        Get
            Return levelInt
        End Get
        Set(value As Integer)
            levelInt = value
        End Set
    End Property
    Private experience As Integer
    Public Property EXP As Integer
        Get
            Return experience
        End Get
        Set(value As Integer)
            experience = value
        End Set
    End Property
    Private baseHealth As Integer
    Private baseDamage As Integer
    Private baseDodge As Integer


    Private levelUp As StatScreen

    'Constructor
    Public Sub New()
        levelUp = New StatScreen()
        Strength = 1
        Stamina = 1
        Dexterity = 1
        baseHealth = 100
        baseDamage = 5
        baseDodge = 10
    End Sub

    Public Sub Inititalize()
        levelUp.Show()
    End Sub
End Class
