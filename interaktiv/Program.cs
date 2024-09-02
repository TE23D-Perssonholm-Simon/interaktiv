
List<Scene> scenes = new List<Scene>();
scenes.Add(new Scene(@"As you arrive at the edge of the Forbidden Jungle, you find two paths diverging. The left path looks
well-trodden but dark and ominous, while the right path is overgrown and filled with dense foliage.",0,"left","right"));
scenes.Add(new Scene(@"You decide to take the left path. As you venture deeper, the jungle grows darker, and you hear
distant growls. Suddenly, you come across a wild animal blocking your way.",2,"scare it", "run around"));

int currentScene = 0;

scenes.Add(new Scene("hejsansvejsan",-1, "val1","val2"));
System.Console.WriteLine(@"You are Alex, a seasoned explorer known for your bravery and intelligence. You've just received a
mysterious map that supposedly leads to a hidden treasure in the heart of the Forbidden Jungle.
Determined to find it, you set off on your adventure.");
Console.ReadLine();
while (true)
{
currentScene = scenes[currentScene].Run();
}

class Methods
{
    
    public static int Decision(string firstopption, string secondopption)
    {
        
        while (true)
        {
            string decision = Console.ReadLine().ToLower();
            if (decision == firstopption)
            {
                return(1);

            }
            else if (decision == secondopption)
            {
                return(2);
            }
            else
            {
                Console.WriteLine($"type {firstopption} or {secondopption}");
                
            }
        }
    }
}


class Scene
{
    private string text;
    private int options;
    string option1;
    string option2;
    public Scene(string text, int options, string option1, string option2)
    {
        this.text = text;
        this.options = options;
        this.option1 = option1;
        this.option2 = option2;
    }

    public int Run()
    {
        Console.Clear();
        Console.WriteLine(@$"{text}");
        Console.WriteLine(option1);
        Console.WriteLine(option2);
        return(Methods.Decision(option1, option2) + options);
    }

}





