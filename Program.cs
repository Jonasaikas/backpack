using System;

namespace backpack
{
    class Program
    {
      //Vektor för att hålla fem saker
        static string[] items = new string[5];
        static void Main(string[] args)
        {
           while(true){
                
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Tryck på enter för att komma till menyn!");
                Console.ReadKey();
                Console.Clear();

                //Menyn
                Console.WriteLine("[1]Lägg till föremål");
                Console.WriteLine("[2]Byt ut ett föremål");
                Console.WriteLine("[3]Skriv ut innehållet");
                Console.WriteLine("[4]Rensa väskan");
                Console.WriteLine("[5]Avsluta");
                try{
                int answer=Convert.ToInt32(Console.ReadLine());
                 

                    //Switch för alla valen
                    switch(answer){
                        //Användare lägger till 5st saker
                        case 1:
                        AddItem();
                        break;

                        //Byt ut en av sakerna
                        case 2:
                        RemoveItem();
                        break;

                        //Skriver ut innehållet
                        case 3:
                        ShowItems();
                        break;

                        //Rensar innehållet
                        case 4:
                        ClearBag();
                        break;

                        //Avslutar menyn
                        case 5:
                        return;
                        
                    }
                }catch{
                    Console.WriteLine("Du måste ange en siffra mellan 1-5!\nFörsök igen.");
                }
                
            }
        }
        static void AddItem()
        {
            Console.Clear();
            Console.WriteLine("Mata in fem saker du vill lägga till i väskan.");
            Console.WriteLine("----------------------------------------------------");
                        
            //Loop som går om 5 gånger och låter användaren skriva in saker att lägga till
            for(int i=0;i<items.Length;i++){
            items[i]=Console.ReadLine();
            }
        }
        static void RemoveItem()
        {
            Console.Clear();
            for(int i=0;i<items.Length;i++){
            Console.WriteLine((i+1)+"."+(items[i]));
            }

            //Användaren väljer nummer på saken som ska bytas ut
            Console.WriteLine("--------------------------------------");
            Console.Write("Välj nummret på saken du vill byta ut: ");
            try{
            int nummer = Convert.ToInt32(Console.ReadLine());

            if ( nummer ==1 || nummer==2 || nummer ==3 || nummer==4 || nummer==5)
            {
            //Gör så att man anger mellan 1-5
            nummer--;
            
            //Användaren skriver in en ny sak
            Console.WriteLine("Skriv vilken ny sak du vill lägga i väskan: ");
            items[nummer] = Console.ReadLine();
             }
            }catch{
                Console.WriteLine("Du måste ange en siffra mellan 1-5!");
            }
        }
        static void ShowItems()
        {
            Console.Clear();
            Console.WriteLine("Dessa saker finns i din väska:");

            for(int i=0;i<items.Length;i++){
            Console.WriteLine((i+1)+"."+(items[i]));
            }
        }
        static void ClearBag()
        {
            for(int i=0;i<items.Length;i++){
            items[i]="";
            }
            Console.WriteLine("Din väska är nu tömd!");
        }
    }
}
