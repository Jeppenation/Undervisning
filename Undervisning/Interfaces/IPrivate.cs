namespace Undervisning.Interfaces
{
    internal interface IPrivate: ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}