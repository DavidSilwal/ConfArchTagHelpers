using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ConfArchTagHelpers.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "highlight-if-within-days")]
    public class HighlightDateTagHelper: TagHelper
    {
        [HtmlAttributeName("highlight-if-within-days")]
        public int HighlightIfWithinDays { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var contentObject = await output.GetChildContentAsync();
            var contentString = contentObject.GetContent();
            DateTime date;
            if (!DateTime.TryParse(contentString, out date))
                return;
            if (date >= DateTime.Now.Date && date <= DateTime.Now.Date.AddDays(HighlightIfWithinDays))
                output.Attributes.SetAttribute("class", "text-danger")
 ;       }
    }
}
