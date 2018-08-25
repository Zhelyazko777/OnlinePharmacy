namespace Pharmacy.Models
{
    public class CrossIngredient
    {
        public int CrossId { get; set; }
        public DrugIngredient Cross { get; set; }

        public int DrugIngredientId { get; set; }
        public DrugIngredient DrugType { get; set; }
    }
}
