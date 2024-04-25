// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TestCollectionEndingWithWordListObject
    /// </summary>
    public partial class TestCollectionEndingWithWordListObject : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCollectionEndingWithWordListObject" /> class.
        /// </summary>
        /// <param name="testCollectionEndingWithWordList">testCollectionEndingWithWordList</param>
        [JsonConstructor]
        public TestCollectionEndingWithWordListObject(Option<List<TestCollectionEndingWithWordList>> testCollectionEndingWithWordList = default)
        {
            TestCollectionEndingWithWordListOption = testCollectionEndingWithWordList;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TestCollectionEndingWithWordList
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<TestCollectionEndingWithWordList>> TestCollectionEndingWithWordListOption { get; private set; }

        /// <summary>
        /// Gets or Sets TestCollectionEndingWithWordList
        /// </summary>
        [JsonPropertyName("TestCollectionEndingWithWordList")]
        public List<TestCollectionEndingWithWordList> TestCollectionEndingWithWordList { get { return this.TestCollectionEndingWithWordListOption; } set { this.TestCollectionEndingWithWordListOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestCollectionEndingWithWordListObject {\n");
            sb.Append("  TestCollectionEndingWithWordList: ").Append(TestCollectionEndingWithWordList).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TestCollectionEndingWithWordListObject" />
    /// </summary>
    public class TestCollectionEndingWithWordListObjectJsonConverter : JsonConverter<TestCollectionEndingWithWordListObject>
    {
        /// <summary>
        /// Deserializes json to <see cref="TestCollectionEndingWithWordListObject" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TestCollectionEndingWithWordListObject Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<TestCollectionEndingWithWordList>> testCollectionEndingWithWordList = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "TestCollectionEndingWithWordList":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                testCollectionEndingWithWordList = new Option<List<TestCollectionEndingWithWordList>>(JsonSerializer.Deserialize<List<TestCollectionEndingWithWordList>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (testCollectionEndingWithWordList.IsSet && testCollectionEndingWithWordList.Value == null)
                throw new ArgumentNullException(nameof(testCollectionEndingWithWordList), "Property is not nullable for class TestCollectionEndingWithWordListObject.");

            return new TestCollectionEndingWithWordListObject(testCollectionEndingWithWordList);
        }

        /// <summary>
        /// Serializes a <see cref="TestCollectionEndingWithWordListObject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testCollectionEndingWithWordListObject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TestCollectionEndingWithWordListObject testCollectionEndingWithWordListObject, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, testCollectionEndingWithWordListObject, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TestCollectionEndingWithWordListObject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testCollectionEndingWithWordListObject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TestCollectionEndingWithWordListObject testCollectionEndingWithWordListObject, JsonSerializerOptions jsonSerializerOptions)
        {
            if (testCollectionEndingWithWordListObject.TestCollectionEndingWithWordListOption.IsSet && testCollectionEndingWithWordListObject.TestCollectionEndingWithWordList == null)
                throw new ArgumentNullException(nameof(testCollectionEndingWithWordListObject.TestCollectionEndingWithWordList), "Property is required for class TestCollectionEndingWithWordListObject.");

            if (testCollectionEndingWithWordListObject.TestCollectionEndingWithWordListOption.IsSet)
            {
                writer.WritePropertyName("TestCollectionEndingWithWordList");
                JsonSerializer.Serialize(writer, testCollectionEndingWithWordListObject.TestCollectionEndingWithWordList, jsonSerializerOptions);
            }
        }
    }
}
