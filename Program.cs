using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Persona cliente = new Persona("julian Correa", 44129435, "calle Falsa 1234", "juliancorrea14@gmail.com", true);

Console.WriteLine(cliente.nombreCompleto);
Console.WriteLine(cliente.telefono);
Console.WriteLine(cliente.direccion);
Console.WriteLine(cliente.email);
Console.WriteLine(cliente.siEsNuevo);


public struct Persona
{
    public Persona(string nombreCompleto, int telefono, string direccion, string email, Boolean siEsNuevo)

    {

        this.nombreCompleto = nombreCompleto;

        this.telefono = telefono;

        this.direccion = direccion;

        this.email = email;

        this.siEsNuevo = siEsNuevo;

    }

    public string nombreCompleto { get; set; }

    public int telefono { get; set; }

    public string direccion{ get; set; }

    public string email { get; set; }

    public bool siEsNuevo {get;set; }


}