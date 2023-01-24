using System;
using System.Collections.Generic;

namespace FirstApp.DataBase;

public partial class Word
{
    public int WordId { get; set; }

    public string Word1 { get; set; }

    public string Translate { get; set; }

    public string Transcript { get; set; }

    public virtual ICollection<Wordsdictionary> Wordsdictionaries { get; } = new List<Wordsdictionary>();
}
