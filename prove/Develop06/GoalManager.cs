/*
I create another attribute to my GoalManager that gives the user the ability to level up.
Everytime the _score increases by 100 the user levels up, and the program Congratulates the player
*/

using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _lvl = 0;

    public GoalManager()
    {
        _goals = new();
        _score = 0;
    }
    public void Start()
    {
        int option = 0;
        while (option != 6)
        {
            DisplayPlayer();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            if (option != 6)
            {
                

                if (option == 1)
                {
                    CreateGoal();
                }
                else if (option == 2)
                {
                    ListGoalDetails();
                }
                else if (option == 3)
                {
                    SaveGoals();
                }
                else if (option == 4)
                {
                    LoadGoals();
                }
                else if (option == 5)
                {
                    RecordEvent();
                }
            }
            
        }

    }
    public void DisplayPlayer()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Current level: {_lvl}\n");
    }
    public void ListGoalName()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            index += 1;
            string goalString = goal.GetStringRepresentation();
            string[] parts = goalString.Split('~');
            string goalType = parts[0];
            string goalName = parts[1];
            Console.WriteLine($"{index}. {goalName}");

        }
    }
    public void ListGoalDetails()
    {
        int index = 0;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            index += 1;
            if (goal.IsComplete())
            {
                Console.WriteLine($"{index}. [X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{index}. [ ] {goal.GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The type of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int typeOfGoal = int.Parse(Console.ReadLine());
        if(typeOfGoal == 1)
        {
            string shortName;
            string description;
            int points;
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("What is a short dicription of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine()); 
            SimpleGoal simpleGoal = new SimpleGoal (shortName, description, points);
            _goals.Add(simpleGoal);
        }
        else if(typeOfGoal == 2)
        {
            string shortName;
            string description;
            int points;
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("What is a short dicription of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine()); 
            EternalGoal eternalGoal = new EternalGoal (shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if(typeOfGoal == 3)
        {
            string shortName;
            string description;
            int points;
            int target;
            int bonus;
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("What is a short dicription of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine()); 
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal (shortName, description, points, bonus, target);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalName();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());
        index -= 1;
        int points = _goals[index].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");
        _score += points;
        int pastLvl = _lvl;
        _lvl = _score / 100;
        if (pastLvl < _lvl)
        {
            Console.WriteLine($"Congratulations! You have level up!\nlvl obtained: {_lvl}");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }
    public void LoadGoals()
    {
        List<Goal> readingGoal = new();
        int score2 = 0; 

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0)
            {
                score2 = int.Parse(lines[i]);
            }
            else
            {
                string[] parts = lines[i].Split("~");
                string goalType = parts[0];
                if (goalType == "SimpleGoal")
                {
                    string goalName = parts[1];
                    string goalDescription = parts[2];
                    int points = int.Parse(parts[3]);
                    string trueOrFalse = parts[4];
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
                    if (trueOrFalse == "True")
                    {
                        simpleGoal.RecordEvent();
                    }
                    readingGoal.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    string goalName = parts[1];
                    string goalDescription = parts[2];
                    int points = int.Parse(parts[3]);
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);
                    readingGoal.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string goalName = parts[1];
                    string goalDescription = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountComplete = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, bonus, target);
                    for (int j = 0; j < amountComplete; j++)
                    {
                        checklistGoal.RecordEvent();
                    }

                    readingGoal.Add(checklistGoal);
                }
            }
        }
       
        _goals = readingGoal;
        _lvl = score2 / 100;
        _score = score2;
    }
}