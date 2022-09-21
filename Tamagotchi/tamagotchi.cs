using System;

public class Tamagotchi
{
    int hunger;
    int boredom;
    List<string> words = new List<string>() {"Hi!"}; 
    bool isAlive;
    Random generator;
    public string name;

    public Tamagotchi(){
        this.isAlive = true;
        this.generator = new Random();
    }
    public void Feed(){
        hunger -= 2;
        if (hunger < 0) {
            hunger = 0;
        }
    }
    public void Hi(){
        int wordNum = generator.Next(words.Count);
        Console.WriteLine(name + " says: " + words[wordNum]);
        ReduceBoredom();
    }
    public void Teach(string word){
        Console.WriteLine(name + " learned: " + word);
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick(){
        hunger++;
        boredom++;
        if(hunger >= 10 || boredom >= 10){
            isAlive = false;
        }
    }
    public void PrintStats(){
        Console.Write("\n" + "Name: " + name + "\n" + "Hunger: " + hunger + "\n" + "Boredom: " + boredom + "\n" + "Vocabulary: " + words.Count + "words" + "\n");
    }
    public bool GetAlive(){
        return isAlive;
    }
    void ReduceBoredom(){
        Console.Write("\n" + name + " is now less bored!");
        boredom -= 2;
        if (boredom < 0){
            boredom = 0;
        }
    }
    
}


