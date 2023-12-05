//Khaled Dafi
//12/5/2023
//INTERFACE: contract that all classes inherting form shuld Follow:

// Interface: what class shuold have?
// Inheriting: how the class should do it?

class Test
{
    static void Main(string[] args)
    {

        Khaled khaled = new Khaled();
        Mesheal mesheal = new Mesheal();
        Naif naif = new Naif();
        naif.Better();
        khaled.LEGEND();
        mesheal.Better();


        Console.WriteLine("Hi");
    }

    // now to create an interface:

    interface Ibest
    {
        void LEGEND();
    }

    interface Ibetter
    {
        void Better();
    }

    class Khaled : Ibest 
    {
        public void LEGEND()
        {
            Console.WriteLine("IM THE BEST HAHAHA ");
        }
    }

    class Mesheal : Ibetter
    {
        public void Better()
        {
            Console.WriteLine("I will be better ");
        }
    }
    class Naif: Ibetter
    {
        public void Better() 
        {
            Console.WriteLine("I'm trying to be better");
        }
    }

