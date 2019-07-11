Option Strict On
Public Class CarInventory


    Private Shared carCount As Integer                 ' static or shared private variable to hold the number of customers
    Private carIdentificationNumber As Integer = 0     ' private variable to hold the customer's identification number
    Private carMake As String = String.Empty         ' private variable to hold the customer's title
    Private carModel As String = String.Empty     ' private variable to hold the customer's first name
    Private carPrice As String = String.Empty      ' private variable to hold the customer's last name
    Private carNew As Boolean = False              ' private variable to hold the customer's status
    Private carYear As String = String.Empty

    ''' <summary>
    ''' Constructor - Default - creates a new customer object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount ' assign the customers id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new customer object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="price"></param>
    ''' <param name="neww"></param>
    ''' <param name="year"></param>
    Public Sub New(make As String, model As String, year As String, price As String, neww As Boolean)

        ' call the other constructor 
        ' to set the customer count and
        ' to set the customer id
        Me.New()


        carMake = make          ' set the customer title
        carModel = model  ' set the customer first name
        carPrice = price    ' set the customer last name
        carNew = neww        ' set the customer status
        carYear = year

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of customers that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific customers identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a customer
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property CarNewStatus() As Boolean
        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets car year
    ''' </summary>
    ''' <returns>string</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' Title property - Gets and Sets the title of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "It worked! " & carMake & " Model: " & carModel & " Price: " & carPrice & ", " & IIf(carNew = True, "New", "Used").ToString()

    End Function


End Class
