class Model
{
    public decimal VegetablesPrice{get; private set;}
    public decimal FruitsPrice{get;private set;}
    public int VegetablesWeight{get;private set;}
    public int FruitsWeight{get;private set;}


    public Model(decimal vegPrice, decimal fruPrice, int vegWeight, int fruWeight)
    {
        VegetablesPrice = vegPrice;
        FruitsPrice = fruPrice;
        VegetablesWeight = vegWeight;
        FruitsWeight = fruWeight;
    } 
    public Model() :this(0,0,0,0)
    {
        
    }
    public bool IsValid()
    {
        if((VegetablesPrice < 0 || VegetablesPrice > 1000) ||
        (FruitsPrice < 0 || FruitsPrice > 1000) ||
        (VegetablesWeight < 0 || VegetablesWeight > 1000)||
        (FruitsWeight < 0 || FruitsWeight > 1000))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public decimal CalculateInEuro()
    {
        decimal vegetables = VegetablesPrice*VegetablesWeight;
        decimal fruits = FruitsPrice*FruitsWeight;

        return (vegetables + fruits) / 1.94m;
    }

}