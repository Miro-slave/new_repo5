using System;

namespace ShopUI.Models.Customer
{
    public class BonusCard
    {
        public int BonusPoints { get; private set; }
        public event Action<int> OnBonusesChanged;

        public BonusCard(int initialPoints)
        {
            BonusPoints = initialPoints;
        }

        public void AddBonuses(decimal amount)
        {
            int earned = (int)(amount / 10); // 10% кэшбэк
            BonusPoints += earned;
            OnBonusesChanged?.Invoke(BonusPoints);
        }

        public bool SpendBonuses(decimal amount)
        {
            if (BonusPoints >= (int)amount)
            {
                BonusPoints -= (int)amount;
                OnBonusesChanged?.Invoke(BonusPoints);
                return true;
            }
            return false;
        }
    }
}
