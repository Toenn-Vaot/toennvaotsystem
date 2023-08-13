using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                throw new Exception("Invalid discriminator value");

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
        /// Get sub-type via KnownTypeAttributes
        /// </summary>
        /// <param name="derivedTypeName">The target type name which corresponds to the discriminator</param>
        /// <param name="baseType">The base type</param>
        private Type GetSubType(string derivedTypeName, MemberInfo baseType)
        {
            var knownTypes = baseType.GetCustomAttributes(false).Where(ca => ca.GetType().Name == "KnownTypeAttribute").ToList();

            if (knownTypes == null || knownTypes.Count == 0)
                throw new Exception($"Couldn't find any KnownAttributes over the base {baseType.Name}. Please define at least one KnownTypeAttribute to determine the sub-type");

            foreach (dynamic type in knownTypes)
            {
                if (type.Type != null && type.Type.Name.ToLower() == derivedTypeName.ToLower())
                    return type.Type;
            }

            throw new Exception($"Discriminator '{derivedTypeName}' doesn't match any of the defined sub-types via KnownTypeAttributes");
        }
    }
}
