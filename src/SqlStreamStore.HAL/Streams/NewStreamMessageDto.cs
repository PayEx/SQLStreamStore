﻿namespace SqlStreamStore.HAL.Streams
{
    using System;
    using Newtonsoft.Json.Linq;
    using SqlStreamStore.Streams;

    internal class NewStreamMessageDto
    {
        public Guid MessageId { get; set; }
        public string Type { get; set; }
        public JObject JsonData { get; set; }
        public JObject JsonMetadata { get; set; }

        public NewStreamMessage ToNewStreamMessage()
            => new NewStreamMessage(MessageId, Type, JsonData.ToString(), JsonMetadata?.ToString());
    }
}