using entitati;


Console.Write("Nr. produse:");
uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Nr.servicii:");
uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);
// array de produse
Produs[] produse = new Produs[nrProduse];
Servicii[] serviciis= new Servicii[nrServicii];
// citim produsele
for (int cnt = 0; cnt < nrProduse; cnt++)
{
    
    // instantierea unui Produs
    Console.WriteLine("Introdu un produs");
    Console.Write("ID:");
    string id = Console.ReadLine();


    Console.Write("Numele:");
    string Nume = Console.ReadLine();
    Console.Write("Codul intern:");
    string CodIntern = Console.ReadLine();
    Console.Write("Producator:");
    string Producator = Console.ReadLine();
    Produs prod = new Produs(0,Nume,CodIntern,Producator);
   
    produse[cnt] = prod;
}
for (int serv = 0; serv < nrProduse; serv++)
{

    // instantierea unui Produs
    Console.WriteLine("Introdu un serviciu:");
    Console.Write("Numele:");
    string Nume = Console.ReadLine();
    Console.Write("Codul intern:");
    string CodIntern = Console.ReadLine();
    Console.Write("Id:");
    string id = Console.ReadLine();
    Servicii servici = new Servicii(id,Nume,CodIntern);

    serviciis[serv] = servici;
}
// afisam produsele
Produs.Pro(produse,nrProduse);
Servicii.Servi(serviciis,nrServicii);
