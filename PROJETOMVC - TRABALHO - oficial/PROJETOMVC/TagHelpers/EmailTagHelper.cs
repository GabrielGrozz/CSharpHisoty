using Microsoft.AspNetCore.Razor.TagHelpers;

namespace PROJETOMVC.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Endereco { get; set; }
        public string COnteudo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}
