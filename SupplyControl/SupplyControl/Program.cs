// See https://aka.ms/new-console-template for more information
using SupplyControl.interfaces;
using SupplyControl.model;

Console.WriteLine("Hello, World!");

ISupply glue = new Glue("001");
ISupply solderPaste = new SolderPaste("005");

Console.WriteLine(glue.GetCode());
Console.WriteLine(solderPaste.GetCode());
