using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric hg = new HaloGeneric();
        hg.SapaUser("Bintang");
    }
}