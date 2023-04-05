using System;

namespace _5._03._2023
{
    public class Program
    {
        static void Main(string[] args)
        { Player player= new Player();
            player.Name = "Test";
            PlayerController playerController = new PlayerController();
            PlayerController.EquipWeapon(new )
        }
    }

    ////Task:1
    //interface IVehicle
    //{
    //    void Start();
    //    void Stop();
    //}
    //class Car : IVehicle
    //{
    //    public void Start()
    //    {

    //    }

    //    public void Stop()
    //    {

    //    }
    //}
    //class Motorcycle: IVehicle
    //{
    //    public void Start()
    //    {

    //    }
    //    public void Stop()
    //    {

    //    }
    //}

    ////Task:2
    //interface IPrintable
    //{
    //    void Print();
    //}
    //class Document:IPrintable
    //{ 
    //    public void Print()
    //    {

    //    } 
    //}
    //class Photo:IPrintable
    //{
    //    public void Print()
    //    {

    //    }
    //}

    //class Video:IPrintable
    //{
    //    public void Print()
    //    {

    //    }
    //}

    //Task:3
    //interface IComparable
    //{
    //    void CompareTo();
    //}
    //class Person : IComparable
    //{
    //    public string Name;
    //    public int Age;
    //    public void CompareTo( int AgePerson)
    //    {
    //        if(AgePerson>Age)
    //        {
    //            Console.WriteLine("birinci sexsin yasi boyukdur");
    //        }
    //        else if(AgePerson==Age)
    //        {
    //            Console.WriteLine("Yasiddirlar");
    //        }
    //        else {
    //            Console.WriteLine("Ikinci sexsin yasi boyukdur");
    //                }

    //    }
    //}

    //Task:4
    //class PowerUp
    //{
    //    public virtual void Activite()
    //    {

    //    }

    //}

    //class HealthPowerUp : PowerUp
    //{
    //    public override void Activite()
    //    {
    //        Console.WriteLine("Can artdi");
    //    }
    //}

    //class SpeedPowerUp : PowerUp
    //{
    //    public override void Activite()
    //    {
    //        Console.WriteLine("Suret atdi");
    //    }
    //}

    //Task:5
     class Player
    { public string Name { get; set; }
        public void Attackt()
        {

        }
    }
    class PlayerController
    {
        private weapon _weapon;
        private Player _player; 
        public PlayerController(Player player)
        {
            _player= player;
        }
        public void EquipWeapon(Weapon weapon)
        {
            _weapon= weapon;
        }
        public void Attackt()
        {
            if(_weapon)
        }
    }


}
