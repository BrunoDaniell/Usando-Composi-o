namespace FixacaoComp.Entities;
using System;


internal class ClientBase
{

    public string Name { get; set; }

    public string Email { get; set; }

    public DateTime BirthDate { get; set; }


    public ClientBase()
    {

    }

    public ClientBase(string name, string email, DateTime birthDate)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }

    public override string ToString()
    {
        return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
    }

}
