

using CodeWars;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SharkTest
    {
        [Test, Description("should construct an object properly")]
        public void ConstructorTest()
        {
            Shark billy = new Shark("Billy", 3, "Alive and well");
            Assert.AreEqual("Billy", billy.Name);
            Assert.AreEqual(3, billy.Age);
            Assert.AreEqual(0, billy.Legs);
            Assert.AreEqual("shark", billy.Species);
            Assert.AreEqual("Alive and well", billy.Status);
            Assert.AreEqual("Hello, my name is Billy and I am 3 years old.", billy.Introduce());
            Shark charles = new Shark("Charles", 8, "Looking for a mate");
            Assert.AreEqual("Charles", charles.Name);
            Assert.AreEqual(8, charles.Age);
            Assert.AreEqual(0, charles.Legs);
            Assert.AreEqual("shark", charles.Species);
            Assert.AreEqual("Looking for a mate", charles.Status);
            Assert.AreEqual("Hello, my name is Charles and I am 8 years old.", charles.Introduce());
        }
    }

    [TestFixture]
    public class CatTest
    {
        [Test, Description("should construct an object properly")]
        public void ConstructorTest()
        {
            Cat cathy = new Cat("Cathy", 7, "Playing with a ball of yarn");
            Assert.AreEqual("Cathy", cathy.Name);
            Assert.AreEqual(7, cathy.Age);
            Assert.AreEqual(4, cathy.Legs);
            Assert.AreEqual("cat", cathy.Species);
            Assert.AreEqual("Playing with a ball of yarn", cathy.Status);
            Assert.AreEqual("Hello, my name is Cathy and I am 7 years old.  Meow meow!", cathy.Introduce());
            Cat spitsy = new Cat("Spitsy", 6, "sleeping");
            Assert.AreEqual("Spitsy", spitsy.Name);
            Assert.AreEqual(6, spitsy.Age);
            Assert.AreEqual(4, spitsy.Legs);
            Assert.AreEqual("cat", spitsy.Species);
            Assert.AreEqual("sleeping", spitsy.Status);
            Assert.AreEqual("Hello, my name is Spitsy and I am 6 years old.  Meow meow!", spitsy.Introduce());
        }
    }

    [TestFixture]
    public class DogTest
    {
        [Test, Description("should construct an object properly")]
        public void ConstructorTest()
        {
            Dog doug = new Dog("Doug", 12, "Serving his master", "Eliza");
            Assert.AreEqual("Doug", doug.Name);
            Assert.AreEqual(12, doug.Age);
            Assert.AreEqual(4, doug.Legs);
            Assert.AreEqual("dog", doug.Species);
            Assert.AreEqual("Serving his master", doug.Status);
            Assert.AreEqual("Hello Eliza", doug.GreetMaster());
        }
    }
}