List<string> personer=new List<string>(){"Sigma", "Jonkler", "Man", "Man-bat"};
List<string> rekryter = new List<string>();




while (personer.Count > 0)
{

Console.WriteLine("Dessa är de du kan välja mellan :) ");
for (int jhon = 0; jhon <personer.Count ; jhon ++){
    Console.Write($"{jhon+1}. ");
    Console.WriteLine(personer[jhon]);
}

}

Console.WriteLine("Välj vem du vill anställa för att slåss för mahtog genom att ange deras nummer, klicka 0 för att avsluta rekryteringen");
string input = Console.ReadLine();

int i;

bool sucess = int.TryParse(input, out i);

if (i == 0){
    Console.WriteLine("Rekrytering avslutad, mahtog är cooked gg wp gp next");
    System.Environment.Exit(0);
}












Console.ReadLine();