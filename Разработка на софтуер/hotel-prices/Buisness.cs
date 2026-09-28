public class Buisness
{
    DAL dal = new DAL();

    public decimal CalculatePrice(string month, string type, int days)
    {
        if (month.ToLower() == "may" || month.ToLower() == "october")
        {
            if (type.ToLower() == "studio")
            {
                if (days > 7 && days <= 14)
                {
                    return (decimal)(dal.MayOctoberStudio() * 0.95);
                }
                else if (days > 14)
                {
                    return (decimal)(dal.MayOctoberStudio() * 0.70);
                }
                else
                {
                    return (decimal)dal.MayOctoberStudio();
                }
            }
            else if (type.ToLower() == "apartment")
            {
                if (days > 14)
                {
                    return (decimal)(dal.MayOctoberApartment() * 0.90);
                }
                else
                {
                    return (decimal)dal.MayOctoberApartment();
                }
            }
        }
        else if (month.ToLower() == "june" || month.ToLower() == "september")
        {
            if (type.ToLower() == "studio")
            {
                if (days > 14)
                {
                    return (decimal)(dal.JuneSeptemberStudio() * 0.80);
                }
                else
                {
                    return (decimal)dal.JuneSeptemberStudio();
                }
            }
            else if (type.ToLower() == "apartment")
            {
                if (days > 14)
                {
                    return (decimal)(dal.JuneSeptemberApartment() * 0.90);
                }
                else
                {
                    return (decimal)dal.JuneSeptemberApartment();
                }
            }
        }
        else if (month.ToLower() == "july" || month.ToLower() == "august")
        {
            if (type.ToLower() == "studio")
            {
                if (days > 14)
                {
                    return (decimal)(dal.JulyAugustStudio() * 0.80);
                }
                else
                {
                    return (decimal)dal.JulyAugustStudio();
                }
            }
            else if (type.ToLower() == "apartment")
            {
                if (days > 14)
                {
                    return (decimal)(dal.JulyAugustApartment() * 0.90);
                }
                else
                {
                    return (decimal)dal.JulyAugustApartment();
                }
            }
        }
    }

}