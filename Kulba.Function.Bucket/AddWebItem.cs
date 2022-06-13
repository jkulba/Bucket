using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Kulba.Function.Bucket
{
    public static class AddWebItem
    {
        [FunctionName("AddWebItem")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Create new Web Item request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);


            WebItemMessage message = new()
            {
                Id = Guid.NewGuid(),
                Title = data?.Name,
                CommandType = data?.CommandType,
                Url = data?.Url,
                CreatedDate = DateTimeOffset.UtcNow
            };

            return (ActionResult)new OkObjectResult(new
            {
                returnMessage = "Success Add New Web Item",
                returnStatusCode = 0,
                MessageId = message.Id,
                MessageTitle = message.Title,
                MessageType = message.CommandType,
                MessageUrl = message.Url,
                CreatedDate = message.CreatedDate
            });
        }
    }

    public record WebItemMessage
    {
        public Guid Id { get; init; }
        [Required]
        public string CommandType { get; init; }
        [Required]
        public string Title { get; init; }
        [Required]
        public string Url { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

    }
}
