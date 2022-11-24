using System;
using System.Collections.Generic;

namespace controleDeProdutos_winsForm;

public partial class Client
{
    public int IdClientes { get; set; }

    public string Cpf { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public virtual ICollection<Notum> Nota { get; } = new List<Notum>();
}
