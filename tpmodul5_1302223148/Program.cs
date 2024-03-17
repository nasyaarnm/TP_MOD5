// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;


public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}
public class Program
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Nasya");
    }
}
