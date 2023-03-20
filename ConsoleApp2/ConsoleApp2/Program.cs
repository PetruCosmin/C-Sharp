using ConsoleApp2;
using entitati;

ProdusMgr prMgr=new ProdusMgr();
ServiciiMgr servMgr=new ServiciiMgr();
Console.Write("Nr. produse:");
uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Nr.servicii:");
uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);

prMgr.ReadProd();
servMgr.ReadServ();

prMgr.ReadProduse(nrProduse);
servMgr.ReadServicii(nrServicii);
prMgr.WriteProduse();
servMgr.WriteServicii();

