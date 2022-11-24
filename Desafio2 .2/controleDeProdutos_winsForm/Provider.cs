using System;
using System.Collections.Generic;

namespace controleDeProdutos_winsForm;

public partial class Provider
{
    public int IdFornecedor { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
