using System;
using System.Collections.Generic;

namespace FirstApp.DataBase;

public partial class Wordsdictionary
{
    public int WordDictionaryId { get; set; }

    public int? DictionaryId { get; set; }

    public int? WordId { get; set; }

    public int? Progres { get; set; }

    public virtual Dictionary? Dictionary { get; set; }

    public virtual Word? Word { get; set; }
}
