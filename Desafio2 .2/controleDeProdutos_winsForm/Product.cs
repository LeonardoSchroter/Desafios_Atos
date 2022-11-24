using System;
using System.Collections.Generic;

namespace controleDeProdutos_winsForm;

public partial class Product
{
    public int IdProdutos { get; set; }

    public double Preco { get; set; }

    public string Tipo { get; set; } = null!;

    public int FkIdFornecedor { get; set; }

    public string? Nome { get; set; }

    public virtual Provider FkIdFornecedorNavigation { get; set; } = null!;

    public virtual ICollection<Notum> Nota { get; } = new List<Notum>();
}
