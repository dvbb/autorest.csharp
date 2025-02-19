// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using lro_LowLevel;

namespace lro_LowLevel.Samples
{
    public partial class Samples_LRORetrysClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put201CreatingSucceeded200_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation<BinaryData> operation = client.Put201CreatingSucceeded200(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put201CreatingSucceeded200_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation<BinaryData> operation = await client.Put201CreatingSucceeded200Async(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put201CreatingSucceeded200_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation<BinaryData> operation = client.Put201CreatingSucceeded200(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put201CreatingSucceeded200_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation<BinaryData> operation = await client.Put201CreatingSucceeded200Async(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAsyncRelativeRetrySucceeded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation<BinaryData> operation = client.PutAsyncRelativeRetrySucceeded(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAsyncRelativeRetrySucceeded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation<BinaryData> operation = await client.PutAsyncRelativeRetrySucceededAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAsyncRelativeRetrySucceeded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation<BinaryData> operation = client.PutAsyncRelativeRetrySucceeded(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAsyncRelativeRetrySucceeded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation<BinaryData> operation = await client.PutAsyncRelativeRetrySucceededAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteProvisioning202Accepted200Succeeded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation<BinaryData> operation = client.DeleteProvisioning202Accepted200Succeeded(WaitUntil.Completed, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteProvisioning202Accepted200Succeeded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation<BinaryData> operation = await client.DeleteProvisioning202Accepted200SucceededAsync(WaitUntil.Completed, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteProvisioning202Accepted200Succeeded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation<BinaryData> operation = client.DeleteProvisioning202Accepted200Succeeded(WaitUntil.Completed, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteProvisioning202Accepted200Succeeded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation<BinaryData> operation = await client.DeleteProvisioning202Accepted200SucceededAsync(WaitUntil.Completed, null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningState").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("provisioningStateValues").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("location").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete202Retry200_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = client.Delete202Retry200(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete202Retry200_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = await client.Delete202Retry200Async(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete202Retry200_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = client.Delete202Retry200(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete202Retry200_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = await client.Delete202Retry200Async(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteAsyncRelativeRetrySucceeded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = client.DeleteAsyncRelativeRetrySucceeded(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteAsyncRelativeRetrySucceeded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = await client.DeleteAsyncRelativeRetrySucceededAsync(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteAsyncRelativeRetrySucceeded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = client.DeleteAsyncRelativeRetrySucceeded(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteAsyncRelativeRetrySucceeded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            Operation operation = await client.DeleteAsyncRelativeRetrySucceededAsync(WaitUntil.Completed);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post202Retry200_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation operation = client.Post202Retry200(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post202Retry200_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation operation = await client.Post202Retry200Async(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post202Retry200_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation operation = client.Post202Retry200(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post202Retry200_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation operation = await client.Post202Retry200Async(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PostAsyncRelativeRetrySucceeded_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation operation = client.PostAsyncRelativeRetrySucceeded(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PostAsyncRelativeRetrySucceeded_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = null;
            Operation operation = await client.PostAsyncRelativeRetrySucceededAsync(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PostAsyncRelativeRetrySucceeded_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation operation = client.PostAsyncRelativeRetrySucceeded(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PostAsyncRelativeRetrySucceeded_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            LRORetrysClient client = new LRORetrysClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    provisioningState = "<provisioningState>",
                },
                tags = new
                {
                    key = "<tags>",
                },
                location = "<location>",
            });
            Operation operation = await client.PostAsyncRelativeRetrySucceededAsync(WaitUntil.Completed, content);
        }
    }
}
