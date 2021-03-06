﻿using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API function base class.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class Function
    {
        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public abstract string Type { get; set; }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params", Required = Required.Always)]
        public abstract FunctionParams Params { get; set; }
    }
}
