﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotterdam_Airlines
{
    class UserInterface
    {
        public UserInterface()
        { }

        // PRINT HET LOGO NAAR DE CONSOLE
        public static void PrintLogo()
        {
            Console.WriteLine(@" _____       _   _               _                          _      _ _                 ");
            Console.WriteLine(@"|  __ \     | | | |             | |                   /\   (_)    | (_)                ");
            Console.WriteLine(@"| |__) |___ | |_| |_ ___ _ __ __| | __ _ _ __ ___    /  \   _ _ __| |_ _ __   ___  ___ ");
            Console.WriteLine(@"|  _  // _ \| __| __/ _ \ '__/ _` |/ _` | '_ ` _ \  / /\ \ | | '__| | | '_ \ / _ \/ __|");
            Console.WriteLine(@"| | \ \ (_) | |_| ||  __/ | | (_| | (_| | | | | | |/ ____ \| | |  | | | | | |  __/\__ \");
            Console.WriteLine(@"|_|  \_\___/ \__|\__\___|_|  \__,_|\__,_|_| |_| |_/_/    \_\_|_|  |_|_|_| |_|\___||___/");
            Console.WriteLine();
        }

        // PRINTS ALL THE OPTIONS OF THE MAIN MENU
        // TO THE CONSOLE.
        public static void PrintMainMenu()
        {
            Console.WriteLine("1: Vlucht boeken");
            Console.WriteLine("2: Overzicht boekingen");
            Console.WriteLine("3: Mededelingen");
            Console.WriteLine("4: Aanbiedingen");
            Console.WriteLine("5: Informatie");
            Console.WriteLine();
            Console.WriteLine("6: Account");
            Console.WriteLine("7: Contact");
            Console.WriteLine("8: Afsluiten");
            Console.WriteLine();
        }

        public static void PrintAccountMenu(bool authorized)
        {
            if (authorized == true)
            {
                Console.WriteLine("0: Hoofdmenu");
                Console.WriteLine();
                Console.WriteLine("1: Gegevens aanpassen");
                Console.WriteLine("2: Overzicht boekingen");
                Console.WriteLine("3: Uitloggen");
            }
            else
            {
                Console.WriteLine("0: Hoofdmenu");
                Console.WriteLine();
                Console.WriteLine("1: Inloggen");
                Console.WriteLine("2: Registreren");
                Console.WriteLine("3: Wachtwoord vergeten");
                Console.WriteLine();
            }
        }

        public static void PrintRegisterMenu(Customer CurrenctUser)
        {
            Console.WriteLine($"    0: Terug          ");
            Console.WriteLine();
            Console.WriteLine($"    1: Email          - {CurrenctUser.email}");
            Console.WriteLine($"    2: Wachtwoord     - {CurrenctUser.password}");
            Console.WriteLine($"    3: Naam           - {CurrenctUser.first_name}");
            Console.WriteLine($"    4: Achternaam     - {CurrenctUser.last_name}");
            Console.WriteLine($"    5: Land           - {CurrenctUser.country}");
            Console.WriteLine($"    6: Geslacht       - {CurrenctUser.gender}");
            Console.WriteLine($"    7: Geboortedatum  - {CurrenctUser.birth_date}");
            Console.WriteLine($"    8: Telefoonnummer - {CurrenctUser.phone_number}");
            Console.WriteLine();
            Console.WriteLine($"    9: Afronden       ");
            Console.WriteLine();
        }

    }
}