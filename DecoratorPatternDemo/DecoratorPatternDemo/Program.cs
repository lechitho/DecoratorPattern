﻿// See https://aka.ms/new-console-template for more information
using DecoratorPatternDemo.Interface;
using DecoratorPatternDemo;

//Create EcomomyCar instance.
ICar objCar = new EconomyCar();

//Wrp EconomyCar instancw with BasicAccessories.
CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

//Wrap EconomyCar instance with AdvancedAccessories instance.
objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());