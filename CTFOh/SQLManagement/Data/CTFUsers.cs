namespace CTFOh.SQLManagement.Data;

public class CTFUsers
{
    public int Id { get; set; }
    public string Pseudo { get; set; }
    public string ChkPassword { get; set; }
    public int Team { get; set; }
    public long Score { get; set; }
    public string AssignedChalls { get; set; }
    public int LinkedCTF { get; set; }
}