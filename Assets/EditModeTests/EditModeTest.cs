﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditModeTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void EditModeTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        [Test]
        public void TestReturnValue()
        {
            GameManager gameManager = new GameManager();
            Assert.AreEqual("TestValue", gameManager.ReturnValue());
        }

        [Test]
        public void TestReturnValueFail()
        {
            GameManager gameManager = new GameManager();
            Assert.AreEqual("TestReturnValueFail", gameManager.ReturnValue());
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EditModeTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
