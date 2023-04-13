namespace CTFOh.SQLManagement.Data;

public class CTFListChalls
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Actif { get; set; }
    public string Chall { get; set; }
    public string Order { get; set; }
    public int StrictOrder { get; set; }
    public int LinkedCTF { get; set; }
}