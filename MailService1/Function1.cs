using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MailService1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("warsztaty", Connection = "DefaultEndpointsProtocol=https;AccountName=codeandcloudstorage;AccountKey=qGBu92MukQm0/cocMBL/EArWG3/hQlsAOccA6O/Q3EuFpkWElmJi2ywad7sblFt/4lfKqDM3vcs07up2MnxdrQ==;EndpointSuffix=core.windows.net")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
