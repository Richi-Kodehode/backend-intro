class Person
{
    // Datafield
    public String firstName;
    public String lastName;

    // Constructor
    // logics to make a new instance
    public Person(string firstName, string lastName)
    {
        
        this.firstName = firstName;
        this.lastName= lastName;
    }
    // Methods
    //What we can do with this type
    public String GetFullName() {
        return firstName + " " + lastName;
    }
}