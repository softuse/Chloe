﻿using System;

namespace Chloe.Annotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class SequenceAttribute : Attribute
    {
        public SequenceAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
