namespace Undervisning.Interfaces
{
    internal interface ICompany: ICustomer
    {
        string CompanyName { get; set; }
        new bool IsVerifed { get; set; }
    }
}