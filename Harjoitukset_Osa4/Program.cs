using Harjoitukset_Osa4;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {            

            // Creating new instance
            Dog myDog = new("Musti", 12, 100);

            // Testing printing of myDog name
            Console.WriteLine(myDog.Name);

            // Variable to calculate energy using CalculateEnergy in EnergyCalcular class
            int energy = EnergyCalculator.CalculateEnergy(100);

            // Testing printing for energyAmount
            Console.WriteLine(energy + " kcal");

            // Calling Dog class method Eat() and passing variable energy
            myDog.Eat(energy);
            myDog.Eat(energy);

            // Testing access to Dog Class energyAmount
            int myDogEnergy = myDog.EnergyAmount;
            Console.WriteLine(myDogEnergy + " kcal");

            // Creating new instance from Mammal class
            Mammal myMammal = new Mammal("Jorma", 10);

            // Creating new Piano instanse from MusicInstrument Class
            Piano myPiano = new(3, 50, "Black", "Steinway", (float)(5.0));

            // Testing Piano Play()
            string output = myPiano.Play();
            Console.WriteLine(output);

            // Testing AcusticGuitar color
            AcusticGuitar yamaha = new AcusticGuitar(true, 6, "Blue", "Yamaha", 6, "Opera");
            Console.WriteLine(yamaha.Color());

            // Testing AcusticGuitar soundBox value
            Console.WriteLine(yamaha.SoundBox);
        }
    }
}