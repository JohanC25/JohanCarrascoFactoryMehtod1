// See https://aka.ms/new-console-template for more information

using JohanCarrascoFactoryMehtod1;

Console.WriteLine("El primer auto es:");
Carros carro = Creador.CreadorCarro(Creador.MUSTANG);
Console.WriteLine(carro.QueCarroSoy());

Console.WriteLine("El segundo auto es:");
Carros carro1 = Creador.CreadorCarro(Creador.TESLA);
Console.WriteLine(carro1.QueCarroSoy());

Console.WriteLine("El tercer auto es:");
Carros carro2 = Creador.CreadorCarro(Creador.TOYOTA);
Console.WriteLine(carro2.QueCarroSoy());
