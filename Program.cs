public class Program {
     static void Main (){
        Console.Write("Please input a number of stations:");
        int Cost;
        Cost = int.Parse(Console.ReadLine());
        int Price = 0;
        if (Cost == 1){
            Price = 16;
        }
        else if(Cost == 2){
            Price = 23;
        }
        else if(Cost == 3){
            Price = 26;
        }
        else if(Cost == 4){
            Price = 30;
        }
        else if(Cost == 5){
            Price = 33;
        }
        else if(Cost == 6){
            Price = 37;
        }
        else if(Cost == 7){
            Price = 40;
        }
        else if(Cost >= 8 && Cost <= 15){
            Price = 44;
        }
        else if(Cost > 15){
            Price = 59;
        }
        else {
            Console.WriteLine("Error");
        }
        Console.WriteLine("Cost (THB): {0}",Price);
    }
}