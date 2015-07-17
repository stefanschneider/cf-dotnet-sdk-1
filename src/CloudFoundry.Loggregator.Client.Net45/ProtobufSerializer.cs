namespace CloudFoundry.Loggregator.Client
{
    using System;
    using System.IO;
    using ProtoBuf;
    using ProtoBuf.Meta;

    internal class ProtobufSerializer : IProtobufSerializer
    {
        /// <summary>
        /// Deserializes an ApplicationLog based on raw data using protobuf
        /// </summary>
        /// <param name="data">byte[] data</param>
        /// <returns>An ApplicationLog instance</returns>
        public ApplicationLog DeserializeApplicationLog(byte[] data)
        {
            //// https://github.com/cloudfoundry/loggregatorlib/blob/master/logmessage/log_message.pb.go#L52

            RuntimeTypeModel model = RuntimeTypeModel.Create();
            Type applicationLogType = typeof(ApplicationLog);
            model.Add(applicationLogType, true);
            model[applicationLogType].Add(1, "Message");

            model[applicationLogType].Add(2, "LogMessageType");

            model[applicationLogType].Add(3, "Timestamp");
            model[applicationLogType][3].DataFormat = DataFormat.ZigZag;

            model[applicationLogType].Add(4, "AppId");

            model[applicationLogType].Add(6, "SourceId");
            model[applicationLogType][6].IsRequired = false;

            model[applicationLogType].Add(7, "DrainUrls");

            model[applicationLogType].Add(8, "SourceName");
            model[applicationLogType][8].IsRequired = false;

            ApplicationLog log = null;

            using (MemoryStream stream = new MemoryStream(data))
            {
                return (ApplicationLog)model.Deserialize(stream, log, applicationLogType);                
            }
        }
    }
}
