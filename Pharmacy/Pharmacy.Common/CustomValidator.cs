namespace Pharmacy.Common
{
    public class CustomValidator
    {
        public static bool CheckIfObjectNull(object obj)
        {
            if (obj != null)
            {
                return false;
            }

            return true;
        }
    }
}
