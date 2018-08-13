Class Computer
        Private Code As String
        Private Width As Decimal
        Private Height As Decimal
        Private Weight As Decimal
        Private Make As String
        Private Processor As String
        Private RAM_Size As String
        Private Storage_Size As String
    End Class
    Class Mobile_Phone
        Inherits Computer
        Private Camera As Boolean
        Private G3 As Boolean
        Private G4 As Boolean
        Private Network As String
    End Class
    Class Laptop
        Inherits Computer
        Private Touch_Screen As Boolean
        Private Temovable_Screen As Boolean
        Private Tablet_Mode As Boolean
        Private USB_Ports As Integer
    End Class
