using System;

public class tamagotchi
{
    int hunger;
    int boredom;
    List<string> words; 
    bool isAlive;
    Random generator;
    public string name;

    public tamagotchi(int hunger, int boredom, List<string> words, bool isAlive, Random generator, string name){
        this.hunger = hunger;
        this.boredom = boredom;
        this.words = words;
        this.isAlive = isAlive;
        this.generator = generator;
        this.name = name;
    }
    public void Feed(){

    }
    public void Hi(){

    }
    public void Teach(){

    }
    public void Tick(){
        while(hunger < 10 || boredom < 10){
           hunger++;
           boredom++;
        }
        isAlive = false;
    }
    public void PrintStats(){

    }
    public bool GetAlive(){

    }
    void ReduceBoredom(){

    }
    
}


