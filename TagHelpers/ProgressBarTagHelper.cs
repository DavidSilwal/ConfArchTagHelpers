using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ConfArchTagHelpers.TagHelpers
{
    public class ProgressBarTagHelper: TagHelper
    {
        public int Amount { get; set; }
        public int TotalAmount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("class", "progress-bar progress-bar-success");
            var width = Math.Round((double)Amount/TotalAmount * 100);
            output.Attributes.SetAttribute("style", $"width: {width}%; height: 10px");
            base.Process(context, output);
        }
    }
}
