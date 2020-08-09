namespace SilpoBonusCore
{
    public interface ICondition
    {
        void ApplyCondition(Check check, IReward reward);
    }
}