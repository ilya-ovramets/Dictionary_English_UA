using System;
using System.Collections.Generic;

namespace FirstApp.DataBase;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public int? DictionaryId { get; set; }

    public virtual Dictionary? Dictionary { get; set; }
}
