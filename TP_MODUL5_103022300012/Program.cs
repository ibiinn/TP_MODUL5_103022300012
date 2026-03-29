using System;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric hg = new HaloGeneric();
        hg.SapaUser("Bintang"); // ganti nama kamu

        DataGeneric<string> data = new DataGeneric<string>("103022300012"); // ganti NIM
        data.PrintData();
    }
}