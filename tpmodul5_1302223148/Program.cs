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


public class DataGeneric<T>
{
    public T Data { get; set; }
    public DataGeneric(T data) 
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang disimpan adalah: " + Data);
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Nasya");

        DataGeneric<string> dataString = new DataGeneric<string> ("1302223148");
        dataString.PrintData();
    }
}

