using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ConfArchTagHelpers.TagHelpers
{
    public class TdTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("style", "background: #ffffff url('img/sweden.png') no-repeat right;");
        }
    }
}
