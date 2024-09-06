
List<Scene> scenes = new List<Scene>();
scenes.Add(new Scene(@"As you arrive at the edge of the Forbidden Jungle, you find two paths diverging. The left path looks
well-trodden but dark and ominous, while the right path is overgrown and filled with dense foliage.",0,"left","right"));
scenes.Add(new Scene(@"You decide to take the left path. As you venture deeper, the jungle grows darker, and you hear
distant growls. Suddenly, you come across a wild animal blocking your way.",2,"scare it", "run around"));
//fix
scenes.Add(new Scene(@"You take the right path, hacking your way through the dense foliage. The journey is tough, but you
eventually stumble upon an ancient temple covered in vines.",4,"enter the temple", "search around the temple" ));
scenes.Add(new Scene(@"You manage to scare the animal away by making loud noises, and it flees into the jungle. You
continue down the path and find an old, abandoned campsite with a clue pointing further towards
the treasure.",10000,"You find the treasure after a few more challenges."," "));
scenes.Add(new Scene(@"You try to sneak around the animal, but it catches your scent and attacks", 10000,"Your dead", "No respawn"));
scenes.Add(new Scene(@"Inside the temple, you find a series of traps and puzzles. You manage to solve them with some
difficulty, but at the last puzzle, you miscalculate and trigger a trap, sealing the treasure chamber.
You are trapped forever",1000,"You cant excape" ,">:D"));
scenes.Add(new Scene(@"While searching around the temple, you find a hidden entrance leading directly to the treasure
chamber, bypassing all traps. You claim the treasure and escape safely.", 10000, "exit","exit"));


int currentScene = 0;



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





