﻿using Newtonsoft.Json;

namespace Fido2NetLib.Objects
{
    /// <summary>
    /// Holds parsed credential data
    /// </summary>
    public class AttestationVerificationSuccess
    {
        [JsonConverter(typeof(Base64UrlConverter))]
        public byte[] PublicKey { get; set; }

        [JsonConverter(typeof(Base64UrlConverter))]
        public byte[] CredentialId { get; set; }
    }
}