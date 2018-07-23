using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Buscar
{
    String name;
    int money;
    DateTime startdate;
    DateTime enddate;
    String memo;

    public Buscar(string name, int money, DateTime startdate, DateTime enddate, string memo)
    {
        this.name = name;
        this.money = money;
        this.startdate = startdate;
        this.enddate = enddate;
        this.memo = memo;
    }

    public string Name { get => name; set => name = value; }
    public int Money { get => money; set => money = value; }
    public DateTime Startdate { get => startdate; set => startdate = value; }
    public DateTime Enddate { get => enddate; set => enddate = value; }
    public string Memo { get => memo; set => memo = value; }
}