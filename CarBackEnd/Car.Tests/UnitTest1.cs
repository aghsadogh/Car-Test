﻿using System;
using NUnit.Framework;

namespace Car.Tests
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
			int i = 2;
            Assert.Zero(i);
        }
    }
}
