﻿using System.Diagnostics;
using System.Threading.Tasks;
using Verify;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

namespace TheNamesapce
{
    public class NamerInNamespaceTests :
        VerifyBase
    {
        [Fact]
        public Task Run()
        {
            return Verify("value");
        }

        public NamerInNamespaceTests(ITestOutputHelper output) :
            base(output)
        {
        }
    }
}