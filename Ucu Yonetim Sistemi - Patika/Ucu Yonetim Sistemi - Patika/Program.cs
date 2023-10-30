public class HavaYolu
{
    public int Id { get; set; }
    public string Isim { get; set; }
    public List<Ucak> Ucaklar { get; set; }
    public List<Pilot> Pilotlar { get; set; }
    public List<Ucus> Ucuslar { get; set; }
}

public class Ucak
{
    public int Id { get; set; }
    public string Tip { get; set; }
    public bool CalisiyorMu { get; set; }
    public int GerekliPilotSayisi { get; set; }
}

public class Ucus
{
    public int Id { get; set; }
    public HavaAlani KalkisHavaAlani { get; set; }
    public HavaAlani InisHavaAlani { get; set; }
    public DateTime KalkisSaati { get; set; }
    public DateTime InisSaati { get; set; }
    public Pilot Pilot { get; set; }
    public Pilot YardimciPilot { get; set; }
    public Ucak Ucak { get; set; }
}

public class HavaAlani
{
    public int Id { get; set; }
    public string Isim { get; set; }
}

public class Pilot
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DeneyimSeviyesi { get; set; }
}
