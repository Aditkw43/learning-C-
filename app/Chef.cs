using System;
namespace app
{
    public class Chef
    {
        public void MakeChicken(){
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad(){
            Console.WriteLine("The Chef make salad");
        }

// Virtual untuk menunjukkan bahwa kelas tersebut dapat di override ke kelas turunannya
        public virtual void MakeSpecialDish(){
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}