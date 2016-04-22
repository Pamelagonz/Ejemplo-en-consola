using System;
using System.Collections.Generic;

interface IImprimible
{
 void Imprime();
 void Imprime(int n);
}


class Usuario:IComparable, IImprimible
{
    public string nombre, correo;

    public Usuario(string n, string c)
    {
        this.nombre = n;
        this.correo = c;
    }
    public override string ToString()
    {
        return String.Format("{0} : {1}", this.nombre, this.correo);
    }
    public int CompareTo(object o)
    {
        Usuario usr = (Usuario)o;
        return this.nombre.CompareTo( usr.nombre );
    }

    public void Imprime()
    {
        throw new NotImplementedException();
    }

    public void Imprime(int n)
    {
        throw new NotImplementedException();
    }
}

    class Program
    {
        static private List<Usuario> usuarios=new List<Usuario>();
        static void Main(string[] args)
        {
            //Se agregan usuarios a la lista
            usuarios.Add(new Usuario("ana","ana@gmail.com"));//Los objetos se crean con new
            usuarios.Add(new Usuario("ale","ale@gmail.com"));//Usuario es el conductor
            usuarios.Add(new Usuario("zoe","zoe@gmail.com"));
            usuarios.Add(new Usuario("tom","tom@gmail.com"));
            usuarios.Add(new Usuario("liz","liz@gmail.com"));
            
            Console.WriteLine("Desordenados");
            //foreach recorre la lista
            //y en cada iteración copia el objeto que corresponde en u
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }
            //Ordena lista
            //Sort requiere que usuario implemente la interfaz comparable IComparable
            usuarios.Sort();
            Console.WriteLine("Ordenados");

            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine(usuarios[0].nombre);
            Console.ReadKey();
        }
    }

