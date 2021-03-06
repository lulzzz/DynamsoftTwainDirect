﻿using System;

namespace MQTTnet.Server
{
    public class MqttSubscriptionInterceptorContext
    {
        public MqttSubscriptionInterceptorContext(string clientId, TopicFilter topicFilter)
        {
            if (topicFilter == null) throw new ArgumentNullException(nameof(topicFilter));
            ClientId = clientId;
            TopicFilter = topicFilter;
        }

        public string ClientId { get; }

        public TopicFilter TopicFilter { get; }
        
        public bool AcceptSubscription { get; set; } = true;

        public bool CloseConnection { get; set; }
    }
}
