using System;
using System.Collections.Generic;

namespace BuckEnd.Model;

public partial class Sdelka
{
    public int Sdelkaid { get; set; }

    public int Count { get; set; }

    public DateOnly Date { get; set; }

    public int Productid { get; set; }

    public int Clientid { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
