﻿using System;
namespace PingboardApiClient.Models.CustomFields.Requests
{
    public class CreateCustomFieldRequest
    {
        [JsonProperty("custom_fields")]
        public CustomField CustomField { get; set; } = new CustomField();
    }
}
