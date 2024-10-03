using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
//teste Nokia
Smartphone nokia = new Nokia("99999-9999","Tijolao", "1111111", 32);
Console.Write("Status do teste de ligação do Nokia: ");
nokia.Ligar();
Console.Write("Status do teste de recebimento de ligação do Nokia: ");
nokia.ReceberLigacao();
Console.Write("Status do teste de instalação de app no Nokia: ");
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

//teste iPhone
Smartphone iPhone = new Iphone("88888-8888","iPhone15", "222222", 128);
Console.Write("Status do teste de ligação do iPhone: ");
iPhone.Ligar();
Console.Write("Status do teste de recebimento de ligação do iPhone: ");
iPhone.ReceberLigacao();
Console.Write("Status do teste de instalação de app no iPhone: ");
iPhone.InstalarAplicativo("Facebook");