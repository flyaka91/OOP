namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine FirstMachine = new VendingMachine("CoffeeRus", 2000, 2000, 5000, 2000);
            
            int chosedCoffe = FirstMachine.ChooseDrink();
            int price = FirstMachine.CostCalculation(chosedCoffe);
            bool moneyEnought = FirstMachine.EnterPrice(price);
            FirstMachine.PreparingDrink(chosedCoffe, moneyEnought);
            

            //VendingMachine Cofee = new VendingMachine();
            //Cofee.Name = "Americano";

            //VendingMachine CofeeCocoaTea = new VendingMachine();
            //CofeeCocoaTea.Name = "Latte";

            //VendingMachine Soda = new VendingMachine();
            //Soda.Name = "Coca";

            //VendingMachine Juice = new VendingMachine();
            //Juice.Name = "Orange";
        }
    }
}
