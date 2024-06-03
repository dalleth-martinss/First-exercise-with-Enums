using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;


namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // conversão de enumerado p/ string
            Console.WriteLine(txt);

            //OrderStatus os = Enum.Parse(OrderStatus ("Delivered"));
            // Console.WriteLine(os); // coloquei essa linha aqui para que o CMD não fechasse rapidamente


            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);

            Console.ReadLine();
        }
    }
}
