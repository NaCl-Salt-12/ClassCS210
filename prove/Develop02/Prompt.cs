using System;

public class Prompt
{
    private List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public Prompt()
    {
        _prompts.Add("What was the best part of your day? What made it special?");
        _prompts.Add("List three things you were grateful for today. How did they impact your mood?");
        _prompts.Add("What was the biggest challenge you faced today, and what did you learn from it?");
        _prompts.Add("How are you feeling? What emotions stood out today?");
        _prompts.Add("What are three things you achieved today, big or small");
        _prompts.Add("Did you witness or receive an act of kindness today? How did it make you feel?");
        _prompts.Add("How did you grow today? Did you take a step toward a personal goal?");
        _prompts.Add("Is there anything from today you need to release? How can you let it go?");
        _prompts.Add("What’s something you didn’t get to today that you’ll prioritize tomorrow?");
        _prompts.Add("What mindset or goal do you want to carry into tomorrow?");
    }
}
