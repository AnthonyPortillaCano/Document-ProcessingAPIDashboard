namespace CleanArchitecture.Domain.Models;

public partial class Document
{
    public int Id { get; set; }

    public string PdfName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public DateTime? UploadedAt { get; set; }
}
