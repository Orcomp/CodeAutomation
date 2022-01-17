﻿namespace CodeAutomationConsole
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class FluentBackstageTabControl : Fluent
    {
        public FluentBackstageTabControl() { }

        public string Name { get; set; }

        public FluentBackstageTabItem FluentBackstageTabItem { get; set; }

        public List<FluentButton> Buttons { get; set; }

        public XElement GetXml()
        {
            var xName = XName.Get("Name", X.ToString());

            var xml = new XElement(Ns + "BackstageTabControl",
                new XAttribute(xName, Name),
                FluentBackstageTabItem.GetXml(),
                Buttons.Select(button => button.GetXml())
                );

            return xml;
        }
    }
}
