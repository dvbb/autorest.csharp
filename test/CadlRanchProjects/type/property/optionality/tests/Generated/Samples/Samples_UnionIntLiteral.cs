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
using _Type.Property.Optionality;
using _Type.Property.Optionality.Models;

namespace _Type.Property.Optionality.Samples
{
    public partial class Samples_UnionIntLiteral
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetAll_ShortVersion()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetAll_ShortVersion_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetAll_ShortVersion_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetAll_ShortVersion_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetAll_AllParameters()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetAll_AllParameters_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetAll_AllParameters_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetAll_AllParameters_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetDefault_ShortVersion()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetDefault_ShortVersion_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetDefault_ShortVersion_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetDefault_ShortVersion_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetDefault_AllParameters()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetDefault_AllParameters_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_GetDefault_AllParameters_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_GetDefault_AllParameters_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            Response<UnionIntLiteralProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutAll_ShortVersion()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutAll_ShortVersion_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutAll_ShortVersion_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty();
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutAll_ShortVersion_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty();
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutAll_AllParameters()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = 1,
            });
            Response response = client.PutAll(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutAll_AllParameters_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = 1,
            });
            Response response = await client.PutAllAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutAll_AllParameters_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty
            {
                Property = BinaryData.FromObjectAsJson(1),
            };
            Response response = client.PutAll(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutAll_AllParameters_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty
            {
                Property = BinaryData.FromObjectAsJson(1),
            };
            Response response = await client.PutAllAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutDefault_ShortVersion()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutDefault_ShortVersion_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutDefault_ShortVersion_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty();
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutDefault_ShortVersion_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty();
            Response response = await client.PutDefaultAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutDefault_AllParameters()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = 1,
            });
            Response response = client.PutDefault(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutDefault_AllParameters_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = 1,
            });
            Response response = await client.PutDefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UnionIntLiteral_PutDefault_AllParameters_Convenience()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty
            {
                Property = BinaryData.FromObjectAsJson(1),
            };
            Response response = client.PutDefault(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UnionIntLiteral_PutDefault_AllParameters_Convenience_Async()
        {
            UnionIntLiteral client = new OptionalClient().GetUnionIntLiteralClient(apiVersion: "1.0.0");

            UnionIntLiteralProperty body = new UnionIntLiteralProperty
            {
                Property = BinaryData.FromObjectAsJson(1),
            };
            Response response = await client.PutDefaultAsync(body);
        }
    }
}
