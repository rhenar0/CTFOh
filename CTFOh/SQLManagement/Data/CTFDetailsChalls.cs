namespace CTFOh.SQLManagement.Data;

public class CTFDetailsChalls
{
    public int Id { get; set; }
    public long Points { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public string Img { get; set; }
    public string Files { get; set; }
    public string Links { get; set; }
    public int Actif { get; set; }
    public int LinkedCTF { get; set; }
}