// <auto-generated>
/*
 * oneof
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// ResponseResultsValue
    /// </summary>
    public partial class ResponseResultsValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResultsValue" /> class.
        /// </summary>
        /// <param name="fileResult"></param>
        public ResponseResultsValue(FileResult fileResult)
        {
            FileResult = fileResult;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResultsValue" /> class.
        /// </summary>
        /// <param name="stringResult"></param>
        public ResponseResultsValue(StringResult stringResult)
        {
            StringResult = stringResult;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets FileResult
        /// </summary>
        public FileResult? FileResult { get; set; }

        /// <summary>
        /// Gets or Sets StringResult
        /// </summary>
        public StringResult? StringResult { get; set; }

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
            sb.Append("class ResponseResultsValue {\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ResponseResultsValue" />
    /// </summary>
    public class ResponseResultsValueJsonConverter : JsonConverter<ResponseResultsValue>
    {
        /// <summary>
        /// Deserializes json to <see cref="ResponseResultsValue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ResponseResultsValue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> type = default;

            FileResult? fileResult = null;
            StringResult? stringResult = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("type") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("FileResult") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderFileResult = utf8JsonReader;
                            fileResult = JsonSerializer.Deserialize<FileResult>(ref utf8JsonReaderFileResult, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("StringResult") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderStringResult = utf8JsonReader;
                            stringResult = JsonSerializer.Deserialize<StringResult>(ref utf8JsonReaderStringResult, jsonSerializerOptions);
                        }
                    }
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class ResponseResultsValue.", nameof(type));

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class ResponseResultsValue.");

            if (fileResult != null)
                return new ResponseResultsValue(fileResult);

            if (stringResult != null)
                return new ResponseResultsValue(stringResult);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="ResponseResultsValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="responseResultsValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ResponseResultsValue responseResultsValue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (responseResultsValue.FileResult != null) {
                FileResultJsonConverter fileResultJsonConverter = (FileResultJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(responseResultsValue.FileResult.GetType()));
                fileResultJsonConverter.WriteProperties(writer, responseResultsValue.FileResult, jsonSerializerOptions);
            }

            if (responseResultsValue.StringResult != null) {
                StringResultJsonConverter stringResultJsonConverter = (StringResultJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(responseResultsValue.StringResult.GetType()));
                stringResultJsonConverter.WriteProperties(writer, responseResultsValue.StringResult, jsonSerializerOptions);
            }

            WriteProperties(writer, responseResultsValue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ResponseResultsValue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="responseResultsValue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ResponseResultsValue responseResultsValue, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
