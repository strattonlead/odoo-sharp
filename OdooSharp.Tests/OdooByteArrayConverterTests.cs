using System.Text.Json;
using System.Text.Json.Serialization;
using OdooSharp.Configuration;
using Xunit;

namespace OdooSharp.Tests
{
    public class OdooByteArrayConverterTests
    {
        private class TestObject
        {
            [JsonConverter(typeof(OdooByteArrayConverter))]
            public byte[] Data { get; set; }
        }

        [Fact]
        public void Deserialize_Base64String_ReturnsByteArray()
        {
            var json = "{\"Data\": \"AQIDBA==\"}";
            var result = JsonSerializer.Deserialize<TestObject>(json);
            Assert.NotNull(result.Data);
            Assert.Equal(new byte[] { 1, 2, 3, 4 }, result.Data);
        }

        [Fact]
        public void Deserialize_Null_ReturnsNull()
        {
            var json = "{\"Data\": null}";
            var result = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Null(result.Data);
        }

        [Fact]
        public void Deserialize_False_ReturnsNull()
        {
            var json = "{\"Data\": false}";
            var result = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Null(result.Data);
        }

        [Fact]
        public void Deserialize_EmptyObject_ReturnsNull()
        {
            var json = "{\"Data\": {}}";
            var result = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Null(result.Data);
        }

        [Fact]
        public void Deserialize_ObjectWithContent_ReturnsNull()
        {
            var json = "{\"Data\": {\"key\": \"value\"}}";
            var result = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Null(result.Data);
        }
    }
}
