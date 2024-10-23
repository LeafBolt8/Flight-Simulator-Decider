Console.WriteLine("Click Enter to continue...");
Console.ReadLine();

Console.WriteLine("Welcone to the Flight Simulator Decider!");

Console.WriteLine("");
Console.WriteLine("This is a simple console program that helps you decide on what flight simulator to play based from your criteria");

Console.WriteLine("");
Console.WriteLine("Let us start! (Click Enter to continue...)");
Console.ReadLine();

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("What type of GENRE do you want to play?");
    Console.WriteLine("");
    Console.WriteLine("CLICK 1 then Enter = Commercial Aviation");
    Console.WriteLine("CLICK 2 then Enter = Military Aviation");
    int genre = Convert.ToInt32(Console.ReadLine());

    //commercial aviation!!!
    
    if (genre == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("Do you prefer REALISM on FLIGHT MODEL or SCENERY?");
        Console.WriteLine("");
        Console.WriteLine("CLICK 1 then Enter = Flight Model");
        Console.WriteLine("CLICK 2 then Enter = Scenery");

        int realism = Convert.ToInt32(Console.ReadLine());

        if (realism == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("Do you have a strong computer?");
            Console.WriteLine("");
            Console.WriteLine("CLICK 1 then Enter = Yes");
            Console.WriteLine("CLICK 2 then Enter = No");

            int strong = Convert.ToInt32(Console.ReadLine());
            if (strong == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Based from your chosen criteria: ");
                Console.WriteLine("- Commercial Aviation");
                Console.WriteLine("- Realism of Flight Models");
                Console.WriteLine("- Not having a strong computer");
                Console.WriteLine("The best flight simulator for you is:");
                Console.WriteLine("Lockheed Martin Prepar3d or Microsoft Flight Simulator X with a payware quality plane");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("CLICK 1 then Enter = Yes");
                Console.WriteLine("CLICK 2 then Enter = No");
                int tryagain1 = Convert.ToInt32(Console.ReadLine());
                if (tryagain1 == 1)
                {
                    continue;
                }
                else if (tryagain1 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong input!");
                }
            }
            else if (strong == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Based from your chosen criteria: ");
                Console.WriteLine("- Commercial Aviation");
                Console.WriteLine("- Realism of Flight Models");
                Console.WriteLine("- Has a strong computer");
                Console.WriteLine("The best flight simulator for you is:");
                Console.WriteLine("X-Plane 11 or X-Plane 12");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("CLICK 1 then Enter = Yes");
                Console.WriteLine("CLICK 2 then Enter = No");
                int tryagain2 = Convert.ToInt32(Console.ReadLine());
                if (tryagain2 == 1)
                {
                    continue;
                }
                else if (tryagain2 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong input!");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong input!");
            }
        }

        else if (realism == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("Do you have a strong computer?");
            Console.WriteLine("");
            Console.WriteLine("CLICK 1 then Enter = Yes");
            Console.WriteLine("CLICK 2 then Enter = No");

            int strong = Convert.ToInt32(Console.ReadLine());
            if (strong == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Based from your chosen criteria: ");
                Console.WriteLine("- Commercial Aviation");
                Console.WriteLine("- Realism of Scenery");
                Console.WriteLine("- Not having a strong computer");
                Console.WriteLine("The best flight simulator for you is:");
                Console.WriteLine("Nothing particularly, unless your computer can run Microsoft Flight Simulator 2020 at minimum range");
                

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("CLICK 1 then Enter = Yes");
                Console.WriteLine("CLICK 2 then Enter = No");
                int tryagain3 = Convert.ToInt32(Console.ReadLine());
                if (tryagain3 == 1)
                {
                    continue;
                }
                else if (tryagain3 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong input!");
                }
            }
            else if (strong == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Based from your chosen criteria: ");
                Console.WriteLine("- Commercial Aviation");
                Console.WriteLine("- Realism of Scenery");
                Console.WriteLine("- Has a strong computer");
                Console.WriteLine("The best flight simulator for you is:");
                Console.WriteLine("Microsoft Flight Simulator 2020 or Microsoft Flight Simulator 2024");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("CLICK 1 then Enter = Yes");
                Console.WriteLine("CLICK 2 then Enter = No");
                int tryagain3 = Convert.ToInt32(Console.ReadLine());
                if (tryagain3 == 1)
                {
                    continue;
                }
                else if (tryagain3 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using the program!");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong input!");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong input!");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Wrong input!");
        }
    }

    //military aviation!!!!

    if (genre == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("Which playstyle do you prefer more ");
        Console.WriteLine("");
        Console.WriteLine("CLICK 1 then Enter = Dynamic Campaign focus, realism of systems at its finest");
        Console.WriteLine("CLICK 2 then Enter = Multiplayer focus, immersive graphics");
        Console.WriteLine("CLICK 3 then Enter = Arcade style");

        int realism2 = Convert.ToInt32(Console.ReadLine());

        if (realism2 == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("Based from your chosen criteria: ");
            Console.WriteLine("- Military Aviation");
            Console.WriteLine("- Dynamic Campaign focus, realism of systems at its finest");
            Console.WriteLine("The best flight simulator for you is:");
            Console.WriteLine("Falcon BMS");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("CLICK 1 then Enter = Yes");
            Console.WriteLine("CLICK 2 then Enter = No");
            int tryagain3 = Convert.ToInt32(Console.ReadLine());
            if (tryagain3 == 1)
            {
                continue;
            }
            else if (tryagain3 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you for using the program!");
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong input!");
            }

        }

        else if (realism2 == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("Based from your chosen criteria: ");
            Console.WriteLine("- Military Aviation");
            Console.WriteLine("- Multiplayer focus, immersive graphics");
            Console.WriteLine("The best flight simulator for you is:");
            Console.WriteLine("Digital Combat Simulation World (DCS World)");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("CLICK 1 then Enter = Yes");
            Console.WriteLine("CLICK 2 then Enter = No");
            int tryagain4 = Convert.ToInt32(Console.ReadLine());
            if (tryagain4 == 1)
            {
                continue;
            }
            else if (tryagain4 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you for using the program!");
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong input!");
            }
        }

        else if (realism2 == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("Based from your chosen criteria: ");
            Console.WriteLine("- Military Aviation");
            Console.WriteLine("- Arcade style");
            Console.WriteLine("The best flight simulator (or technically an arcade game) for you is:");
            Console.WriteLine("War Thunder or World of Warplanes");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("CLICK 1 then Enter = Yes");
            Console.WriteLine("CLICK 2 then Enter = No");
            int tryagain5 = Convert.ToInt32(Console.ReadLine());
            if (tryagain5 == 1)
            {
                continue;
            }
            else if (tryagain5 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you for using the program!");
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong input!");
            }

        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine("Wrong input!");
        }

    }

}

