using System;
using System.Collections.Generic;

namespace controleDeProdutos_winsForm;

public partial class Notum
{
    public int IdNota { get; set; }

    public int FkIdClientes { get; set; }

    public int FkIdProdutos { get; set; }

    public int Quantidade { get; set; }

    public double Valor { get; set; }

    public double Codigo { get; set; }

    public virtual Client FkIdClientesNavigation { get; set; } = null!;

    public virtual Product FkIdProdutosNavigation { get; set; } = null!;
}
