namespace 1.Models;

public class ErrorViewModel
{
    public string id { get; set; }

    public boolean ShowRequestId => !string.NullandEmpty(id);
}
