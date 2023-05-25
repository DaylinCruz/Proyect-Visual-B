Public Class Animal
    Interface IPetCharacteristics
        Function characteristics() As String
    End Interface

    Public Class Animal
        Public breed As String
        Public name As String
        Public age As String
        Public price As String

        Public Property _Breed As String
            Get
                Return breed
            End Get
            Set(ByVal value As String)
                breed = value
            End Set
        End Property

        Public Property _Name As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property

        Public Property _Age As String
            Get
                Return age
            End Get
            Set(ByVal value As String)
                age = value
            End Set
        End Property

        Public Property _Price As String
            Get
                Return price
            End Get
            Set(ByVal value As String)
                price = value
            End Set
        End Property

        Public Sub New()
            breed = String.Empty
            name = String.Empty
            age = String.Empty
            price = String.Empty
        End Sub

        Public Sub New(ByVal breed As String, ByVal name As String, ByVal age As String, ByVal price As String)
            Me.breed = breed
            Me.name = name
            Me.age = age
            Me.price = price
        End Sub
    End Class

    Public Class Dog
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I can bark!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Cat
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I can meow!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Bird
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I like to sing in the morning!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Reptil
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I enjoy nature!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Rodent
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I am small, take care of me!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class Fish
        Inherits Animal
        Implements IPetCharacteristics

        Public ReadOnly Property Hi As String
            Get
                Return characteristics()
            End Get
        End Property

        Public Function characteristics() As String
            Return "¡I can swim!"
        End Function

        Private Function IPetCharacteristics_characteristics() As String Implements IPetCharacteristics.characteristics
            Throw New NotImplementedException()
        End Function
    End Class
End Class
