class Person
{
    public String firstName;
    public String lastName;
    public Person(string firstName, string lastName)
    {
        
        this.firstName = firstName;
        this.lastName= lastName;
    }
    public String GetFullName() {
        return firstName + " " + lastName;
    }
}