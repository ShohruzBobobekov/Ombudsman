namespace Ombudsman.Core.Models;

public class Employee : Auditable
{
    public int OrganizationId { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public string PhoneNumber { get; set; }
}
