using System;
using System.Collections.Generic;

namespace FirstApp.DataBase;

public partial class Dictionary
{
    public int DictionaryId { get; set; }

    public int WeakWords { get; set; } = 0;

    public int MiddleWords { get; set; } = 0;

    public int StrongWords { get; set; } = 0;

    public virtual ICollection<User> Users { get; } = new List<User>();

    public virtual ICollection<Wordsdictionary> Wordsdictionaries { get; } = new List<Wordsdictionary>();
}
