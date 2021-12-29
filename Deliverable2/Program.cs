using System;

public class deliverable2
{
    static public void Main()
    {

        int partySize;
        int guestNumber = 1;
        string drink;
        int numWater = 0;
        int numPop = 0;
        double water = 0;
        double pop = 1.99;
        double buffet = 9.99;
        double bill;
        double buffetTotal;
        double waterTotal;
        double popTotal;


        Console.WriteLine("Hello, and welcome to our buffet. All you can eat for the low price of $9.99! Currently we have a max table size of 6 people. How many people are in your group? ");


        partySize = int.Parse(Console.ReadLine());

        if (partySize < 7)
        {
            Console.WriteLine();
            Console.WriteLine("A table for {0}! Please follow me to your table and take a seat. Please place your drink order now. We have water or pop available to drink.", partySize);
            Console.WriteLine();

            while (guestNumber <= partySize)
            {

                Console.WriteLine("Alright person number {0}, water or pop?", guestNumber);
                drink = Console.ReadLine();
                if (drink == "water")
                {
                    Console.WriteLine();
                    Console.WriteLine("Okay, I will put you down for water.");
                    Console.WriteLine();
                    numWater++;
                }
                else if (drink == "pop")
                {
                    Console.WriteLine(); Console.WriteLine("Pop! Sounds tasty.");
                    Console.WriteLine();
                    numPop++;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not carry that beverage. I guess you're staying thirsty!");
                    Console.WriteLine();
                }
                guestNumber++;
            }

            Console.Write("Okay, so thats {0}  waters and", numWater);
            Console.WriteLine(" {0} pops.I will be back soon. Enjoy your food!", numPop);
            Console.WriteLine();

            buffetTotal = partySize * buffet;
            popTotal = numPop * pop;
            waterTotal = numWater * water;

            bill = (pop * numPop) + (water * numWater) + (buffet * partySize);


            Console.WriteLine("The price of your bill is {0}", bill);
            Console.WriteLine();
            Console.Write("{0} Buffets = {0} x 9.99 = ", partySize);
            Console.WriteLine(buffetTotal);

            Console.Write("{0} pops = {0} x 1.99 = ", numPop);
            Console.WriteLine(popTotal);

            Console.WriteLine("{0} waters = free ", numWater);
            Console.WriteLine("Total = {0}", bill);


        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, our tables only fit up to 6 people. Have a nice day");
        }
    }

}
