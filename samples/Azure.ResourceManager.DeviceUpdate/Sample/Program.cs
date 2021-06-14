// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ArmClient armClient = new ArmClient(new Uri("http://example.com"), new DefaultAzureCredential(), new ArmClientOptions());
            ResourceGroup resourceGroup = (await armClient.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync("resourceGroupName")).Value;

            // Create Account
            Account account = await resourceGroup.GetAccounts().CreateOrUpdateAsync("accountName", new AccountData(LocationData.WestUS2));

            // Get Account
            account = await account.GetAsync();

            // Delete Account
            await account.DeleteAsync();

            // Get a list of Accounts
            await foreach (Account accountInfo in armClient.DefaultSubscription.ListAccountAsync())
            {
                Console.WriteLine(accountInfo);
            }
        }
    }
}
