﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap01.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = $"{MailTo}@fiap.com";
            output.Attributes.SetAttribute("href", $"mailto:{address}");
            output.Content.SetContent(address);
            
            //base.Process(context, output);
        }
    }
}
