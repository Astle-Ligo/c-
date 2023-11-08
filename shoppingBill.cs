using System;
class shoppingBill
{
    static void Main(String[] args)
    {
        int billNo = 1, i, k = 0, c, total = 0;
        string clerk;
        string[] items = new string[] { "Rice", "Wheat", "Bread", "Egg" };
        int[] price = new int[] { 60, 50, 50, 6 };
        int[] quantity = new int[items.Length];
        int[] cart = new int[items.Length];

        Console.WriteLine("Enter Clerk's Name : ");
        clerk = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("\tMENU");
            Console.WriteLine("--------------------");

            Console.WriteLine("1. Add Item\n2. View Cart\n3. Commute Bill\n4. Exit");
            Console.WriteLine("Enter Your Choice : ");
            c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine("Sl.NO\tITEM\tPRICE");

                    for (i = 0; i < items.Length; i++)
                        Console.WriteLine("{0}\t{1}\t{2}", i, items[i], price[i]);

                    Console.WriteLine("Enter Sl.no for selecting the Product.");
                    cart[k] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity of  the Product.");
                    quantity[k] = int.Parse(Console.ReadLine());
                    Console.WriteLine("You have Added {0} {1}", quantity[k], items[cart[k]]);
                    k++;
                    break;

                case 2:
                    Console.WriteLine("\tCART");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Sl.NO\tITEM\tPRICE\tQUANTITY");
                    for (i = 0; i < k; i++)
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", i, items[cart[i]], price[cart[i]], quantity[i]);
                    break;

                case 3:
                    Console.WriteLine("\tBILL");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Bill Number : {0}", billNo);
                    Console.WriteLine("Sl.NO\t ITEM\t PRICE\t QUANTITY\t TOTAL");
                    for (i = 0; i < k; i++)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, items[cart[i]], price[cart[i]], quantity[i], (price[cart[i]] * quantity[i]));
                        total += (price[cart[i]] * quantity[i]);
                    }
                    Console.WriteLine("Total Amount : {0}", total);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Choice.");
                    break;
            }
        }
    }
}