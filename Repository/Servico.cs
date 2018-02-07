using System;

public class Servico : IServico
{
    public string URI { get; set; }

    public Servico(string URI)
    {
        this.URI = URI;
    }

    public string buscarURI () {

        return URI;    
    }
}