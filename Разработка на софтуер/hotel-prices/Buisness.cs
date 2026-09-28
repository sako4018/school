public class Buisness
{
    DAL dal = new DAL();

    public decimal CalculatePrice(string month, string type)
    {
        if (month.ToLower() == "may" || month.ToLower() == "october")
        {
            if (type.ToLower() == "studio")
            {
                return (decimal)dal.MayOctoberStudio();
            }
            else if (type.ToLower() == "apartment")
            {
                return (decimal)dal.MayOctoberApartment();
            }
        }
        else if (month.ToLower() == "june" || month.ToLower() == "september")
        {
            if (type.ToLower() == "studio")
            {
                return (decimal)dal.JuneSeptemberStudio();
            }
            else if (type.ToLower() == "apartment")
            {
                return (decimal)dal.JuneSeptemberApartment();
            }
        }
        else if (month.ToLower() == "july" || month.ToLower() == "august")
        {
            if (type.ToLower() == "studio")
            {
                return (decimal)dal.JulyAugustStudio();
            }
            else if (type.ToLower() == "apartment")
            {
                return (decimal)dal.JulyAugustApartment();
            }
        }
    }

}