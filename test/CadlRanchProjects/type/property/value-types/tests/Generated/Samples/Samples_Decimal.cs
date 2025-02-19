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
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    public partial class Samples_Decimal
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_GetDecimal_ShortVersion()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response response = client.GetDecimal(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_GetDecimal_ShortVersion_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response response = await client.GetDecimalAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_GetDecimal_ShortVersion_Convenience()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response<DecimalProperty> response = client.GetDecimal();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_GetDecimal_ShortVersion_Convenience_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response<DecimalProperty> response = await client.GetDecimalAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_GetDecimal_AllParameters()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response response = client.GetDecimal(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_GetDecimal_AllParameters_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response response = await client.GetDecimalAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_GetDecimal_AllParameters_Convenience()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response<DecimalProperty> response = client.GetDecimal();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_GetDecimal_AllParameters_Convenience_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            Response<DecimalProperty> response = await client.GetDecimalAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_Put_ShortVersion()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_Put_ShortVersion_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_Put_ShortVersion_Convenience()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            DecimalProperty body = new DecimalProperty(default);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_Put_ShortVersion_Convenience_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            DecimalProperty body = new DecimalProperty(default);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_Put_AllParameters()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_Put_AllParameters_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Decimal_Put_AllParameters_Convenience()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            DecimalProperty body = new DecimalProperty(default);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Decimal_Put_AllParameters_Convenience_Async()
        {
            Decimal client = new ValueTypesClient().GetDecimalClient(apiVersion: "1.0.0");

            DecimalProperty body = new DecimalProperty(default);
            Response response = await client.PutAsync(body);
        }
    }
}
