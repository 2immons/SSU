using Library.Entities;
using NUnit.Framework;
using System;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace LibraryTest
{
    public class BookTextRepoTest
    {
        Book bookTestObj;
        String serializedTestString;


        [SetUp]
        public void Setup()
        {
            bookTestObj = new Book();
            bookTestObj.Name = "TestName";
            serializedTestString =
            @"{
                ""Id"":0,
                ""Name"":""TestName"",
                ""PageCount"":0,
                ""PublisherName"":null,
                ""PublishDate"":""0001-01-01T00:00:00"",
                ""WrittenDate"":""0001-01-01T00:00:00"",
                ""Author"":null}
            ";
        }

        [Test]
        public void SerializeTest()
        {
            string jsonString = JsonSerializer.Serialize(bookTestObj);
            //Console.WriteLine(jsonString);
            JToken actual = JToken.Parse(jsonString);
            JToken expected = JToken.Parse(serializedTestString);
            Assert.IsTrue(JToken.DeepEquals(actual, expected));
        }

        [Test]
        public void DeserializeTest()
        {
            Book deserializedBook = JsonSerializer.Deserialize<Book>(serializedTestString)!;
            //Console.WriteLine(deserializedBook);
            Assert.AreEqual(bookTestObj, deserializedBook);
        }
    }
}