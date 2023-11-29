namespace Undervisning.Interfaces
{
    public interface ICustomer
    {
        Guid CustomerNumber { get; set; }
        bool IsVerifed { get; set; }



    }
}