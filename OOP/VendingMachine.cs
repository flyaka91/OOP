namespace OOP
{
    public class VendingMachine
    {
        public string Name { get; private set; }

        public int CofeeConcentrate { get; set; }

        public int Milk { get; set; }

        public int Water { get; set; }

        public int Sugar { get; set; }

        public VendingMachine(string name, int cofeeConcentrate, int milk,
            int water, int sugar)
        {
            Name = name;
            CofeeConcentrate = cofeeConcentrate;
            Milk = milk;
            Water = water;
            Sugar = sugar;
        }

        public int ChooseDrink()
        {
            int name = -1;

            Console.WriteLine("Выберите напиток? 1 - Americano/ 2 - Latte/ 3 - Cappucino");
            name = Convert.ToInt32(Console.ReadLine());
            if (name > 3 || name < 1)
            {
                Console.WriteLine("Несуществующий вариант");
                return -1;
            }
            return name;
        }

        public int CostCalculation(int price)
        {
            price *= 100;
            Console.WriteLine($"С Вас {price} денег,внесите оплату");
            return price;
        }

        public bool EnterPrice(int price)
        {
            bool isEnough = false;
            int moneyReceived = Convert.ToInt32(Console.ReadLine());

            if (moneyReceived == price)
            {
                isEnough = true;
            }
            return isEnough;
        }


        public void PreparingDrink(int name, bool enoughtMoney)
        {
            if (enoughtMoney)
            {

                if (name == 1)
                {
                    CofeeConcentrate -= 100;
                    Water -= 100;
                    Sugar -= 100;
                }
                else if (name == 2)
                {
                    CofeeConcentrate -= 100;
                    Water -= 100;
                    Milk -= 100;
                    Sugar -= 100;
                }
                else if (name == 3)
                {
                    CofeeConcentrate -= 100;
                    Water -= 100;
                    Milk -= 200;
                    Sugar -= 100;
                }
                Console.WriteLine($"Ваш напиток {name} готов");
            }

        }
    }
}
