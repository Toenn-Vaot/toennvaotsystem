using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ToennVaot.Components.Core.Api.Exceptions;

namespace ToennVaot.Components.Core.Api.Converters
{
    /// <summary>
    /// The json converter to manage the inheritance of an object
    /// </summary>
    public class InheritanceConverter : JsonConverter
    {
        /// <summary>
        /// Default name for the discriminator property
        /// </summary>
        private string Discriminator { get; } = "discriminator";

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //Check null
            if (reader.TokenType == JsonToken.Null) return null;

            //Parse json
            var jDerivedObject = JObject.Load(reader);

            //Get discriminator
            var discriminator = jDerivedObject.Value<string>(Discriminator);
            if (string.IsNullOrWhiteSpace(discriminator))
                throw new MissingJsonPropertyValueException("Invalid discriminator value");

            //Get the type
            var derivedType = GetSubType(discriminator, objectType);

            //Create a new instance of the target type
            var derivedObject = Activator.CreateInstance(derivedType);

            if(derivedObject != null)
                //Populate the derived object
                serializer.Populate(jDerivedObject.CreateReader(), derivedObject);

            return derivedObject;
        }

        /// <inheritdoc />
        public override bool CanConvert(Type objectType) => true;

        /// <inheritdoc />
        public override bool CanWrite => false;

        /// <summary>
        /// Get subtype via KnownTypeAttributes
        /// </summary>
        /// <param name="derivedTypeName">The target type name which corresponds to the discriminator</param>
        /// <param name="baseType">The base type</param>
        private static Type GetSubType(string derivedTypeName, MemberInfo baseType)
        {
            var knownTypes = baseType.GetCustomAttributes(false).Where(ca => ca.GetType().Name == nameof(KnownTypeAttribute)).ToList();

            if (knownTypes is not { Count: not 0 })
                throw new MissingKnownTypeAttributeException(baseType.Name);

            foreach (dynamic type in knownTypes)
            {
                if (type.Type != null && type.Type.Name.ToLower() == derivedTypeName.ToLower())
                    return type.Type;
            }

            throw new DiscriminatorOutOfRangeException(derivedTypeName);
        }
    }
}
