using System.ComponentModel.DataAnnotations;

namespace _03.ValidacaoCustomizadda
{
    public class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(((string)value).Length == 10)
                return true;
            else
                return false;
        }
    }
}
