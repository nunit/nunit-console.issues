using NUnit.Framework;
using Newtonsoft.Json;
using System;

namespace TestWithAdditionalPackageRef
{
    public class Class1
    {
        [Test]
        public void SimpleTest()
        {
            Assert.Pass("SimpleTest passed!");
        }

        [Test]
        public void JsonTest()
        {
            var stringWriter = new System.IO.StringWriter();
            var jsonWriter = new JsonTextWriter(stringWriter);
            jsonWriter.WriteStartObject();
            jsonWriter.WriteComment("Just a comment");
            jsonWriter.WriteEndObject();

            Assert.That(stringWriter.ToString(), Is.EqualTo("{/*Just a comment*/}"));
        }
    }
}