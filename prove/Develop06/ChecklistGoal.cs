public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points,  int bonus, int target) : base (shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete += 1;
            if(_amountComplete == _target)
            {
                return GetPoints() + _bonus;
            }
            else
            {
                return GetPoints();
            }
        }
        else
        {
            return 0;
        }
        
    }
    public override bool IsComplete()
    {
        if (_target == _amountComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) -- Currently complete: {_amountComplete}/{_target}";   
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~{GetShortName()}~{GetDescription()}~{GetPoints()}~{_bonus}~{_target}~{_amountComplete}";
    }

}